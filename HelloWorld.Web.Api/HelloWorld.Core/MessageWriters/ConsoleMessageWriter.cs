using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Core.Interfaces;

namespace HelloWorld.Core.Writers
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        /// <summary>
        /// console to use for writing
        /// </summary>
        private IConsole __console;

        public ConsoleMessageWriter(IConsole console)
        {
            // save injected console object
            __console = console;
        }

        public bool WriteMessage(string message)
        {
            bool retValue = true;
            try
            {
                __console.WriteLine(message);
            }
            catch
            {
                retValue = false;
            }

            return retValue;
        }
    }
}
