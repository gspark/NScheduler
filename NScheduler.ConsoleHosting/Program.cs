using System;
using Nancy.Hosting.Self;

namespace NScheduler.ConsoleHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://127.0.0.1:9000";

            using (var host = new NancyHost(new Uri(url)))
            {
                host.Start();
                Console.WriteLine("Nancy Server listening on {0}", url);
                Console.ReadLine();
            }
        }
    }
}
