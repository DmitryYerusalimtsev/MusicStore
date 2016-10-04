using System.Threading.Tasks;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface ICrudGrain<T, in TKey> : IReadGrain<T, TKey>
        where T : IDto<TKey>
    {
        Task Add(T entity);

        Task Update(T entity);

        Task Delete(TKey key);
    }
}