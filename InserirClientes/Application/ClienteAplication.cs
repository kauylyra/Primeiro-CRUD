using Application.Models;
using Modelo.Models;
using Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class ClienteAplication
    {
        private readonly ClienteBusiness clienteBusiness = new ClienteBusiness();
        public async Task<List<ClienteViewModel>> ObterTodos()
        {
            var clientes = await clienteBusiness.ObterTodos();
            List<ClienteViewModel> clienteViews = new List<ClienteViewModel>();

            foreach (Cliente cliente in clientes)
            {
                ClienteViewModel clienteViewModel = PreencherViewModel(cliente);
                clienteViews.Add(clienteViewModel);
            }
            return clienteViews;
        }
        public async Task<ClienteViewModel> ObterPorId(int id)
        {
            var cliente = await clienteBusiness.ObterPorId((int)id);
            if (cliente == null)
            {
                return null;
            }
            ClienteViewModel clienteViewModel = PreencherViewModel(cliente);
            return clienteViewModel;
        }
        public async Task<ClienteViewModel> ObterPorNome(string nome)
        {
            var cliente = await clienteBusiness.ObterPorNome(nome);
            if (cliente == null)
            {
                return null;
            }
            ClienteViewModel clienteViewModel = PreencherViewModel(cliente);
            return clienteViewModel;
        }

        public ClienteViewModel PreencherViewModel(Cliente cliente)
        {
            return new ClienteViewModel(cliente.Id_Cliente, cliente.Nome, cliente.Data_Nascimento, cliente.Salario, cliente.Sexo,
                cliente.Estado, cliente.Ativo);
        }

        public async Task CriarCliente(ClienteViewModel clienteViewModel)
        {
            Cliente cliente = PreencherCliente(clienteViewModel);
            await clienteBusiness.CriarCliente(cliente);
        }

        public Cliente PreencherCliente(ClienteViewModel clienteViewModel)
        {
            Cliente cliente = new Cliente(clienteViewModel.Id_Cliente, clienteViewModel.Nome, clienteViewModel.Data_Nascimento,
                clienteViewModel.Salario, clienteViewModel.Sexo, clienteViewModel.Estado, clienteViewModel.Ativo);
            return cliente;
        }

        public async Task EditarCliente(ClienteViewModel clienteViewModel)
        {
            Cliente cliente = PreencherCliente(clienteViewModel);
            await clienteBusiness.EditarCliente(cliente);
        }
        public async Task ExcluirCliente(int id)
        {
            await clienteBusiness.ExcluirCliente(id);
        }
        public void Dispose()
        {
            clienteBusiness.Dispose();
        }
    }
}
