using Modelo;
using Repository.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class CalculoRepository : ICalculoRepository
    {
        private readonly BancoRafaContext db = new BancoRafaContext();
        public async Task<Calculo> CriarCalculo(Calculo calculo)
        {
            db.Calculos.Add(calculo);
            await db.SaveChangesAsync();
            return calculo;
        }

        public async Task<Calculo> ObterTodosPorId(int id)
        {
            return await db.Calculos.Where(w => w.Id_Calculo_Juros == id).FirstOrDefaultAsync();
        }
    }
}
