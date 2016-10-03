using System.Threading.Tasks;
using Orleans;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface IReadGrain<T, in TKey> : IGrain
    {
        Task<T> Get(TKey key);
    }
}
