using System;

namespace Application.Models
{

   public  class CalculoViewModel
    {
        public CalculoViewModel()
        {

        }
        public CalculoViewModel(int id_Calculo_Juros, int id_Cliente, string descricao, DateTime data_criacao, DateTime data_Calculo, decimal juros,
           decimal tempo, decimal taxa, decimal capital, decimal montante, string tipo_Calculo)
        {
            Id_Calculo_Juros = id_Calculo_Juros;
            Id_Cliente = id_Cliente;
            Descricao = descricao;
            Data_Criacao = data_criacao;
            Data_Calculo = data_Calculo;
            //Juros = juros;
            //Tempo = tempo;
            Taxa = taxa;
            Capital = capital;
            //Montante = montante;
            Tipo_Calculo = tipo_Calculo;
        }
        public int Id_Calculo_Juros { get; set; }
        public int Id_Cliente { get;  set; }
        public string Descricao { get;  set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Calculo { get; set; }
        public decimal Juros { get; set; }
        public decimal Tempo { get;  set; }
        public decimal Taxa { get;  set; }
        public decimal Capital { get;  set; }
        public decimal Montante { get; set; }
        public string Tipo_Calculo { get;  set; }
    }
}
