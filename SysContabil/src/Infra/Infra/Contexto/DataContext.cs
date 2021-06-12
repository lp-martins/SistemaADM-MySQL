using Dominio.Entidades;
using Infra.Contexto.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
            //modelbuilder.Entity<PlanoDeConta>().HasForeignKey(x => PlanoDeContaID);
        }
    }
}
