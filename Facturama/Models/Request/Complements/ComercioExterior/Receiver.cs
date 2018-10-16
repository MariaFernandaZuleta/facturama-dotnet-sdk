using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class Receiver
    {
        [JsonProperty("Address")]
        public Address Address { get; set; }

    }
}
