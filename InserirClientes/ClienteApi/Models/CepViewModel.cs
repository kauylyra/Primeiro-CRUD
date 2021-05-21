using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteApi.Models
{
    public class CepViewModel
    {
        [JsonProperty("CEP")]
        public string CEP { get; set; }

        [JsonProperty("Cidade")]
        public string Cidade { get; set; }

        [JsonProperty("Bairro")]
        public string Bairro { get; set; }

        [JsonProperty("Localidade")]
        public string Localidade { get; set; }

        //[JsonProperty("Complemento")]
        //public string Complemento { get; set; }
        //[JsonProperty("UF")]
        //public string UF { get; set; }
        //public string Unidade { get; set; }
        //public string IBGE { get; set; }
        //public string GIA { get; set; }
    }
}
