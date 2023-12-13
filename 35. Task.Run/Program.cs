using System.Threading.Tasks;

namespace _35._Task.Run
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() => DownloadFile("Download File 1"));
            Task task2 = Task.Run(() => DownloadFile("Download File 2"));

            await Task.WhenAll(task1, task2);

            Console.WriteLine("Task1 and Task2 completed.");
        }

        static void DownloadFile(string TaskName)
        {
            Console.WriteLine($"{TaskName} started.");
            Thread.Sleep(1000);
            Console.WriteLine($"{TaskName} completed.");
        }
    }
}
