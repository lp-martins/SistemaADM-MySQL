using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class LancamentoMap : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.ToTable("Lancamentos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data).IsRequired().HasColumnType("DATE");
            builder.Property(x => x.Debito).IsRequired().HasColumnType("varchar(12)");
            builder.Property(x => x.Credito).IsRequired().HasColumnType("varchar(12)");
            builder.Property(x => x.Valor).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.ReciboFiscal).IsRequired().HasColumnType("varchar(25)");
        }
    }

}
