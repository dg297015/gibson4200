using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gibson4200.Startup))]
namespace gibson4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
