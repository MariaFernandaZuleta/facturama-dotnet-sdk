using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.Terceros
{
    public class ThirdPartyAccount
    {
        [JsonProperty("Rfc")]
        public string Rfc { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ThirdTaxInformation")]
        public Address ThirdTaxInformation { get; set; }

        [JsonProperty("CustomsInformation")]
        public CustomsInformation CustomsInformation { get; set; }

        [JsonProperty("Parts")]
        public List<Part> Parts { get; set; }

        [JsonProperty("PropertyTaxNumber")]
        public string PropertyTaxNumber { get; set; }

        [JsonProperty("Taxes")]
        public List<ThirdPartyAccountTax> Taxes { get; set; }
    }

    public class ThirdPartyAccountTax
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Rate")]
        public decimal? Rate { get; set; }

        [JsonProperty("Amount")]
        public decimal Amount { get; set; }

    }

}
