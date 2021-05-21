using Modelo;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICalculoRepository
    {
         Task<Calculo> ObterTodosPorId(int id);
         Task<Calculo> CriarCalculo(Calculo calculo);
    }
}
