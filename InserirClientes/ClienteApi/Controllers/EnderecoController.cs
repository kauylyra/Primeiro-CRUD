using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
namespace ClienteApi.Controllers
{
    public class EnderecoController : ApiController
    {
        [HttpGet]
        [Route("api/endereco/v1/obter-endereco/{cep}")]
        public async Task<object> GetEndereco(string cep)
        {
            HttpClient client = new HttpClient();
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            //string url = @"https://viacep.com.br/ws/"+cep+"/json/";
            //string url = string.Format("https://viacep.com.br/ws/{0}/json/",cep);
            var retorno = await client.GetStringAsync(url);
            return retorno;
        }
    }
}
