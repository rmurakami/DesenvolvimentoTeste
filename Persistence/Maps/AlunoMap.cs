using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Maps
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey(m => m.AlunoId);
            builder.Property(m => m.AlunoId).HasColumnType("varchar(50)");
            builder.Property(m => m.Cpf).HasColumnType("varchar(11)");
            builder.Property(m => m.Nome).HasColumnType("varchar(80)");
            builder.Property(m => m.Sexo).HasColumnType("char(1)");
            builder.Property(m => m.Nacionalidade).HasColumnType("varchar(50)");
            builder.Property(m => m.DtNascimento).HasColumnType("Timestamp");
            builder.Property(m => m.Email).HasColumnType("varchar(80)");
            builder.Property(m => m.Endereco).HasColumnType("varchar(80)");
            builder.Property(m => m.Numero).HasColumnType("varchar(20)");
            builder.Property(m => m.Complemento).HasColumnType("varchar(20)");
            builder.Property(m => m.Bairro).HasColumnType("varchar(50)");
            builder.Property(m => m.Cidade).HasColumnType("varchar(50)");
            builder.Property(m => m.Cep).HasColumnType("varchar(9)");
            builder.Property(m => m.NomeMae).HasColumnType("varchar(80)");
            builder.Property(m => m.NomePai).HasColumnType("varchar(80)");

        }
    }
}
