using API.Example.Models;

namespace API.Example.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "adi_admin", EmailAddress = "adrianpascaru@yahoo.ro", Password = "1234", GivenName = "Adi", Surname = "Pascaru", Role = "Administrator" },

            new() { Username = "vlad_user", EmailAddress = "valdpascaru@yahoo.ro", Password = "123456", GivenName = "Vlad", Surname = "Pascaru", Role = "User" }
        };

        
    }
}
