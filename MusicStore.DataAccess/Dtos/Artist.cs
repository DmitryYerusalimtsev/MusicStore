using System;

namespace MusicStore.DataAccess.Dtos
{
    public class Artist
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public FoundedInfo Founded { get; set; }

        public byte[] Logo { get; set; }
    }
}
