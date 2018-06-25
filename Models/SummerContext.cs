using Microsoft.EntityFrameworkCore;
 
namespace SummerGames.Models
{
    public class SummerContext : DbContext
    {
        public SummerContext(DbContextOptions<SummerContext> options) : base(options) { }
    }
}
