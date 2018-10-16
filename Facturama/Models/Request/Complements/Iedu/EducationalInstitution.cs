using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Facturama.Models.Request.Complements.Iedu
{
    public class EducationalInstitution
    {

        [JsonProperty("StudentsName")]
        public string StudentsName { get; set; }

        [JsonProperty("Curp")]
        public string Curp { get; set; }

        [JsonProperty("EducationLevel")]
        public string EducationLevel { get; set; }

        [JsonProperty("AutRvoe")]
        public string AutRvoe { get; set; }

        [JsonProperty("PaymentRfc")]
        public string PaymentRfc { get; set; }
    }
}
