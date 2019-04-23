using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcoTestDalPattern.Startup))]
namespace EcoTestDalPattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
