using System;

namespace MusicStore.DataAccess.Dtos
{
    public class Song
    {
        public Guid ArtistId { get; set; }

        public string Name { get; set; }

        public string AlbumName { get; set; }

        public string ArtistName { get; set; }

        public string Genre { get; set; }

        public Guid FileId { get; set; }
    }
}
