using Application;
using Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace ClienteApi.Controllers
{
    public class ClientesController : ApiController
    {
        [HttpGet]
        [Route("api/clientes/v1/obter-todos")]
        public async Task<List<ClienteViewModel>> GetClientes()
        {
            ClienteAplication clienteAplication = new ClienteAplication();
            var clienteViewModel = await clienteAplication.ObterTodos();
            return clienteViewModel;
        }
        [HttpGet]
        [Route("api/clientes/v1/obter-por-id/{id:int}")]
        public async Task<ClienteViewModel> DetalhesCliente(int id)
        {
            ClienteAplication clienteAplication = new ClienteAplication();
            var clienteViewModel = await clienteAplication.ObterPorId((int)id);
            return clienteViewModel;
        }
        [HttpPost]
        [Route("api/clientes/v1/cadastrar")]
        public async Task<ClienteViewModel> CadastrarCliente(ClienteViewModel clienteViewModel)
        {
            ClienteAplication clienteAplication = new ClienteAplication();
            if (ModelState.IsValid)
            {
                await clienteAplication.CriarCliente(clienteViewModel);
            }
            return clienteViewModel;
        }
        [HttpPut]
        [Route("api/clientes/v1/editar")]
        public async Task<ClienteViewModel> EditarCliente(ClienteViewModel clienteViewModel)
        {
            ClienteAplication clienteAplication = new ClienteAplication();
            if (ModelState.IsValid)
            {
                await clienteAplication.EditarCliente(clienteViewModel);
            }
            return clienteViewModel;
        }
        [HttpDelete]
        [Route("api/clientes/v1/deletar/{id:int}")]
        public async Task DeletarCliente(int id)
        {
            ClienteAplication clienteAplication = new ClienteAplication();
            await clienteAplication.ExcluirCliente(id);
        }
    }
}
