using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CursoMVC.Models;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Categoria> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Filipe\Documents\Cursomvc.mdf;Integrated Security = True");
        }

        public DbSet<CursoMVC.Models.Produto> Produto { get; set; }
    }
}
