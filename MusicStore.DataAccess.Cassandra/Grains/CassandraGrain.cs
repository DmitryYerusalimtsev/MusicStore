using Cassandra;
using Orleans;

namespace MusicStore.DataAccess.Cassandra.Grains
{
    public abstract class CassandraGrain : Grain
    {
        protected ISession Session { get; }

        protected CassandraGrain(ISession session)
        {
            Session = session;
        }
    }
}
