using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HelloWorld.Core.Writers;
using HelloWorld.Core;
using HelloWorld.Core.Interfaces;
using HelloWorld.Properties;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                IMessageWriter mw = MessageWriterFactory.CreateMessageWriter(Settings.Default.OutputTarget);
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
