using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.Donat
{
    public class Donat
    {
        [JsonProperty("AuthorizationNumber")]
        public string AuthorizationNumber { get; set; }

        [JsonProperty("AuthorizationDate")]
        public string AuthorizationDate { get; set; }

        [JsonProperty("Legend")]
        public string Legend { get; set; }
    }
}
