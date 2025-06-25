using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandaDBContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cardapioitem> CardapioItems { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "server=localhost;database=senacfoods;user=root;password=";
            optionsBuilder.UseMySql(conexao,ServerVersion.AutoDetect(conexao) );

            base.OnConfiguring(optionsBuilder);
        }
    }
}
