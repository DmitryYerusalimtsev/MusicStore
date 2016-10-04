using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MusicStore.DataAccess.Dtos;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface IUserGrain : ICrudGrain<User, Guid>
    {
        Task<bool> CheckUserCredentials(string login, string password);

        Task<IEnumerable<PurchasedAlbum>> GetPurchasedAlbums(Guid userId);
    }
}
