using Newtonsoft.Json;
using System.Collections.Generic;


namespace Facturama.Models.Request.Complements.ComercioExterior
{
    public class ForeignTrade
    {
        [JsonProperty("Issuer")]
        public Issuer Issuer { get; set; }

        [JsonProperty("Receiver")]
        public Receiver Receiver { get; set; }

        [JsonProperty("Owner")]
        public List<Owner> Owner { get; set; }

        [JsonProperty("Recipient")]
        public List<Recipient> Recipient { get; set; }

        [JsonProperty("ReasonForTransfer")]
        public string ReasonForTransfer { get; set; }

        [JsonProperty("OperationType")]
        public string OperationType { get; set; }

        [JsonProperty("Commodity")]
        public List<Commodity> Commodity { get; set; }

        [JsonProperty("RequestCode")]
        public string RequestCode { get; set; }

        [JsonProperty("Incoterm")]
        public string Incoterm { get; set; }

        [JsonProperty("Subdivision")]
        public bool? Subdivision { get; set; }

        [JsonProperty("ExchangeRateUSD")]
        public decimal? ExchangeRateUSD { get; set; }

        [JsonProperty("TotalUSD")]
        public decimal? TotalUSD { get; set; }

        [JsonProperty("OriginCertificate")]
        public bool? OriginCertificate { get; set; }

        [JsonProperty("OriginCertificateNumber")]
        public string OriginCertificateNumber { get; set; }

        [JsonProperty("ReliableExporterNumber")]
        public string ReliableExporterNumber { get; set; }

        [JsonProperty("Observations")]
        public string Observations { get; set; }
    }
}
