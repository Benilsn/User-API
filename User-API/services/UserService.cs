using System.Collections.Generic;
using User_API.DTO;
using User_API.entities;
using User_API.repositories;

namespace User_API.services
{
    public class UserService
    {

        private readonly UserRepository ur = new UserRepository();

        public List<UserDTO> GetAll()
        {
            var users = ur.GetAll();
            List<UserDTO> list = new List<UserDTO>();

            foreach (User u in users)
            {
                var converted = UserDTO.Convert(u);
                list.Add(converted);
            }
            return list;
        }

        public UserDTO GetById(int id)
        {
            var dto = UserDTO.Convert(ur.GetById(id));

            return dto;
        }

        public void Insert(UserDTO dto)
        {
            var user = new User();
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Age = dto.Age;
            user.Email = dto.Email;
            user.Username = dto.Username;
            user.Password = dto.Password;

            ur.Insert(user);
        }

    }
}
