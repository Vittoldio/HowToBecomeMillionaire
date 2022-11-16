using HowToBecomeMillionaire.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HowToBecomeMillionaire.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<GameMode> GameModes { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<BestResult> BestResult { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BestResult>()
                        .HasOne(typeof(IdentityUser))
                        .WithMany()
                        .HasForeignKey("UserId");
            modelBuilder.Entity<BestResult>()
                        .HasOne(typeof(GameMode))
                        .WithMany()
                        .HasForeignKey("GameModeId");
        }

    }
}