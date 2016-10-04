using System.Threading.Tasks;
using Cassandra;
using Cassandra.Data.Linq;
using MusicStore.DataAccess.Dtos.Prototypes;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra.Grains
{
    public class CrudGrain<T, TKey, TSession> : ReadGrain<T, TKey, TSession>, ICrudGrain<T, TKey>
        where T : IDto<TKey> where TSession : ISession
    {
        public CrudGrain(TSession session)
            : base(session)
        {
        }

        public Task Add(T entity)
        {
            return Table.Insert(entity).ExecuteAsync();
        }

        public Task Update(T entity)
        {
            return Table.Where(e => e.Key.Equals(entity.Key))
                .Update().ExecuteAsync();
        }

        public Task Delete(TKey key)
        {
            return Table.Where(e => e.Key.Equals(key))
                .Delete().ExecuteAsync();
        }
    }
}
