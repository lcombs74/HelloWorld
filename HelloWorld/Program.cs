using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HelloWorld.Core.Writers;
using HelloWorld.Core;
using HelloWorld.Core.Interfaces;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// app.config key for the message writer
        /// output target
        /// </summary>
        private const string KEY_OUTPUT_TARGET = "OutputTarget";

        static void Main(string[] args)
        {
            try
            {
                IMessageWriter mw = MessageWriterFactory.CreateMessageWriter(ConfigurationManager.AppSettings[KEY_OUTPUT_TARGET]);
                mw.WriteMessage("Hello World");
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("An error occurred writing the message: {0}", ex.Message));
            }

            Console.WriteLine("Press enter to close application ...");
            Console.ReadLine();
        }
    }
}
