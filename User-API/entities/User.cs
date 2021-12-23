
using User_API.DTO;
using User_API.InputModel;

namespace User_API.entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public static User Convert(UserDTO u)
        {
            var user = new User();

            user.Id = u.Id;
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.Age = u.Age;
            user.Email = u.Email;
            user.Username = u.Username;
            user.Password = u.Password;

            return user;
        }

        public static User Convert(UserInputModel u)
        {
            var user = new User();

            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.Age = u.Age;
            user.Email = u.Email;
            user.Username = u.Username;
            user.Password = u.Password;

            return user;
        }

    }
}
