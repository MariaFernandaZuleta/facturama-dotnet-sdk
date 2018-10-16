using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class Recipient
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NumRegIdTrib")]
        public string NumRegIdTrib { get; set; }

        [JsonProperty("Addresses")]
        public List<Address> Addresses { get; set; }
    }
}
