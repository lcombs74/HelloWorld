using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HelloWorld.Core;
using HelloWorld.Core.Writers;

namespace HelloWorld.Web.Api.Controllers
{
    public class MessageController : ApiController
    {
        public void Post([FromBody]string message)
        {   
            ConsoleMessageWriter cmw = new ConsoleMessageWriter(new HWConsole());
            cmw.WriteMessage(message);
        }
    }
}
