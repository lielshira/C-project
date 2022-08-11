using BLL;
using DAL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LayerController: ControllerBase
    {
        RECIPEdb r;
        LayerBL layerBl;

        public LayerController(RECIPEdb r, LayerBL layerBL)
        {
            this.r = r;
            this.layerBl = layerBL;
        }

        [HttpGet]
        public IEnumerable<LayerDTO> GetLayers()
        {
            return layerBl.GetLayerDTOs();
        }

        [HttpGet]
        public LayerDTO GetLayerDTO(int id)
        {
            return layerBl.GetLayerDTO(id);
        }




    }
}
