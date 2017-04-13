namespace DariaApi.DI
{
    using Ninject;
    using Ninject.Modules;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class DIFactory
    {
        private static IKernel _kernel = new StandardKernel();
        public static IKernel GetKernel()
        {
            return _kernel;
        }

        public static void LoadModule(INinjectModule module)
        {
            if (!_kernel.HasModule(module.Name))
            {
                _kernel.Load(module);
            }
        }

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }

        public static T TryGet<T>()
        {
            return _kernel.TryGet<T>();
        }
    }
}