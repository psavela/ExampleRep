using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyASPNetApp.Startup))]
namespace MyASPNetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
