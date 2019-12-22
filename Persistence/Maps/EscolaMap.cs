using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Maps
{
    public class EscolaMap : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.ToTable("Escolas");
            builder.HasKey(m => m.EscolaId);
            builder.Property(m => m.EscolaId).HasColumnType("varchar(50)");
            builder.Property(m => m.NomeEscola).HasColumnType("varchar(80)");
            builder.Property(m => m.Endereco).HasColumnType("varchar(80)");
            builder.Property(m => m.Numero).HasColumnType("varchar(20)");
            builder.Property(m => m.Complemento).HasColumnType("varchar(20)");
            builder.Property(m => m.Bairro).HasColumnType("varchar(50)");
            builder.Property(m => m.Cidade).HasColumnType("varchar(50)");
           

        }
    }
}
