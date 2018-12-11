using Microsoft.EntityFrameworkCore;
using PSClassicEdit.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSClassicEdit.DataAccess
{
    public class GameDbContext : DbContext
    {
        private string _executingDirectory;

        public DbSet<Disc> Discs { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Language> Languages { get; set; }

        public GameDbContext(string executingDirectory)
        {
            _executingDirectory = executingDirectory;
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Directory.CreateDirectory($"{_executingDirectory}\\System\\Databases");
            optionsBuilder.UseSqlite($"Data Source={_executingDirectory}\\System\\Databases\\regional.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("GAME");
            });


            modelBuilder.Entity<Disc>(entity =>
            {
                entity.ToTable("DISC");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("LANGUAGE_SPECIFIC");
            });
        }
    }
}
