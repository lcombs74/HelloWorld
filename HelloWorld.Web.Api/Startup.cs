using HelloWorld.Core;
using HelloWorld.Core.Interfaces;
using HelloWorld.Core.Writers;
using HelloWorld.Web.Api.Properties;
using HelloWorld.Web.Api.Resolver;
using Microsoft.Practices.Unity;
using Owin;
using System.Configuration;
using System.Web.Http;

namespace HelloWorld.Web.Api
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Web API configuration
            HttpConfiguration config = new HttpConfiguration();

            // register dependencies
            var container = new UnityContainer();

            // register the configured message writer type   
            container.RegisterInstance(MessageWriterFactory.CreateMessageWriter(Settings.Default.OutputTarget));            
            config.DependencyResolver = new UnityResolver(container);

            // Configure Web API for self-host.             
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }       
    }
}
