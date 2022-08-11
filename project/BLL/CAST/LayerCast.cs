using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL;
using DTO;


namespace BLL.CAST
{
    class LayerCast
    {
        public static LayerDTO GetLayerDTO(Layer layer)
        {

            return new LayerDTO() { Description = layer.Description, Components = layer.Components.Split('*').ToList()};

        }
        public static Layer GetLayer(LayerDTO layer)
        {

            return new Layer() { Components =string.Join('*',layer.Components), Description = layer.Description };

        }
    }
}
