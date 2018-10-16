using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class AddressEmisor
    {

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("ExteriorNumber")]
        public string ExteriorNumber { get; set; }

        [JsonProperty("InteriorNumber")]
        public string InteriorNumber { get; set; }

        [JsonProperty("Neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("Reference")]
        public string Reference { get; set; }

        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }
     
    }
}
