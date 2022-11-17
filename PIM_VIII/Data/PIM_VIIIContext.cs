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
    }
}
