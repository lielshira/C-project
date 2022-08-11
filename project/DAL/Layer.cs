using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
  public  class Layer
    {
        public int Id { get; set; }
       public string Description { get; set; }
        public string Components { get; set; }
        public int RecipeID { get; set; }
        public virtual Recipe recipe { get; set; }


    }
}
