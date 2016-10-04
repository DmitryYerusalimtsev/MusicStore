using System;
using MusicStore.DataAccess.Dtos.Prototypes;

namespace MusicStore.DataAccess.Dtos
{
    public class User : BaseDto<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
