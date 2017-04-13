namespace DariaApi.Providers
{
    using DariaApi.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ProviderRepository
    {
        private IDbProvider _dbProvider;

        public ProviderRepository(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }

        public IEntityProvider GetProvider<T>() where T: class, IEntityProvider
        {
            if (typeof(T) == typeof(UserProvider))
            {
                return new UserProvider(_dbProvider);
            }

            return null;
        }
    }
}