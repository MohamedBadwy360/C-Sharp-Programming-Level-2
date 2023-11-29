using System;

namespace _04.Logger_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger LogScreen = new Logger(LogToScreen);

            LogScreen.Log("Logged to screen.");
        }

        public static void LogToScreen(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Logger
    {
        // Define a delegate for log action
        public delegate void LogAction(string message);

        // The log action that will be invoked
        private LogAction _logAction;

        public Logger(LogAction logAction)
        {
            _logAction = logAction;
        }

        public void Log(string message)
        {
            _logAction(message);
        }
    }
}
