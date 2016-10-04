using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MusicStore.DataAccess.Dtos;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface IAlbumGrain : ICrudGrain<Album, Guid>
    {
        Task<IEnumerable<Song>> GetSongs(Guid artistId, string albumName);
    }
}
