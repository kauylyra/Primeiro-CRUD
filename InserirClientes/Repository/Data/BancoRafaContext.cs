using Modelo;
using Modelo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository.Data
{
    public class BancoRafaContext : DbContext //Repository (Sempre tem relação à conexão do banco);
    {
        public BancoRafaContext() : base("name=BancoRafaContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Calculo> Calculos { get; set; } 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Cliente>().ToTable("cliente");// classe que localiza o banco;
            modelBuilder.Entity<Calculo>().ToTable("Calculo_Juros");// classe que localiza o banco;
            base.OnModelCreating(modelBuilder);
        }
    }
}
