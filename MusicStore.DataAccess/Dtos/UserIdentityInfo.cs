using System;
using MusicStore.DataAccess.Dtos.Keys;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.Dtos
{
    public class UserIdentityInfo : BaseDto<Credentials>
    {
        public Guid UserId { get; set; }
    }
}
