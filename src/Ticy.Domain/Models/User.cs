using Likja.Domain.Common;

namespace Ticy.Domain.Models
{
    public class User : DomainEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
