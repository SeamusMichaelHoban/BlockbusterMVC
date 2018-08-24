using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlockbusterMVC.Startup))]
namespace BlockbusterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
