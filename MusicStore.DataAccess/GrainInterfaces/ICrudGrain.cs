using System.Threading.Tasks;
using Orleans;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface ICrudGrain<T, in TKey> : IGrain
    {
        Task<T> Get(TKey key);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(TKey key);
    }
}
