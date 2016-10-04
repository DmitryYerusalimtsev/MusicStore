using System;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.Dtos
{
    public class Artist : BaseDto<Guid>
    {
        public string Name { get; set; }

        public FoundedInfo Founded { get; set; }

        public byte[] Logo { get; set; }
    }
}
