using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(devopsdemo.Startup))]
namespace devopsdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
