using System.Threading.Tasks;
using Cassandra;
using Cassandra.Data.Linq;
using MusicStore.DataAccess.Dtos.Prototypes;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra.Grains
{
    public class ReadGrain<T, TKey, TSession> : CassandraGrain, IReadGrain<T, TKey>
        where T : IDto<TKey>
        where TSession : ISession
    {
        protected Table<T> Table => Session.GetTable<T>();

        public ReadGrain(TSession session)
            : base(session)
        {
        }

        public Task<T> Get(TKey key)
        {
            return Task.Run(() => Table.FirstOrDefault(e => Equals(e.Key, key))
               .Execute());
        }
    }
}
