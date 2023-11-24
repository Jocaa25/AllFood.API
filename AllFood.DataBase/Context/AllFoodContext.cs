using AllFood.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace AllFood.DataBase.Context
{
    public class AllFoodContext : DbContext
    {
        public AllFoodContext(DbContextOptions<AllFoodContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging(); // Ativar o Data Logging Sensível
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .ToTable("user");
        }
    }
}
