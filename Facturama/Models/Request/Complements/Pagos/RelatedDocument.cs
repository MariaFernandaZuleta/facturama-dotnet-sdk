using Newtonsoft.Json;

namespace Facturama.Models.Request.Complements.Pagos
{
    public class RelatedDocument
    {
        [JsonProperty("Uuid")]
        public string Uuid { get; set; }

        [JsonProperty("Serie")]
        public string Serie { get; set; }

        [JsonProperty("Folio")]
        public string Folio { get; set; }

        [JsonProperty("Currency")]
        public string Currency { get; set; }

        [JsonProperty("ExchangeRate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("PaymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("PartialityNumber")]
        public int? PartialityNumber { get; set; }

        [JsonProperty("PreviousBalanceAmount")]
        public decimal? PreviousBalanceAmount { get; set; }

        [JsonProperty("AmountPaid")]
        public decimal? AmountPaid { get; set; }
    }
}
