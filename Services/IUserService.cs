using API.Example.Models;

namespace API.Example
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);

    }
}
