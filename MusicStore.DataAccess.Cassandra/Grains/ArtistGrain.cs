using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cassandra.Data.Linq;
using MusicStore.DataAccess.Cassandra.SessionPrototypes;
using MusicStore.DataAccess.Dtos;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra.Grains
{
    public class ArtistGrain : CrudGrain<ArtistInfo, Guid, IAccountsSession>, IArtistGrain
    {
        private readonly IMusicSession _musicSession;

        public ArtistGrain(IAccountsSession session, IMusicSession musicSession)
            : base(session)
        {
            _musicSession = musicSession;
        }

        public Task<IEnumerable<Artist>> GetArtists()
        {
            return _musicSession.GetTable<Artist>()
                .Select(artist => artist).ExecuteAsync();
        }

        public Task<IEnumerable<ArtistAlbum>> GetArtistAlbums(Guid artistId)
        {
            return _musicSession.GetTable<ArtistAlbum>()
                .Where(album => album.Key == artistId).ExecuteAsync();
        }
    }
}
