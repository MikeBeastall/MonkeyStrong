using Microsoft.Owin;
using MonkeyStrong.Web;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace MonkeyStrong.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
