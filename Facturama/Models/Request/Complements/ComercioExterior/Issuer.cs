using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class Issuer
    {
        [JsonProperty("Address")]
        public AddressEmisor Address { get; set; }

        [JsonProperty("Curp")]
        public string Curp { get; set; }

    }
}
