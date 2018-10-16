using Newtonsoft.Json;
using System.Collections.Generic;

namespace Facturama.Models.Request.Complements.Pagos
{
    public class Payment
    {
        [JsonProperty("RelatedDocument")]
        public List<RelatedDocument> RelatedDocuments { get; set; }

        [JsonProperty("Taxes")]
        public List<Tax> Taxes { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("PaymentForm")]
        public string PaymentForm { get; set; }

        [JsonProperty("Currency")]
        public string Currency { get; set; }

        [JsonProperty("ExchangeRate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("Amount")]
        public decimal Amount { get; set; }

        [JsonProperty("OperationNumber")]
        public string OperationNumber { get; set; }

        [JsonProperty("RfcIssuerPayerAccount")]
        public string RfcIssuerPayerAccount { get; set; }

        [JsonProperty("ForeignAccountNamePayer")]
        public string ForeignAccountNamePayer { get; set; }

        [JsonProperty("PayerAccount")]
        public string PayerAccount { get; set; }

        [JsonProperty("RfcReceiverBeneficiaryAccount")]
        public string RfcReceiverBeneficiaryAccount { get; set; }

        [JsonProperty("BeneficiaryAccount")]
        public string BeneficiaryAccount { get; set; }

    }
}
