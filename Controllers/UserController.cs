using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evaluation.Dto.UserDto;
using Evaluation.Services.userServices;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpGet]
        public ActionResult<List<GetUserDto>> GetUsuarios(){
            return Ok(_userServices.GetUsuarios());
        }

        [HttpGet ("{id}")]
        public ActionResult<GetUserDto> GetSingle(int id){
            return Ok(_userServices.GetUser(id));
        }

        [HttpPost]
        public ActionResult<List<GetUserDto>> AddUser(AddUserDto newUser)
        {
            return Ok(_userServices.AddUser(newUser));
        }
    }
}