using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Core.Interfaces;

namespace HelloWorld.Core.Writers
{
    public static class MessageWriterFactory
    {
        public const string TARGET_CONSOLE = "console";

        /// <summary>
        /// Instantiate the IMessageWriter indicated by
        /// the given target
        /// </summary>
        /// <param name="target">type of message writer to instantiate</param>
        /// <returns>requested message writer</returns>
        public static IMessageWriter CreateMessageWriter(string target)
        {
            if (target.ToLower() == TARGET_CONSOLE )
            {
                return new ConsoleMessageWriter(new HWConsole());
            }
            // add more target types as implemented
            //else if (target.ToLower() == TARGET_??)
            else
            {
                throw new Exception("Unknown message target");
            }
        }
    }
}
