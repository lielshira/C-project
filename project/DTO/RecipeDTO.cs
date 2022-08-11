using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class RecipeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int PreparationTimeInMinute { get; set; }
        public int Level { get; set; }
        public DateTime AddDate { get; set; }
        public List<LayerDTO> Layers { get; set; }
        public List<string> Preparation { get; set; }
        public int UserId { get; set; }
        public string Image { get; set; }
        public bool IsDisplay { get; set; }
        
        

        


    }
}
