using Application;
using Application.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace ClienteApi.Controllers
{
    public class CalculaJurosController : ApiController
    {
        [HttpGet]
        [Route("api/calcula/v1/obter-todos-por-id")]
        public async Task<CalculoViewModel> GetCalculoPorId(int id)
        {
            CalculoAplication calculoAplication = new CalculoAplication();
            var calculoViewModel = await calculoAplication.ObterTodosPorId((int)id);
            return calculoViewModel;
        }
        [HttpPost]
        [Route("api/calcula/v1/cadastrar")]
        public async Task<CalculoViewModel> CadastrarCalculo(CalculoViewModel calculoViewModel)
        {
            CalculoAplication calculoAplication = new CalculoAplication();
            if (ModelState.IsValid)
            {
                await calculoAplication.CriarCalculo(calculoViewModel);
            }
            return calculoViewModel;
        }
    }
}
