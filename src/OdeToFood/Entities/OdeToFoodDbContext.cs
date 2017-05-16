using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood.DomainModels;

namespace OdeToFood.Entities
{
    public class OdeToFoodDbContext : IdentityDbContext<User>
    {
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
