using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evaluation.Dto.UserDto;

namespace Evaluation.Services.userServices
{
    public interface IUserServices
    {
        List<GetUserDto> GetUsuarios();
        GetUserDto GetUser(int id);
        List<GetUserDto> AddUser(AddUserDto newUser);
        List<User> UpdateUser(int id);
    }
}