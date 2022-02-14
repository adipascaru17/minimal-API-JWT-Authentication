using API.Example.Models;
using API.Example.Repositories;

namespace API.Example.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(x => x.Username.Equals
               (userLogin.Username) && x.Password.Equals(userLogin.Password));

            return user;

        }

    }
}
