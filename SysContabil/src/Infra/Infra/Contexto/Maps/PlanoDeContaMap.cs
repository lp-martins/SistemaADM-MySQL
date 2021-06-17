using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class PlanoDeContaMap : IEntityTypeConfiguration<PlanoDeConta>
    {
        public void Configure(EntityTypeBuilder<PlanoDeConta> builder)
        {
            builder.ToTable("PlanoDeContas");
            builder.HasKey(x => x.NumeroDaConta);
            builder.Property(x => x.NumeroDaConta).IsRequired().HasColumnType("varchar(12)");
            builder.Property(x => x.NomeDaConta).IsRequired().HasColumnType("varchar(50)");
        }
    }
}
