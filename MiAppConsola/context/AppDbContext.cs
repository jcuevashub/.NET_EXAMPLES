using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=MiTiendaDB;User Id=sa;Password=Sa12345678;Encrypt=False;TrustServerCertificate=True;");
    }
}