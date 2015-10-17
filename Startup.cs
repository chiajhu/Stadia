using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stadia.Startup))]
namespace Stadia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
