using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using System.Threading.Tasks;
using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(NinePoint.Startup))]
namespace NinePoint
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}