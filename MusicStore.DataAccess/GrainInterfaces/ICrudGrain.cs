using System.Threading.Tasks;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface ICrudGrain<T, in TKey> : IReadGrain<T, TKey>
    {
        Task Add(T entity);

        Task Update(T entity);

        Task Delete(TKey key);
    }
}