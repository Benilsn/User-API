using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using User_API.DTO;
using User_API.entities;
using User_API.InputModel;
using User_API.services;

namespace User_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly UserService us = new UserService();

        [HttpGet]
        public List<UserDTO> GetAll()
        {
            return us.GetAll();
        }

        [HttpGet("{id:int}")]
        public UserDTO GetById([FromRoute] int id)
        {
            return us.GetById(id);
        }

        [HttpPost]
        public void Insert([FromBody] UserInputModel u)
        {
            us.Insert(UserDTO.Convert(u));
        }
    }
}
