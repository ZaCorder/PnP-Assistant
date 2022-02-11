using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PnP_Assistant.Startup))]
namespace PnP_Assistant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
