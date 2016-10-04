using System;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.Dtos
{
    public class PurchasedAlbum : BaseDto<Guid>
    {
        public Guid ArtistId { get; set; }

        public string AlbumName { get; set; }

        public string Year { get; set; }

        public byte[] Logo { get; set; }
    }
}
