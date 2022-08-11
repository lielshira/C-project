using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BLL
{
   public class CategoryBL
    {
        private RECIPEdb cat;
        public CategoryBL(RECIPEdb cat)
        {
            this.cat = cat;
        }
        public List<CategoryDTO> GetCategories()
        {
            List<Category> categories = cat.Categories.ToList();
            List<CategoryDTO> categoriesDtos = new List<CategoryDTO>();
            foreach (Category c in categories)
            {
                categoriesDtos.Add(CAST.CategoryCast.GetCategoryDTO(c));
            }
            return categoriesDtos;
        }

        public CategoryDTO GetCategory(int id)
        {
            return CAST.CategoryCast.GetCategoryDTO(cat.Categories.Find(id));
        }


    }
}
