using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examples.Web.Startup))]
namespace Examples.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
