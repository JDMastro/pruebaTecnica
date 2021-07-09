using Microsoft.EntityFrameworkCore;
using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Areas> Areas { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Trabajadores> Trabajadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurando las llaves unicas
            modelBuilder.Entity<Empresas>().HasIndex(e => e.Descripcion).IsUnique().HasDatabaseName("Idx_descripcion_empresa");
            modelBuilder.Entity<Areas>().HasIndex(a => a.Descripcion).IsUnique().HasDatabaseName("Idx_descripcion_areas");
            modelBuilder.Entity<Trabajadores>().HasIndex(t => t.Telefono).IsUnique().HasDatabaseName("Idx_telefono_trabajadores");
        }
    }
}
