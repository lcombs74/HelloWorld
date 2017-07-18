using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Web.Api.Controllers;
using HelloWorld.Test.Mocks;
using HelloWorld.Core.Interfaces;
using HelloWorld.Core.Writers;

namespace HelloWorld.Test
{
    [TestClass]
    public class MessageControllerTests
    {
        public object MessageController { get; private set; }

        /// <summary>
        /// Test objective: Show that the Post method of the
        /// Message Controller instantiated with the Console Writer,
        /// writes the passed message to the console
        /// using the WriteLine method.
        /// </summary>
        [TestMethod]
        public void TestPostMessageConsole()
        {
            MockConsole mockConsole = new MockConsole();
            MessageController controller = new Web.Api.Controllers.MessageController(new ConsoleMessageWriter((IConsole)mockConsole));           

            controller.Post("Test Message");

            Assert.AreEqual(1, mockConsole.WriteLineStrings.Count);
            Assert.AreEqual(0, mockConsole.WriteStrings.Count);
            Assert.AreEqual("Test Message", mockConsole.WriteLineStrings[0]);
        }
    }
}
