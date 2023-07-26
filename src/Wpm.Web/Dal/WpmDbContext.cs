using Microsoft.EntityFrameworkCore;
using Wpm.Web.Domain;

namespace Wpm.Web.Dal;

public class WpmDbContext : DbContext
{
    public DbSet<Species> Species { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Owner> Owners { get; set; }

    public WpmDbContext(DbContextOptions<WpmDbContext> options) : base(options) { }
}