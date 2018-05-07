using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterestcalcProject.Startup))]
namespace InterestcalcProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
