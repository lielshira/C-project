using BLL;
using BLL.CAST;
using DAL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategotyController:ControllerBase
    {
        RECIPEdb r;
        CategoryBL categoryBl;
        public CategotyController(RECIPEdb r,CategoryBL categorybl)
        {
            this.r = r;
            this.categoryBl = categorybl;
        }

        [HttpGet]
        public IEnumerable<CategoryDTO>GetCategories()
        {
            
            return categoryBl.GetCategories();
        }

       [HttpGet("{id}")]
       [ProducesResponseType(StatusCodes.Status200OK,Type=typeof(CategoryDTO))]
       [ProducesResponseType(StatusCodes.Status404NotFound)]

       public IActionResult GetCategoryById(int id)
        {

            Category c = r.Categories.Find(id);
            if (c == null)
                return NotFound();
            return Ok(CategoryCast.GetCategoryDTO(c));



        }



       


    }
}
