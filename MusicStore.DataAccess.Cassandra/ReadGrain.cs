using System.Linq;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Data.Linq;
using MusicStore.DataAccess.Dtos.Prototypes;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra
{
    public class ReadGrain<T, TKey> : CassandraGrain, IReadGrain<T, TKey>
        where T : IDto<TKey>
    {
        protected ReadGrain(ISession session)
            : base(session)
        {
        }

        public Task<T> Get(TKey key)
        {
            return Task.Run(() => Session
               .GetTable<T>()
               .FirstOrDefault(e => Equals(e.Key, key))
               .Execute());
        }
    }
}
