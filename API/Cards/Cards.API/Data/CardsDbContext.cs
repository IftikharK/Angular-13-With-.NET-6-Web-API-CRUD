using Cards.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cards.API.Data
{
    public class CardsDbContext : DbContext
    {      

        public CardsDbContext(DbContextOptions options) : base(options)
        {
        }
        
        /*
         * Dbset is a prop used by EF Core and 
         * it acts a SqlServer Table
         * Cards => is a replica of the SqlServer Card Table
         */
        public DbSet<Card> Cards { get; set; }
    }
}
