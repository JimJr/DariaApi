using DariaApi.DI;
using DariaApi.Providers;
using Microsoft.Owin;
using Microsoft.Practices.Unity;
using Ninject.Modules;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(DariaApi.Startup))]

namespace DariaApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
