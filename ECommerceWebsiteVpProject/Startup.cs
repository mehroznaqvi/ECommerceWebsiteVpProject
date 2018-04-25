using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceWebsiteVpProject.Startup))]
namespace ECommerceWebsiteVpProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
