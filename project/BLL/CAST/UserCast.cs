using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL.CAST
{
   public  class UserCast
    {
        public static UserDTO GetUserDTO(User user)
        {
            return new UserDTO() { Name = user.Name, Id = user.Id, Address = user.Address, Mail = user.Mail };
        }
        public static User GetUser(UserDTO user)
        {
            return new User() { Name = user.Name, Id = user.Id, Address = user.Address, Mail = user.Mail };
        }


    }
}
