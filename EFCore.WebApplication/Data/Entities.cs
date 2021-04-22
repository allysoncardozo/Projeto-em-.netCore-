using EFCore.WebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebApplication
{
    public class Entities : DbContext
    {
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Password=sql@Master;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApplication;Data Source=DESKTOP-3FTN6K6\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(p => {
                p.HasKey(i => new { i.batalhaId, i.Heroid });
            });
        }
    }
}
