using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AM1gara.Startup))]
namespace AM1gara
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
