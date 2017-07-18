using HelloWorld.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Test.Mocks
{
    public class MockConsole : IConsole
    {
        private List<string> __writes = new List<string>();
        private List<string> __writeLines = new List<string>();

        private string __stringToRead = "";

        #region IConsole
        /// <summary>
        /// Add the output to the Writes list
        /// </summary>
        /// <param name="output">string to be "written"</param>
        public void Write(string output)
        {
            __writes.Add(output);
        }

        /// <summary>
        /// Add the output to the WriteLines list
        /// </summary>
        /// <param name="output">string to be "written"</param>
        public void WriteLine(string output)
        {
            __writeLines.Add(output);
        }

        /// <summary>
        /// "Read" a string from the console
        /// </summary>
        /// <returns>string read from console</returns>
        public string ReadLine()
        {
            return __stringToRead;
        }
        #endregion

        /// <summary>
        /// public accessor for strings
        /// written using Write
        /// </summary>
        public List<string> WriteStrings
        {
            get
            {
                return __writes;
            }
        }

        /// <summary>
        /// public accessor for strings 
        /// written using WriteLine
        /// </summary>
        public List<string> WriteLineStrings
        {
            get
            {
                return __writeLines;
            }
        }

        public void ClearAllWrittenStrings()
        {
            __writes.Clear();
            __writeLines.Clear();
        }

        /// <summary>
        /// public setter to tell the mock
        /// what string to return on a read
        /// </summary>
        public string StringToRead
        {
            set
            {
                __stringToRead = value;
            }
        }
    }
}
