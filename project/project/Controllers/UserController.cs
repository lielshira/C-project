using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;
using BLL.CAST;

namespace Web_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        RECIPEdb r;
        UserBL userBL;

       public UserController(RECIPEdb r,UserBL userBL)
        { 
            this.r=r;
            this.userBL = userBL;
           
        }
        [HttpGet]
        public IEnumerable<UserDTO>GetUsers()
        {
            return userBL.GetUsers(r.Users.ToList());

        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserById(int id)
        {
            User u = r.Users.Find(id);
            if (u == null)
                return NotFound();
            return Ok(UserCast.GetUserDTO(u));

        }

        
       


        



    }
}
