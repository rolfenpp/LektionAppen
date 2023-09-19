using LektionAppen.Domain;
using Microsoft.EntityFrameworkCore;

namespace LektionAppen.Data;
// .Data = mappen

// Möjligör communikation med databasen
// internal gör att endast åtkomlig i detta projektet
class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=LektionAppen;Trusted_Connection=True;Encrypt=False");
    }

    public DbSet<Product> Product { get; set; }
}
