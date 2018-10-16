using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.Terceros
{ 
    class Address
    {
        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("ExteriorNumber")]
        public string ExteriorNumber { get; set; }

        [JsonProperty("InteriorNumber")]
        public string InteriorNumber { get; set; }

        [JsonProperty("Neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("Locality")]
        public string Locality { get; set; }
       
        [JsonProperty("Reference")]
        public string Reference { get; set; }

        [JsonProperty("Municipality")]
        public string Municipality { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }

    }
}
