using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.Dto.UserDto
{
    public class AddUserDto
    {
        public string name { get; set; } = "Ulises";
        public string  email { get; set; } = "ulises@jojo.com";
        public long phone { get; set; } = 5512345678;
        public UserType type { get; set; } = UserType.Comprador;
    }
}