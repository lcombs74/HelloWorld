using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HelloWorld.Core;
using HelloWorld.Core.Interfaces;

namespace HelloWorld.Web.Api.Controllers
{
    public class MessageController : ApiController
    {
        /// <summary>
        /// the injected message writer
        /// </summary>
        private IMessageWriter __msgWriter;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="messageWriter">message writer to use to Post a message</param>
        public MessageController(IMessageWriter messageWriter)
        {
            // save injected message writer for later use
            __msgWriter = messageWriter;
        }

        public void Post([FromBody]string message)
        {
            __msgWriter.WriteMessage(message);
        }
    }
}
