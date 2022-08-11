using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int PreparationTimeInMinute { get; set; }
        public int Level { get; set; }
        public DateTime AddDate { get; set; }
        public virtual List<Layer> Layers { get; set; }
        public string Preparation { get; set; }
        public int UserId { get; set; }
        public string Image { get; set; }
        public bool IsDisplay { get; set; }
        public virtual User user { get; set; }


        public virtual Category category { get; set; }




    }
}
