using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL.CAST
{
   public  class CategoryCast
    {
        public static CategoryDTO GetCategoryDTO(Category category)
        {
            return new CategoryDTO() { Id = category.Id, Name = category.Name, Icon = category.Icon };

        }
        public static Category GetCategory(CategoryDTO category)
        {
            return new Category() { Id = category.Id, Name = category.Name, Icon = category.Icon };

        }


    }
}
