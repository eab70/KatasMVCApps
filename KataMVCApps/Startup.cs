using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KataMVCApps.Startup))]
namespace KataMVCApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
