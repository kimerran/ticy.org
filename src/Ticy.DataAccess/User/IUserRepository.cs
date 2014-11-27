using Likja.DataAccess.Common;

namespace Ticy.DataAccess.User
{
    public interface IUserRepository : IBaseRepository<Domain.Models.User>
    {
        Domain.Models.User FindByEmail(string email);
    }
}
