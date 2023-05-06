using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Data;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {}
    
    public DbSet<Restaurant> Restaurants {get; set;}
}