using Application;
using Application.Models;
using System;
using System.Windows.Forms;

namespace CalculoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void ObterPorId_Click(object sender, EventArgs e)
        {
            var id_Calculo_Juros = int.Parse(Id_Calculo_Juros.Text);
            try
            {
                CalculoAplication calculoAplication = new CalculoAplication();
                var mostrarCalculo = await calculoAplication.ObterTodosPorId(id_Calculo_Juros);
                Id_Cliente.Text = mostrarCalculo.Id_Cliente.ToString();
                Descricao.Text = mostrarCalculo.Descricao.ToString();
                Juros.Text = mostrarCalculo.Juros.ToString("C");
                Tempo.Text = mostrarCalculo.Tempo.ToString();
                Taxa.Text = mostrarCalculo.Taxa.ToString("C");
                Capital.Text = mostrarCalculo.Capital.ToString("C");
                Montante.Text = mostrarCalculo.Montante.ToString("C");
                Tipo_Calculo.Text = mostrarCalculo.Tipo_Calculo.ToString();
                Data_Calculo.Text = mostrarCalculo.Data_Calculo.ToString("dd-MM-yyyy");
                Data_Criacao.Text = mostrarCalculo.Data_Criacao.ToString("dd-MM-yyyy");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show(erro.InnerException.Message);
            }
        }

        private async void CadastrarCalculo_Click(object sender, EventArgs e)
        {
            var id_Cliente = int.Parse(Id_Cliente.Text);
            var descricao = Descricao.Text;
            //var juros = decimal.Parse(Juros.Text);
            var tempo = decimal.Parse(Tempo.Text);
            var taxa = decimal.Parse(Taxa.Text);
            var capital = decimal.Parse(Capital.Text);
            //var montante = decimal.Parse(Montante.Text);
            var tipo_Calculo = Tipo_Calculo.Text;
            var data_Calculo = DateTime.ParseExact(Data_Calculo.Text, "dd-MM-yyyy", null);
            //var data_Criacao = DateTime.Now;
            try
            {
                CalculoAplication calculoAplication = new CalculoAplication();
                CalculoViewModel calculoViewModel = new CalculoViewModel()
                {
                    Id_Cliente = id_Cliente,
                    Descricao = descricao,
                    //Juros = juros,
                    Tempo = tempo,
                    Taxa = taxa,
                    Capital = capital,
                    //Montante = montante,
                    Tipo_Calculo = tipo_Calculo,
                    Data_Calculo = data_Calculo,
                    //Data_Criacao = data_Criacao
                };
                await calculoAplication.CriarCalculo(calculoViewModel);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.InnerException.Message);
                Console.WriteLine(erro.Message);
            }
        }
    }
}
