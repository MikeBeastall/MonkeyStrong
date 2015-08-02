using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(co.monkeystrong.web.Startup))]
namespace co.monkeystrong.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
