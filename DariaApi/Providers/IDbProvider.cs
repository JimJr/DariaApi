namespace DariaApi.Providers
{
    using DariaApi.Models;

    public interface IDbProvider
    {
        T SelectByIdOperation<T>(string selector) where T : class, IEntity;
    }
}
