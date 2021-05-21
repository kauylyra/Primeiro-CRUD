using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BancoDeDadosRafa.Startup))]
namespace BancoDeDadosRafa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
