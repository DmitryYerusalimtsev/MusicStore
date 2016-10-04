using System.Threading.Tasks;
using MusicStore.DataAccess.Dtos.Prototypes;
using Orleans;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface IReadGrain<T, in TKey> : IGrain
        where T : IDto<TKey>
    {
        Task<T> Get(TKey key);
    }
}
