using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gepa.Identity.Base.StartConfig;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gepa.Site.Startup))]
namespace Gepa.Site
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            CommonStartupAuth commonStartupAuth = new CommonStartupAuth();
            commonStartupAuth.ConfigureAuth(app);
        }
    }
}