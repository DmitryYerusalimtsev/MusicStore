using System;

namespace MusicStore.DataAccess.Dtos
{
    public class UserIdentityInfo
    {
        public Guid UserId { get; set; }

        public string LogonName { get; set; }

        public string PasswordHash { get; set; }
    }
}
