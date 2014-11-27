using Likja.DataAccess.Common;
using System.Linq;
using DomainModels = Ticy.Domain.Models;

namespace Ticy.DataAccess.User
{
    public class UserRepository : BaseRepository<DomainModels.User>, IUserRepository
    {
        private readonly IUnitOfWork _uow;
        public UserRepository(IUnitOfWork uow) : base(uow)
        {
            _uow = uow;
        }

        public DomainModels.User FindByEmail(string email)
        {
            var emailToCompare = email.Trim().ToLower();
            return FindAll().SingleOrDefault(x => x.Email.ToLower() == emailToCompare);
        }
    }
}
