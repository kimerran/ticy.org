using Likja.Domain.Common;

namespace Ticy.Domain.Models
{
    public class UserEntity : DomainEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
