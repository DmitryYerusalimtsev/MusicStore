using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MusicStore.DataAccess.Dtos;
using MusicStore.DataAccess.Dtos.Keys;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface IUserGrain : ICrudGrain<User, Guid>
    {
        Task<bool> CheckUserCredentials(Credentials userCredentials);

        Task<IEnumerable<PurchasedAlbum>> GetPurchasedAlbums(Guid userId);
    }
}
