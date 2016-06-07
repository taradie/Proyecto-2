using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CuentasCorrientes.Startup))]
namespace CuentasCorrientes
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
