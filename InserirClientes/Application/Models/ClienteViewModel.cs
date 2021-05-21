using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {

        }

        public ClienteViewModel(int id_Cliente, string nome, DateTime data_Nascimento, decimal salario, string sexo, string estado, bool ativo)
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
        public int Id_Cliente { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres")]
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public decimal Salario { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public bool Ativo { get; set; }
    }
}