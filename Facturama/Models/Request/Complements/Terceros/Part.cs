using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.Terceros
{
    public class Part
    {
        [JsonProperty("Quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("IdentificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("UnitPrce")]
        public decimal? UnitPrce { get; set; }

        [JsonProperty("Amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("CustomsInformation")]
        public List<CustomsInformation> CustomsInformation { get; set; }
    }
}
