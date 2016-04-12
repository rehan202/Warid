using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Warid.Startup))]
namespace Warid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
