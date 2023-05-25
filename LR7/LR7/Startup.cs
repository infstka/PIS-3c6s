using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPLab7.Startup))]
namespace ASPLab7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
