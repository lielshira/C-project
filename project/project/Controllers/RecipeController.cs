using BLL;
using BLL.CAST;
using DAL;
using DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;


namespace Web_API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController:ControllerBase
    {

            RECIPEdb r;
        RecipeBL recipeBL;

            public RecipeController(RECIPEdb r, RecipeBL recipeBL)
            {
                this.r = r;
                this.recipeBL = recipeBL;

            }
          
        [HttpGet]
        public IEnumerable<RecipeDTO> GetRecipeDTOs(int code)
        {
            return recipeBL.GetRecipe(code);

        }

        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RecipeDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        
        public IActionResult GetRecipeById(int code)
        {
            Recipe re = r.Recipes.Find(code);
            if(re==null)
            {
                return NotFound();
            }
            return Ok(RecipeCast.GetRecipeDTO(re));

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult AddRecipe([FromBody] RecipeDTO rec)
        {
            if (rec == null)
                return BadRequest();
            Recipe re = r.Recipes.Find(rec.Id);
            if (re != null)
                return Conflict();
            Recipe newR = RecipeCast.GetRecipe(rec);
            r.Recipes.Add(newR);
            r.SaveChanges();
            return CreatedAtAction(nameof(AddRecipe), RecipeCast.GetRecipeDTO(newR));
        }
        [HttpPut("updateRec/{code}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult UpdateRecipe(RecipeDTO rec,int code)
        {
            if (rec == null)
                return BadRequest();
            if (rec.Id != code)
                return Conflict();
            r.Entry(RecipeCast.GetRecipe(rec)).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            r.SaveChanges();
            return NoContent();

        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteRecipeById(int id)
        {
            Recipe re = r.Recipes.Find(id);
            if (re == null)
                return NotFound();
            r.Recipes.Remove(re);
            r.SaveChanges();
            return NoContent();
        }





    }
    }
