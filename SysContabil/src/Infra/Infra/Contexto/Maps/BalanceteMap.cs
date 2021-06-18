using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class BalanceteMap : IEntityTypeConfiguration<Balancete>
    {
        public void Configure(EntityTypeBuilder<Balancete> builder)
        {
            builder.ToTable("Balancetes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeDaConta).IsRequired().HasColumnType("varchar(40)");
            builder.Property(x => x.NumeroDaConta).IsRequired().HasColumnType("varchar(12)");
            builder.Property(x => x.Saldo).IsRequired().HasColumnType("decimal");
        }
    }
}
