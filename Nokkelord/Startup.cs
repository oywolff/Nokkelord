using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nokkelord.Startup))]
namespace Nokkelord
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
