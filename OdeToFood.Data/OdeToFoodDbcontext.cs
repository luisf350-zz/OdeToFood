using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class OdeToFoodDbcontext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}