using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(SignalR_MVC5_Demo.Startup))]
namespace SignalR_MVC5_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}