namespace DariaApi.Providers
{
    using DariaApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface IEntityProvider
    {
        IEntity Get<T>(T t, string id);
        List<T> GetAll<T>(T t);
        void Add<T>(T data);
        void Delete<T>(T t, string id);
        void Update<T>(T data);
    }
}