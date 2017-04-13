namespace DariaApi.Providers
{
    using DariaApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class UserProvider : IEntityProvider
    {
        private IDbProvider _db;

        public UserProvider(IDbProvider db)
        {
            _db = db;
        }

        public void Add<User>(User data)
        {
            throw new NotImplementedException();
        }

        public void Delete<User>(User u, string id)
        {
            throw new NotImplementedException();
        }

        public IEntity Get<T>(T u, string id)
        {
            return this._db.SelectByIdOperation<User>(id);
        }

        public List<User> GetAll<User>(User u)
        {
            throw new NotImplementedException();
        }

        public void Update<User>(User data)
        {
            throw new NotImplementedException();
        }
    }
}