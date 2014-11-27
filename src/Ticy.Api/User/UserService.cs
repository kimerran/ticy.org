using System;
using Ticy.DataAccess.User;
using Ticy.Domain.Models;

namespace Ticy.Api.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int Save(Domain.Models.User entity)
        {
            if (string.IsNullOrEmpty(entity.Username)) entity.Username = Guid.NewGuid().ToString();
            if (string.IsNullOrEmpty(entity.Password)) entity.Password = Guid.NewGuid().ToString();

            return _userRepository.Add(entity);
        }

        Domain.Models.User IUserService.FindByEmail(string email)
        {
            return _userRepository.FindByEmail(email);
        }
    }
}
