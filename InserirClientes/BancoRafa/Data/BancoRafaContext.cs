//using BancoRafa.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;

//namespace BancoRafa.Data
//{
//    public class BancoRafaContext : DbContext
//    {
//        public BancoRafaContext() : base("name=BancoRafaContext")
//        {
//        }

//        public DbSet<Cliente> Clientes { get; set; }
//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//            modelBuilder.Entity<Cliente>().ToTable("cliente");
//            base.OnModelCreating(modelBuilder);
//        }
//    }
//}
