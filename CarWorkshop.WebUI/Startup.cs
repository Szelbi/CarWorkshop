using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarWorkshop.WebUI.Startup))]
namespace CarWorkshop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
