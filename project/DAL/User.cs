using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class User
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public virtual List<Recipe> recipe { get; set; }
    
    }
}
