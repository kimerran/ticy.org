using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticy.Api.User
{
    public interface IUserService
    {
        Domain.Models.User FindByEmail(string email);
        int Save(Domain.Models.User entity);
    }
}
