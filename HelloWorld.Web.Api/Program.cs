using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace HelloWorld.Web.Api
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine(String.Format("Self-Hosted Hello World Web API: {0}", baseAddress));
                Console.WriteLine("");
                Console.WriteLine("Press any key to close...");
                Console.ReadLine();
            }
        }
    }
}
