using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.Interfaces
{
    public interface IConsole
    {
        void Write(string output);
        void WriteLine(string output);
        string ReadLine();        
    }
}
