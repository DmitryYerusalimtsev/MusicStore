﻿using System;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.Dtos
{
    public class ArtistAlbum : BaseDto<Guid>
    {
        public string AlbumName { get; set; }

        public int Year { get; set; }

        public byte[] Logo { get; set; }
    }
}
