using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class AlunoTelefoneMap : IEntityTypeConfiguration<AlunoTelefone>
    {
        public void Configure(EntityTypeBuilder<AlunoTelefone> builder)
        {
            builder.ToTable("AlunoTelefones");
            builder.HasKey(m => m.TelefoneId);
            builder.Property(m => m.TelefoneId).HasColumnType("varchar(50)");
            builder.Property(m => m.Tipo).HasColumnType("int");
            builder.Property(m => m.Telefone).HasColumnType("varchar(50)");
        }
    }
}
