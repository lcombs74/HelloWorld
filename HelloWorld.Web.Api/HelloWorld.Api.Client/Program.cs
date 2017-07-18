using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Api.Client
{
    /// <summary>
    /// Simple console program used to exercise the
    /// Hello World Api
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create HttpCient 
            using (HttpClient client = new HttpClient())
            {
                // create the body content to post
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("", "Hello World")
                });
                
                // post the message to be displayed by the api
                client.PostAsync("http://localhost:9000/api/message", content);
               
                Console.WriteLine("\r\nPress any key to close...");
                Console.ReadLine();
            }
        }
    }
}
