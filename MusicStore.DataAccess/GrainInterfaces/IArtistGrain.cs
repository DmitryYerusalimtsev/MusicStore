using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MusicStore.DataAccess.Dtos;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface IArtistGrain : ICrudGrain<ArtistInfo, Guid>
    {
        Task<IEnumerable<Artist>> GetArtists();

        Task<IEnumerable<ArtistAlbum>> GetArtistAlbums(Guid artistId);
    }
}
