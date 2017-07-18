using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.Interfaces
{
    public interface IMessageWriter
    {
        bool WriteMessage(string message);
    }
}
