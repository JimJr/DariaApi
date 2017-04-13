namespace DariaApi.DI
{
    using DariaApi.Providers;
    using Ninject.Modules;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDbProvider>().To<DbProvider>().WithConstructorArgument("connectionString", string.Empty);
        }
    }
}