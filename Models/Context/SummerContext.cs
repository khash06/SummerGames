using Microsoft.EntityFrameworkCore;


namespace SummerGames.Models
{
    public class SummerContext : DbContext
    {


        public DbSet<Player> player {get; set;}
        public DbSet<Multiplayer> multiplayer {get; set;}
        public DbSet<Encounters> encounters {get;set;}
        public DbSet<Enemies> enemies {get;set;}
        public DbSet<Story> storyline { get; set; }
        

        // base() calls the parent class' constructor passing the "options" parameter along
        public SummerContext(DbContextOptions<SummerContext> options) : base(options) { }
    }
}