using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LR7.Startup))]
namespace LR7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
