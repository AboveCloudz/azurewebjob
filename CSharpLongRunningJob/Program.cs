using System;
using System.Threading;

namespace CSharpLongRunningJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var delay_seconds = 2;
            
            if (args.Length == 1 && int.TryParse(args[0], out delay_seconds)){}

            System.Console.WriteLine($"Wait for {delay_seconds} seconds - Time : {DateTime.Now}");
            Thread.Sleep(delay_seconds * 1000);
            System.Console.WriteLine($"Finish - Time : {DateTime.Now}");
        }
    }
}
