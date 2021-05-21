using Application.Models;
using Modelo;
using Service;
using System.Threading.Tasks;

namespace Application
{
    public class CalculoAplication
    {
        private readonly CalculoBusiness calculoBusiness = new CalculoBusiness();

        public async Task<CalculoViewModel> ObterTodosPorId(int id)
        {
            var calculo = await calculoBusiness.ObterTodosPorId((int)id);
            if (calculo == null)
            {
                return null;
            }
            CalculoViewModel calculoViewModel = PreencherCalculoViewModel(calculo);
            return calculoViewModel;
        }

        //preenchendo a viewmodel com a model;
        private CalculoViewModel PreencherCalculoViewModel(Calculo calculo)
        {
            return new CalculoViewModel(calculo.Id_Calculo_Juros, calculo.Id_Cliente, calculo.Descricao, calculo.Data_Criacao, calculo.Data_Calculo,
                calculo.Juros, calculo.Tempo, calculo.Taxa, calculo.Capital, calculo.Montante, calculo.Tipo_Calculo);
        }

        public async Task<CalculoViewModel> CriarCalculo(CalculoViewModel calculoViewModel)
        {
            Calculo calculo = PreencherCalculo(calculoViewModel);
            await calculoBusiness.CriarCalculo(calculo);
            CalculoViewModel calculoViewModel1 = PreencherCalculoViewModel(calculo);
            return calculoViewModel1;
        }

        //Preenchendo o model com a viewmodel;
        private Calculo PreencherCalculo(CalculoViewModel calculoViewModel)
        {
            Calculo calculo = new Calculo(calculoViewModel.Id_Calculo_Juros, calculoViewModel.Id_Cliente,
                calculoViewModel.Descricao, calculoViewModel.Data_Criacao, calculoViewModel.Data_Calculo, calculoViewModel.Juros,
                calculoViewModel.Tempo, calculoViewModel.Taxa, calculoViewModel.Capital, calculoViewModel.Montante, calculoViewModel.Tipo_Calculo);

            return calculo;
        }
    }
}
