using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OthelloWebApplication.Startup))]
namespace OthelloWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }

        
    }
}
