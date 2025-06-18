using Microsoft.EntityFrameworkCore;
using tiklaa_blazor_game.Components.Pages;
using tiklaa_blazor_game.gamee;

namespace TiklaaGame.Data
{
    public class TiklaaDbContext : DbContext
    {
        public TiklaaDbContext(DbContextOptions<TiklaaDbContext> options) : base(options)
        {
        }

        public DbSet<Db_game> Db_Games { get; set; }
        public DbSet<Db_user> Db_Users { get; set; }
        //public DbSet<Db_leader> Db_leaders { get; set; } //gerek kalmadi ya da hic yoktu

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=TiklaaDb;integrated security=true;TrustServerCertificate=True;");
        }
    }
}
