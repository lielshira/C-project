using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL
{
   public class RecipeBL
    {
        private RECIPEdb rec;
        public RecipeBL(RECIPEdb rec)
        {
            this.rec = rec;
        }
        public List<RecipeDTO>GetRecipes()
        {
            List<Recipe> recipes = rec.Recipes.ToList();
            List<RecipeDTO> recDto = new List<RecipeDTO>();
            foreach(Recipe r in recipes)
            {
                recDto.Add(CAST.RecipeCast.GetRecipeDTO(r));
            }
            return recDto;
        }
       
      public List< RecipeDTO> GetRecipe(int id)
        {
            List<RecipeDTO> rec1 = new List<RecipeDTO>();
          
        rec1.Add( CAST.RecipeCast.GetRecipeDTO(rec.Recipes.Find(id)));
            return rec1;
        }

        

    }
}
