using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICRC.WEB.Startup))]
namespace ICRC.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
