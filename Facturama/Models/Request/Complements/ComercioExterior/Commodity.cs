using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class Commodity
    {
        [JsonProperty("SpecificDescriptions")]
        public List<SpecificDescriptions> SpecificDescriptions { get; set; }

        [JsonProperty("IdentificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonProperty("TariffFraction")]
        public string TariffFraction { get; set; }

        [JsonProperty("CustomsQuantity")]
        public decimal? CustomsQuantity { get; set; }

        [JsonProperty("CustomsUnit")]
        public string CustomsUnit { get; set; }

        [JsonProperty("CustomsUnitValue")]
        public decimal? CustomsUnitValue { get; set; }

    
        [JsonProperty("ValueInDolar8")]
        public decimal ValueInDolar { get; set; }

    }
}
