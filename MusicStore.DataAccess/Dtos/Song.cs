using System;
using MusicStore.DataAccess.Dtos.Keys;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.Dtos
{
    public class Song : BaseDto<SongKey>
    {
        public string AlbumName { get; set; }

        public string ArtistName { get; set; }

        public string Genre { get; set; }

        public Guid FileId { get; set; }
    }
}
