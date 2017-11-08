using Microsoft.Owin.Hosting;
using Owin_Nancy;
using System;

namespace NScheduler.KatanaHosting
{
    //    public class Startup
    //    {
    //        public void Configuration(IAppBuilder app)
    //        {
    //            app.UseNancy();
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://127.0.0.1:8080";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Running on {0}", url);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
        }
    }
}
