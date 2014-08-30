using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCForbiddenIsland.Startup))]
namespace MVCForbiddenIsland
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
