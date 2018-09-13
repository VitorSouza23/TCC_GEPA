using Gepa.Identity.Base.StartConfig;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gepa.Identity.Startup))]
namespace Gepa.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            CommonStartupAuth commonStartupAuth = new CommonStartupAuth();
            commonStartupAuth.ConfigureAuth(app);
        }
    }
}
