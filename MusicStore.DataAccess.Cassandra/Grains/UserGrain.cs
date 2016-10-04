using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cassandra.Data.Linq;
using MusicStore.DataAccess.Cassandra.SessionPrototypes;
using MusicStore.DataAccess.Dtos;
using MusicStore.DataAccess.Dtos.Keys;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra.Grains
{
    public class UserGrain : CrudGrain<User, Guid, IAccountsSession>, IUserGrain
    {
        public UserGrain(IAccountsSession session)
            : base(session)
        {
        }

        public Task<bool> CheckUserCredentials(Credentials userCredentials)
        {
            Task<UserIdentityInfo> getUser = Session.GetTable<UserIdentityInfo>()
                .FirstOrDefault(info => info.Key.Equals(userCredentials)).ExecuteAsync();

            return getUser.ContinueWith(task => task.Result != null);
        }

        public Task<IEnumerable<PurchasedAlbum>> GetPurchasedAlbums(Guid userId)
        {
            return Session.GetTable<PurchasedAlbum>()
                .Where(album => album.Key == userId).ExecuteAsync();
        }
    }
}
