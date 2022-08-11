using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL
{
  public  class UserBL
    {
        private RECIPEdb us;
        public UserBL(RECIPEdb us)
        {
            this.us = us;
        }
        public List<UserDTO>GetUsers(List<User> lists)
        {
            List<User> users = us.Users.ToList();
            List<UserDTO> userDto = new List<UserDTO>();
            foreach(User u in users)
            {
                userDto.Add(CAST.UserCast.GetUserDTO(u));

            }
            return userDto;
        }
        public UserDTO GetUser(int id)
        {
            return CAST.UserCast.GetUserDTO(us.Users.Find(id));
        }


       
    }
}
