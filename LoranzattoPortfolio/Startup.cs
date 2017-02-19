using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoranzattoPortfolio.Startup))]
namespace LoranzattoPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
