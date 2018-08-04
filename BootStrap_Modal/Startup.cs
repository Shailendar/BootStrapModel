using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrap_Modal.Startup))]
namespace BootStrap_Modal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
