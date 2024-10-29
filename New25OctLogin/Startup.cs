using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New25OctLogin.Startup))]
namespace New25OctLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
