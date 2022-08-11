using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public List<RecipeDTO> recipe { get; set; }

    }
}
