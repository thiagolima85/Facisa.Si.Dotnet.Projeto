
using Facisa.Si.Dotnet.Projeto.Dados.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Facisa.Si.Dotnet.Projeto.Persistencia.Contexto
{
    public class DbContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Atividade> Atividades { get; set; }

        public DbContexto() : base("ProjetoSegundaUnidade")
        {
               
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
