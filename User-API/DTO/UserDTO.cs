using User_API.entities;
using User_API.InputModel;

namespace User_API.DTO
{
    public class UserDTO
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public static UserDTO Convert(User u)
        {
            var dto = new UserDTO();

            dto.Id = u.Id;
            dto.FirstName = u.FirstName;
            dto.LastName = u.LastName;
            dto.Age = u.Age;
            dto.Email = u.Email;
            dto.Username = u.Username;
            dto.Password = u.Password;

            return dto;
        }

        public static UserDTO Convert(UserInputModel u)
        {
            var dto = new UserDTO();

            dto.FirstName = u.FirstName;
            dto.LastName = u.LastName;
            dto.Age = u.Age;
            dto.Email = u.Email;
            dto.Username = u.Username;
            dto.Password = u.Password;

            return dto;

        }

    }
}
