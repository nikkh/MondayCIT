using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MondayCIT.Startup))]
namespace MondayCIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
