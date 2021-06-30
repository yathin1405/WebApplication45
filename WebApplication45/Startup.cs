using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication45.Startup))]
namespace WebApplication45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
