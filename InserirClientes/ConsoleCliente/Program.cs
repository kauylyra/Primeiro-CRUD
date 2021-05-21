using Application;
using Application.Models;
using Modelo;
using System;
using System.Threading.Tasks;

namespace ConsoleCliente
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            //try
            //{
            //    CalculoAplication calculoAplication = new CalculoAplication();
            //    CalculoViewModel calculoViewModel = new CalculoViewModel()
            //    {
            //        Id_Cliente = 3
            //    };


            //    calculoAplication.ObterTodosPorId(1).Wait();

            //    var mostrarCalculo = calculoAplication.ObterTodosPorId(1).Result;
            //    Console.WriteLine("O tipo do calculo é : " + mostrarCalculo.Tipo_Calculo);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.InnerException.Message);
            //}
            //Console.ReadLine();


            //try
            //{
            //    CalculoAplication calculoAplication = new CalculoAplication();

            //    CalculoViewModel calculoViewModel = new CalculoViewModel()
            //    {
            //        //Id_Calculo_Juros = 0,
            //        Id_Cliente = 1,
            //        Descricao = "Teste com calculo 4",
            //        Data_Criacao = DateTime.Now,
            //        Data_Calculo = new DateTime(2020, 4, 05),
            //        Taxa = 3,
            //        Capital = 200,
            //        Tipo_Calculo = "S"
            //    };
            //    CalculoViewModel retornoCalculoView =   await calculoAplication.CriarCalculo(calculoViewModel);
            //    Console.WriteLine("O Id do cliente é " + retornoCalculoView.Id_Calculo_Juros + ", o tipo de juros é "+retornoCalculoView.Tipo_Calculo+ " e o valor do juros é de :" + retornoCalculoView.Juros + "R$");
            //}
            //catch (Exception e)
            //{
            //    if (e.InnerException != null)
            //        Console.WriteLine(e.InnerException.Message);

            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();






            try
            {
                ClienteAplication clienteAplication = new ClienteAplication();
                ClienteViewModel clienteViewModel = new ClienteViewModel()
                {
                    Id_Cliente = 0,
                    Nome = "teste3",
                    Data_Nascimento = DateTime.Now,
                    Salario = 1200,
                    Sexo = "M",
                    Estado = "SP",
                    Ativo = false
                };

                clienteAplication.CriarCliente(clienteViewModel).Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
            Console.ReadLine();

            //try
            //{
            //    ClienteAplication clienteAplication = new ClienteAplication();

            //    ClienteViewModel clienteViewModel = new ClienteViewModel()
            //    {
            //        Id_Cliente = 19,
            //        Nome = "Dagnobaldo",
            //        Data_Nascimento = DateTime.Now,
            //        Salario = 3000,
            //        Sexo = "M",
            //        Estado = "SP",
            //        Ativo = true
            //    };

            //    clienteAplication.EditarCliente(clienteViewModel).Wait();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.InnerException.Message);
            //}
            //Console.ReadLine();

            //try
            //{
            //    ClienteAplication clienteAplication = new ClienteAplication();

            //    ClienteViewModel clienteViewModel = new ClienteViewModel()
            //    {
            //        Id_Cliente = 12
            //    };

            //    clienteAplication.ObterPorId(12).Wait();

            //    var mostrarCliente = clienteAplication.ObterPorId(12).Result;
            //    Console.WriteLine(mostrarCliente.Nome);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.InnerException.Message);
            //}
            //Console.ReadLine();


            //try
            //{
            //    ClienteAplication clienteAplication = new ClienteAplication();
            //    var mostrarCliente = clienteAplication.ObterTodos().Result;

            //    foreach (ClienteViewModel clienteViewModel in mostrarCliente)
            //    {
            //        Console.WriteLine(clienteViewModel.Nome);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.InnerException.Message);
            //}
            //Console.ReadLine();



            //try
            //{
            //    ClienteAplication clienteAplication = new ClienteAplication();

            //    ClienteViewModel clienteViewModel = new ClienteViewModel()
            //    {
            //        Id_Cliente = 19
            //    };

            //    clienteAplication.ExcluirCliente(clienteViewModel.Id_Cliente).Wait();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.InnerException.Message);
            //}
            //Console.ReadLine();
        }
    }
}
