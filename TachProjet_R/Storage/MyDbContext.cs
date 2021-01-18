using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TachProjet_R.Models;

namespace TachProjet_R.Storage
{
    public class MyDbContext : DbContext
    {


        public DbSet<Employer> EmployerTable;
        public DbSet<Tache> TacheTable;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=tache_db;user=root;password=''");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tache>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.HasKey(e => e.Id);
              
            });
        }
    }
}
