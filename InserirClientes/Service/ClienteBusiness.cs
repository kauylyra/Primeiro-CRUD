using Modelo.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class ClienteBusiness
    {
        private readonly ClienteRepository clienteRepository = new ClienteRepository();

        public async Task<List<Cliente>> ObterTodos()
        {
            var clientes = await clienteRepository.ObterTodos();

            return clientes;
        }

        public async Task<Cliente> ObterPorId(int id)
        {
            var cliente = await clienteRepository.ObterPorId(id);
            if (cliente ==null )
            {
                throw new ArgumentException("Informe um ID existente!");
            }
            return cliente;
        }
        public async Task<Cliente> ObterPorNome(string nome)
        {
            var cliente = await clienteRepository.ObterPorNome(nome);
            if (cliente == null)
            {
                throw new ArgumentException("Informe um nome existente!");
            }
            return cliente;
        }

        public async Task CriarCliente(Cliente cliente)
        {
            if (cliente.Nome == "")
            {
                throw new ArgumentException("Preencha todos os campos corretamente!");
            }
            await clienteRepository.CriarCliente(cliente);
        }

        public async Task EditarCliente(Cliente cliente)
        {
            await clienteRepository.EditarCliente(cliente);
        }

        public async Task ExcluirCliente(int id)
        {
            var cliente = await ObterPorId(id);

            if (cliente == null)
            {
                throw new ArgumentException("Informe um ID existente!");
            }
            await clienteRepository.ExcluirCliente(cliente);
        }
        public void Dispose()
        {
            clienteRepository.Dispose();
        }
    }
}
