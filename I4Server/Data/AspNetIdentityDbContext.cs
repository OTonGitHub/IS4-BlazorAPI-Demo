using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace I4Server.Data;

public class AspNetIdentityDbContext : IdentityDbContext {
    public AspNetIdentityDbContext(DbContextOptions<AspNetIdentityDbContext> options)
        : base (options) 
    {}
}   