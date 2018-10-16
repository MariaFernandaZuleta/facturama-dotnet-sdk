using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class Owner
    {
        [JsonProperty("NumRegIdTrib")]
        public string NumRegIdTrib { get; set; }

        
        [JsonProperty("TaxResidence")]
        public string TaxResidence { get; set; }
    }
}
