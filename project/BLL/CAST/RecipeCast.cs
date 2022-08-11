using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Linq;

namespace BLL.CAST
{
   public  class RecipeCast
    {
        public static RecipeDTO GetRecipeDTO(Recipe recipe)
        {
            return new RecipeDTO() { Id=recipe.Id,Name=recipe.Name,CategoryId=recipe.CategoryId,PreparationTimeInMinute=recipe.PreparationTimeInMinute, Preparation = recipe.Preparation.Split('*').ToList() };
        
        }
        public static Recipe GetRecipe(RecipeDTO recipe)
        {
            return new Recipe() { Preparation = string.Join('*', recipe.Preparation), Id = recipe.Id, Name = recipe.Name, CategoryId = recipe.CategoryId, PreparationTimeInMinute = recipe.PreparationTimeInMinute};

        }


    }
}
