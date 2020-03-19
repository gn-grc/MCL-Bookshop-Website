using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCL_Bookshop_Website.Startup))]
namespace MCL_Bookshop_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
