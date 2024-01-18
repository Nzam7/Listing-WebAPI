using Microsoft.EntityFrameworkCore;
using Listing.Models;

namespace Listing.Models
{
    public class ApplicationDbContext: DbContext
    {
        // Constructor that takes DbContextOptions and passes it to the base constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet property for Users - represents the Users table in the database
        public DbSet<User> Users { get; set; }

    }
}
