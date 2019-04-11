using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Docs.Startup))]
namespace Docs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
