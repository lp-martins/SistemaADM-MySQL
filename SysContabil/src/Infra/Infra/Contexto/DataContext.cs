using Dominio.Entidades;
using Infra.Contexto.Maps;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<PlanoDeConta> PlanoDeContas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new LancamentoMap());
            modelbuilder.ApplyConfiguration(new PlanoDeContaMap());
        }
    }
}
