using System;

namespace _01.Temperature_Change_Event_Example
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public float OldTemperature { get; }
        public float NewTemperature { get; }
        public float Difference { get; }

        public TemperatureChangedEventArgs(float oldTemperature, float newTemperature)
        {
            OldTemperature = oldTemperature;
            NewTemperature = newTemperature;
            Difference = newTemperature - oldTemperature;
        }
    }
    public class Thermostate
    {
        public event EventHandler<TemperatureChangedEventArgs> ThermostateChanged;
        private float _oldTemperature;
        private float _currentTemperature;

        public void SetTemperature(float newTemperature)
        {
            if (newTemperature != _currentTemperature)
            {
                _oldTemperature = _currentTemperature;
                _currentTemperature = newTemperature;
                OnTemperatureChanged(_oldTemperature, _currentTemperature);
            }
        }

        public void OnTemperatureChanged(float oldTemperature, float newTemperature)
        {
            OnTemperatureChanged(new TemperatureChangedEventArgs(oldTemperature, newTemperature));
        }

        public virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            ThermostateChanged?.Invoke(this, e);
        }
    }
    public class Display
    {
        public void Subscribe(Thermostate thermostate)
        {
            thermostate.ThermostateChanged += HandleTemperatureChanged;
        }

        public void HandleTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine("\nTemerature Changed.\n");
            Console.WriteLine($"Old Temperature : {e.OldTemperature}");
            Console.WriteLine($"New Temperature : {e.NewTemperature}");
            Console.WriteLine($"Difference : {e.Difference}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermostate thermostate = new Thermostate();
            Display display = new Display();

            display.Subscribe(thermostate);

            thermostate.SetTemperature(25);
            thermostate.SetTemperature(30);
        }
    }
}
