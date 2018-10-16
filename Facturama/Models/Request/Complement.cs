
using Facturama.Models.Request.Complements.Pagos;
using Facturama.Models.Request.Complements.Donat;
using Facturama.Models.Request.Complements.ComercioExterior;
using Newtonsoft.Json;

namespace Facturama.Models.Request
{
    public class Complement
    {
        [JsonProperty("Payments")]
        public Payment[] Payments { get; set; }

        [JsonProperty("Donation")]
        public Donat Donation { get; set; }

        [JsonProperty("ForeignTrade")]
        public ForeignTrade ForeignTrade { get; set; }

    }
}
