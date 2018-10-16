using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class SpecificDescriptions
    {
        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }
        
        [JsonProperty("SubModel")]
        public string SubModel { get; set; }

        [JsonProperty("SerialNumber")]
        public string SerialNumber { get; set; }


    }
}
