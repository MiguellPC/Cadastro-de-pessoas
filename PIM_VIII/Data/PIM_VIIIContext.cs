using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIM_VIII.Models;

namespace PIM_VIII.Data
{
    public class PIM_VIIIContext : DbContext
    {
        public PIM_VIIIContext (DbContextOptions<PIM_VIIIContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TipoTelefone> TipoTelefone { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Nome).HasMaxLength(100);
            });
            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Bairro).HasMaxLength(30);
                entity.Property(e => e.Cidade).HasMaxLength(30);
                entity.Property(e => e.Estado).HasMaxLength(30);
                entity.Property(e => e.Logradouro).HasMaxLength(30);
            });
            modelBuilder.Entity<Telefone>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
            modelBuilder.Entity<TipoTelefone>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Tipo).HasMaxLength(30);
            });
        }
    }
}
