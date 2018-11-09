using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UANL.Startup))]
namespace UANL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
