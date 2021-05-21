using Application;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await CadastrandoCliente();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            await EditandoCliente();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await ExcluindoCliente();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await ObtendoPorId();
        }
        private async void ObtendoPorNome_Click(object sender, EventArgs e)
        {
            await ObterCPorNome();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await MostrarTudoGrid();
        }

        private async void MostrarTodos_Click(object sender, EventArgs e)
        {
            await MostrarTudoGrid();
        }

        private async Task MostrarTudoGrid()
        {
            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                var listaCliente = await clienteAplication.ObterTodos();

                dataGridView.DataSource = null;
                dataGridView.DataSource = listaCliente;
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
        private async Task CadastrandoCliente()
        {
            var nome = Nome.Text;
            var dataNascimento = DateTime.Parse(DataNascimento.Text);
            var salario = decimal.Parse(Salario.Text);
            var sexo = Sexo.Text;
            var estado = Estado.Text;
            var ativo = bool.Parse(Ativo.Text);
            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                ClienteViewModel clienteViewModel = new ClienteViewModel()
                {
                    Nome = nome,
                    Data_Nascimento = dataNascimento,
                    Salario = salario,
                    Sexo = sexo,
                    Estado = estado,
                    Ativo = ativo
                };
                await clienteAplication.CriarCliente(clienteViewModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private async Task EditandoCliente()
        {
            var id = int.Parse(Id_Cliente.Text);
            var nome = Nome.Text;
            var dataNascimento = DateTime.Parse(DataNascimento.Text);
            var salario = decimal.Parse(Salario.Text);
            var sexo = Sexo.Text;
            var estado = Estado.Text;
            var ativo = bool.Parse(Ativo.Text);

            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                ClienteViewModel clienteViewModel = new ClienteViewModel()
                {
                    Id_Cliente = id,
                    Nome = nome,
                    Data_Nascimento = dataNascimento,
                    Salario = salario,
                    Sexo = sexo,
                    Estado = estado,
                    Ativo = ativo
                };
                await clienteAplication.EditarCliente(clienteViewModel);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private async Task ExcluindoCliente()
        {
            try
            {
                var id = int.Parse(Id_Cliente.Text);
                ClienteAplication clienteAplication = new ClienteAplication();

                ClienteViewModel clienteViewModel = new ClienteViewModel()
                {
                    Id_Cliente = id
                };
                await clienteAplication.ExcluirCliente(clienteViewModel.Id_Cliente);
                MessageBox.Show("Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private async Task ObtendoPorId()
        {
            var id = int.Parse(Id_Cliente.Text);
            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                var resultado = await clienteAplication.ObterPorId(id);
                Nome.Text = resultado.Nome.ToString();
                DataNascimento.Text = resultado.Data_Nascimento.ToString();
                Salario.Text = resultado.Salario.ToString();
                Sexo.Text = resultado.Sexo.ToString();
                Estado.Text = resultado.Estado.ToString();
                Ativo.Text = resultado.Ativo.ToString();

                List<ClienteViewModel> clienteViews = new List<ClienteViewModel>();
                clienteViews.Add(resultado);// adicionando uma lista em cima do resultado ;
                dataGridView.DataSource = null;
                dataGridView.DataSource = clienteViews;
                dataGridView.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.InnerException.Message);
            }
        }

        private async Task ObterCPorNome()
        {
            var nome = Nome.Text;
            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                var resultado = await clienteAplication.ObterPorNome(nome);
                Id_Cliente.Text = resultado.Id_Cliente.ToString();
                DataNascimento.Text = resultado.Data_Nascimento.ToString();
                Salario.Text = resultado.Salario.ToString();
                Sexo.Text = resultado.Sexo.ToString();
                Estado.Text = resultado.Estado.ToString();
                Ativo.Text = resultado.Ativo.ToString();

                List<ClienteViewModel> clienteViews = new List<ClienteViewModel>();
                clienteViews.Add(resultado);// adicionando uma lista em cima do resultado ;
                dataGridView.DataSource = null;
                dataGridView.DataSource = clienteViews;
                dataGridView.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.InnerException.Message);
            }
        }

        private async void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clickNaTela = int.Parse(dataGridView.Rows[e.RowIndex].Cells["Id_Cliente"].Value.ToString());
            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                var resultado = await clienteAplication.ObterPorId(clickNaTela);
                Id_Cliente.Text = resultado.Id_Cliente.ToString();
                Nome.Text = resultado.Nome.ToString();
                DataNascimento.Text = resultado.Data_Nascimento.ToString();
                Salario.Text = resultado.Salario.ToString();
                Sexo.Text = resultado.Sexo.ToString();
                Estado.Text = resultado.Estado.ToString();
                Ativo.Text = resultado.Ativo.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.InnerException.Message);
            }
        }
    }
}
