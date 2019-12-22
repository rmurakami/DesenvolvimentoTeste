
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.Maps;

namespace Persistence
{
    public class Contexto : DbContext
    {
        private string _cn { get; set; }

        public Contexto(IConfiguration _config)
        {
            _cn = _config["CnMySql"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(_cn);

            }
        }


        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoTelefone> AlunoTelefones { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new AlunoTelefoneMap());
            modelBuilder.ApplyConfiguration(new EscolaMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
        }
    }
}
