using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(API1.Startup))]
namespace API1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
