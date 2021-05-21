using Modelo;
using Repository;
using System;
using System.Threading.Tasks;

namespace Service
{
   public class CalculoBusiness //Camada de negócios;
    {
        private readonly ICalculoRepository calculoRepository = new CalculoRepository();
        public async Task<Calculo> ObterTodosPorId(int id)
        {
            var calculo = await calculoRepository.ObterTodosPorId(id);
            if (calculo == null)
            {
                throw new ArgumentException("Informe um ID existente!");
            }
            return calculo;
        }

        public async Task<Calculo> CriarCalculo(Calculo calculo)
        {
            if (calculo.Tipo_Calculo == "") // Validação (Condição) antes de salvar no bacno;
            {
                throw new ArgumentException("Qual o tipo do calculo? se Simples digite S, se composto digite C.");
            }
            calculo.Calcular();

           return await calculoRepository.CriarCalculo(calculo); // Salvar no banco;
        }
    }
}
