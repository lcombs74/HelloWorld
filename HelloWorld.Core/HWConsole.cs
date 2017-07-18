using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Core.Interfaces;

namespace HelloWorld.Core
{
    /// <summary>
    /// Thin wrapper around the static Console
    /// object.  Used to facilitate using a mock
    /// Console for testing purposes.
    /// </summary>
    public class HWConsole : IConsole
    {
        /// <summary>
        /// Write the given output string without
        /// carriage return and line feed
        /// </summary>
        /// <param name="output">string to write to the console</param>
        public void Write(string output)
        {
            Console.Write(output);
        }

        /// <summary>
        /// Write the given output string with
        /// carriage return and line feed
        /// </summary>
        /// <param name="output">string to write to the console</param>
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        /// <summary>
        /// Read a string from the Console
        /// </summary>
        /// <returns>string read from the console</returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
