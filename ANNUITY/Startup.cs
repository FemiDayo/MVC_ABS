using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ANNUITY.Startup))]
namespace ANNUITY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
