using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Evaluation.Dto.UserDto;

namespace Evaluation.Services.userServices
{
    public class UserServices : IUserServices
    {
        
        private static List<GetUserDto> usuarios = new List<GetUserDto>{
            //new User()
        };
        private readonly IMapper _mapper;
        public UserServices(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<GetUserDto> AddUser(AddUserDto newUser)
        {
            usuarios.Add(_mapper.Map<GetUserDto>(newUser));
            var user = usuarios.Select(u => _mapper.Map<GetUserDto>(u)).ToList();
            return user;
        }

        public List<GetUserDto> GetUsuarios()
        {
            var user = usuarios.Select(u => _mapper.Map<GetUserDto>(u)).ToList();
            return user;
        }

        public GetUserDto GetUser(int id)
        {
            var user = usuarios.FirstOrDefault(u => u.userId == id);
            var user2 = _mapper.Map<GetUserDto>(user);
            return user2; 
        }

        public List<User> UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}