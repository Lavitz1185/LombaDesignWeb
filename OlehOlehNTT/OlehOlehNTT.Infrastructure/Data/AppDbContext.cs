using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Infrastructure.Data.SeedingData;

namespace OlehOlehNTT.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        modelBuilder.SeedingData();
    }

    public DbSet<Produk> TabelProduk { get; set; }
    public DbSet<KategoriProduk> TabelKategoriProduk { get; set; }
}
