using System.Collections.Generic;
using User_API.DTO;
using User_API.entities;
using User_API.InputModel;
using User_API.repositories;
using User_API.services.auth;

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
            user.Password = PasswordHasher.Hash(dto.Password);

            ur.Insert(user);
        }

        public void DeleteById(int id)
        {
            if (Exists(id))
            {
                ur.DeleteById(id);
            }
        }

        public void Update(int id, UserInputModel u)
        {
            if (Exists(id))
            {
                var user = User.Convert(u);
                ur.Update(id, user);
            }
            
        }

        public bool Exists(int id)
        {
            if (ur.GetById(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
