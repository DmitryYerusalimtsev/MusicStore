using System;

namespace MusicStore.DataAccess.Dtos
{
    public class ArtistAlbum
    {
        public Guid ArtistId { get; set; }

        public string AlbumName { get; set; }

        public int Year { get; set; }

        public byte[] Logo { get; set; }
    }
}
