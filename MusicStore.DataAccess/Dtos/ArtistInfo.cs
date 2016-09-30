using System.Collections.Generic;

namespace MusicStore.DataAccess.Dtos
{
    public class ArtistInfo : Artist
    {
        public string Description { get; set; }

        public IList<string> Genres { get; set; }

        public string Language { get; set; }
    }
}
