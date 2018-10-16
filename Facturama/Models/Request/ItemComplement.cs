using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using Facturama.Models.Request.Complements.Terceros;
using Facturama.Models.Request.Complements.Iedu;

namespace Facturama.Models.Request
{
    public class ItemComplement
    {
        [JsonProperty("EducationalInstitution")]
        public EducationalInstitution EducationalInstitution { get; set; }

        [JsonProperty("ThirdPartyAccount")]
        public ThirdPartyAccount ThirdPartyAccount { get; set; }

    }
}
