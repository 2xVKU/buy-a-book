using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetsGetThisDone.Startup))]
namespace LetsGetThisDone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
