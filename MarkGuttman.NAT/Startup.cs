using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarkGuttman.NAT.Startup))]
namespace MarkGuttman.NAT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
