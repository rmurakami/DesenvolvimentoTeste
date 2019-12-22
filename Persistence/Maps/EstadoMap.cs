using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estados");
            builder.HasKey(m => m.Uf);
            builder.Property(m => m.Uf).HasColumnType("char(2)");
            builder.Property(m => m.Nome).HasColumnType("varchar(50)");

        }
    }
}
