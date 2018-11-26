using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(robosoft.Startup))]
namespace robosoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
