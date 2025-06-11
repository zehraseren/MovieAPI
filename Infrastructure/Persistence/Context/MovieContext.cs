using Domain.Entities;
using Persistence.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistence.Context;

public class MovieContext : IdentityDbContext<AppUser>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Zehra;initial catalog=MovieApiDb;integrated security=true;TrustServerCertificate=True");
    }

    public DbSet<Cast> Casts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tag> Tags { get; set; }
}
