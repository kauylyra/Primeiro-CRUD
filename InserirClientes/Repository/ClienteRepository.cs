using Modelo.Models;
using Repository.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ClienteRepository
    {
        private readonly BancoRafaContext db = new BancoRafaContext();

        public async Task<List<Cliente>> ObterTodos()
        {
            var clientes = await db.Clientes.Select(s => s).ToListAsync();

            return clientes;
        }
        public async Task<Cliente> ObterPorId(int id)
        {
            return await db.Clientes.Where(w => w.Id_Cliente == id).FirstOrDefaultAsync();
        }
        public async Task<Cliente> ObterPorNome(string nome)
        {
            return await db.Clientes.Where(w => w.Nome == nome).FirstOrDefaultAsync();
        }
        public async Task CriarCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            await db.SaveChangesAsync();
        }
        public async Task EditarCliente(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
        public async Task ExcluirCliente(Cliente cliente)
        {
            db.Clientes.Remove(cliente);
            await db.SaveChangesAsync();
        }
        public void Dispose()
        {
            db?.Dispose();
        }
    }
}
