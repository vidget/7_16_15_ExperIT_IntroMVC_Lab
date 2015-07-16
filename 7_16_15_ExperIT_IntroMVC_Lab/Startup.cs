using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7_16_15_ExperIT_IntroMVC_Lab.Startup))]
namespace _7_16_15_ExperIT_IntroMVC_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
