using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LIFE.Startup))]
namespace LIFE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
