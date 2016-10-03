using System.Threading.Tasks;
using Cassandra;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra
{
    public abstract class ReadGrain<T, TKey> : CassandraGrain, IReadGrain<T, TKey>
    {
        protected ReadGrain(ISession session)
            : base(session)
        {
        }

        public Task<T> Get(TKey key)
        {
            throw new System.NotImplementedException();
        }
    }
}
