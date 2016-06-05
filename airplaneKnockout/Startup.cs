using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(airplaneKnockout.Startup))]
namespace airplaneKnockout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
