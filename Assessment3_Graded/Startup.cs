using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assessment3_Graded.Startup))]
namespace Assessment3_Graded
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
