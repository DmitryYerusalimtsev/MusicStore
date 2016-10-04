using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cassandra.Data.Linq;
using MusicStore.DataAccess.Cassandra.SessionPrototypes;
using MusicStore.DataAccess.Dtos;
using MusicStore.DataAccess.GrainInterfaces;

namespace MusicStore.DataAccess.Cassandra.Grains
{
    public class AlbumGrain : CrudGrain<Album, Guid, IMusicSession>, IAlbumGrain
    {
        public AlbumGrain(IMusicSession session)
            : base(session)
        {
        }

        public Task<IEnumerable<Song>> GetSongs(Guid artistId, string albumName)
        {
            return Session.GetTable<Song>()
                    .Where(song => song.Key.ArtistId == artistId && song.AlbumName == albumName)
                    .ExecuteAsync();
        }
    }
}
