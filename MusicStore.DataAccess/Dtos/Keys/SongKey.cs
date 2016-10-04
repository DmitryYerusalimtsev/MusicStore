using System;

namespace MusicStore.DataAccess.Dtos.Keys
{
    public struct SongKey
    {
        public Guid ArtistId { get; set; }

        public string Name { get; set; }
    }
}
