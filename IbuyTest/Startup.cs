using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IbuyTest.Startup))]
namespace IbuyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
