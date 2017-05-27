using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFApplication.Startup))]
namespace LFApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
