using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webpage.Startup))]
namespace Webpage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
