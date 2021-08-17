using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoapp.Startup))]
namespace demoapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
