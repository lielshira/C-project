using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Linq;
using DAL;


namespace BLL
{
   public class LayerBL
    {
        private RECIPEdb lay;
        public LayerBL(RECIPEdb lay)
        {
            this.lay = lay;
        }
        public List<LayerDTO>GetLayerDTOs()
        {
            List<Layer> layer = lay.Layers.ToList();
            List<LayerDTO> lyDTO = new List<LayerDTO>();
            foreach(Layer l1 in layer)
            {
                lyDTO.Add(CAST.LayerCast.GetLayerDTO(l1));
            }
            return lyDTO;
        }

        

        public LayerDTO GetLayerDTO(int id)
        {
            return CAST.LayerCast.GetLayerDTO(lay.Layers.Find(id));
        }







       
     

    }
}
