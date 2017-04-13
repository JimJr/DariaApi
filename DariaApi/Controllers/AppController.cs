namespace DariaApi.Controllers
{
    using DariaApi.Contracts.Entities;
    using DariaApi.Converters;
    using DariaApi.DI;
    using DariaApi.Providers;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Http;

    [RoutePrefix("api/app")]
    public class AppController : ApiController
    {
        private ProviderRepository _providerRepository;
        private bool _isAuthorized;

        public AppController()
        {
            if (_providerRepository == null)
            {
                var dbProvider = DIFactory.Get<IDbProvider>();
                _providerRepository = new ProviderRepository(dbProvider);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IHttpActionResult> Login(UserData data)
        {
            if (data == null)
            {
                return this.Unauthorized();
            }

            var userModel = data.ToModel();
            var user = _providerRepository.GetProvider<UserProvider>().Get(userModel, userModel.UserName);
            if (user != null)
            {
                return this.Ok();
            }

            return this.NotFound();
        }

        [HttpGet]
        [Route("login")]
        public async Task<IHttpActionResult> Login()
        {
            return this.Ok();
        }
    }
}