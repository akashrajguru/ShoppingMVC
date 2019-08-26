using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingMVC.WebUI.Startup))]
namespace ShoppingMVC.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
