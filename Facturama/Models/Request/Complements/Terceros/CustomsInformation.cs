using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.Terceros
{
    public class CustomsInformation
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("Customs")]
        public string Customs { get; set; }
    }
}
