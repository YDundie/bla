using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pisProjekt.Startup))]
namespace pisProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
