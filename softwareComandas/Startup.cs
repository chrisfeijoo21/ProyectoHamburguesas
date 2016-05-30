using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(softwareComandas.Startup))]
namespace softwareComandas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
