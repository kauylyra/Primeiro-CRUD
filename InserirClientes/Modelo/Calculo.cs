using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Calculo  //Coração do sistema (Parte principal que representa o BANCO);
    {
        
        public Calculo()
        {

        }
        public Calculo(int id_Calculo_Juros, int id_Cliente, string descricao, DateTime data_criacao, DateTime data_Calculo, decimal juros,
           decimal tempo, decimal taxa, decimal capital, decimal montante, string tipo_Calculo)
        {
            Id_Calculo_Juros = id_Calculo_Juros;
            Id_Cliente = id_Cliente;
            Descricao = descricao;
            Data_Criacao = data_criacao;
            Data_Calculo = data_Calculo;
            Juros = juros;
            Taxa = taxa;
            Capital = capital;
            Montante = montante;
            Tipo_Calculo = tipo_Calculo;
        }

        private void CalcularTempoEmDias()
        {
            Tempo = (DateTime.Today - Data_Calculo).Days;
        }
        private void CalcularTempoEmMeses()
        {
            DateTime inicio = DateTime.Today;
            DateTime fim = Data_Calculo;

            TimeSpan ts = fim.Subtract(inicio);
            DateTime periodo = new DateTime(ts.Ticks);
            Tempo = periodo.Month;
        }

        [Key]
        public int Id_Calculo_Juros { get; private set; }
        public int Id_Cliente { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Data_Criacao { get; private set; }
        public DateTime Data_Calculo { get; private set; }
        public decimal Juros { get; private set; }
        public decimal Tempo { get; private set; }
        public decimal Taxa { get; private set; }
        public decimal Capital { get; private set; }
        public decimal Montante { get; private set; }
        public string Tipo_Calculo { get; private set; }



        //public void SetIdCalculoJuros(int idCalculoJuros)
        //{
        //    Id_Calculo_Juros = idCalculoJuros;
        //}
        //public void SetIdCliente(int idCliente)
        //{
        //    Id_Cliente = idCliente;
        //}
        //public void SetDescricao(string descricao)
        //{
        //    Descricao = descricao;
        //}
        //public void SetDataCriacao(DateTime dataCriacao)
        //{
        //    Data_Criacao = dataCriacao;
        //}

        //public void SetDataCalculo(DateTime dataCalculo)
        //{
        //    Data_Calculo = dataCalculo;
        //}

        //public void SetCapital(decimal capital)
        //{
        //    Capital = capital;
        //}
        //public void SetTaxa(decimal taxa)
        //{
        //    Taxa = taxa;
        //}
        //public void SetTempo(decimal tempo)
        //{
        //    Tempo = tempo;
        //}

        //public void SetTipoCalculo(string tipoCalculo)
        //{
        //    Tipo_Calculo = tipoCalculo;
        //}
        private static decimal ConverterPorcentagem(decimal valor1)
        {
            return valor1 / 100;
        }
        private decimal Porcentagem()
        {
            decimal porcentagem = ConverterPorcentagem(Taxa);
            return 1 + porcentagem; // 1+i;
        }
        private decimal Elevacao(decimal valor1, decimal valor2)
        {
            decimal calculaparametros2 = (decimal)Math.Pow((double)valor1, (double)valor2);// (1+i)n ;
            return calculaparametros2;
        }
        private decimal CalculoFinal(decimal numero1, decimal numero2)
        {
            return numero1 * numero2; //c.[(1 + i) n ;
        }
        private decimal CalculoComposto()
        {
            decimal calculo1 = Porcentagem();// 1+i;
            decimal calculo2 = Elevacao(calculo1, Tempo);// (1+i)n ;
            decimal calculo3 = CalculoFinal(Capital, calculo2);//C.[(1 + i) N ;
            return calculo3;
        }
        private void CalculoJurosSimples()
        {
            Juros = Capital * Taxa * Tempo;
        }

        public void Calcular()
        {
            //CalcularTempoEmMeses(); //Calculando o tempo em meses antes de tudo;
            CalcularTempoEmDias(); //Calculando o tempo em dias antes de tudo;

            if (Tipo_Calculo.ToUpper() == "S")
            {
                CalculoJurosSimples();
                Montante = Capital + Juros;
            }
            else if (Tipo_Calculo.ToUpper()== "C")
            {
                CalculoComposto();
            }
            else 
                throw new ArgumentException("Escolha um Juros válido");
        }
    }
}
