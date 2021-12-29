using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using User_API.DTO;
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
        public ActionResult<List<UserDTO>> GetAll()
        {
            return Ok(us.GetAll());
        }

        [HttpGet("{id:int}")]
        public ActionResult<UserDTO> GetById([FromRoute] int id)
        { 
            return Ok(us.GetById(id));
        }

        [HttpPost]
        public void Insert([FromBody] UserInputModel u)
        {
            us.Insert(UserDTO.Convert(u));
        }

        [HttpPost]
        [Route("/register")]
        public ActionResult InsertFromForm([FromForm] UserInputModel u)
        {
            us.Insert(UserDTO.Convert(u));
            return Redirect("/login");

        }

        [HttpDelete("{id:int}")]
        public void DeleteById([FromRoute] int id)
        {
            us.DeleteById(id);
        }

        [HttpPut("{id:int}")]
        public void Update([FromRoute] int id, [FromBody] UserInputModel u)
        {
            us.Update(id, u);

        }

        
    }


}
