using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OGMS.Startup))]
namespace OGMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
