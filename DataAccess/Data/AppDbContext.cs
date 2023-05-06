using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {}
    
}