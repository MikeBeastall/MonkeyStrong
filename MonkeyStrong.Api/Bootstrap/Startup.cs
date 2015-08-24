using System.Web.Http;
using Microsoft.Owin;
using MonkeyStrong.Api.Bootstrap;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;

[assembly: OwinStartup(typeof (Startup))]

namespace MonkeyStrong.Api.Bootstrap
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var webApiConfiguration = new HttpConfiguration();
            
            webApiConfiguration.Routes.MapHttpRoute(
                "DefaultApi",
                "{controller}/{id}",
                new {id = RouteParameter.Optional, controller = "values"});

            //webApiConfiguration.DependencyResolver = new NinjectResolver(NinjectConfig.CreateKernel());

            app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(webApiConfiguration);
        }

        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind(x => x.FromThisAssembly() // Scans currently assembly
                .SelectAllClasses() // Retrieve all non-abstract classes
                .BindDefaultInterface());

            return kernel;
        }
    }
}