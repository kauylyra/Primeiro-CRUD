using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(int id_Cliente, string nome, DateTime data_Nascimento, decimal salario, string sexo, string estado, bool ativo)
        {
            Id_Cliente = id_Cliente;
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Salario = salario;
            Sexo = sexo;
            Estado = estado;
            Ativo = ativo;
        }
        [Key]
        public int Id_Cliente { get; private set; }
        public string Nome { get; private set; }
        public DateTime Data_Nascimento { get; private set; }
        public decimal Salario { get; private set; }
        public string Sexo { get; private set; }
        public string Estado { get; private set; }
        public bool Ativo { get; private set; }

        public void SetTodos()
        {

        }
        public void SetIdCliente(int id_Cliente)
        {
            Id_Cliente = id_Cliente;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetDataNascimento(DateTime data_Nascimento)
        {
            Data_Nascimento = data_Nascimento;
        }
        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }
        public void SetSexo(string sexo)
        {
            Sexo = sexo;
        }
        public void SetEstado(string estado)
        {
            Estado = estado;
        }
        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}