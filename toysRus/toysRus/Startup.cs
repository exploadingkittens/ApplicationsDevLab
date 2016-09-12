using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(toysRus.Startup))]
namespace toysRus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
