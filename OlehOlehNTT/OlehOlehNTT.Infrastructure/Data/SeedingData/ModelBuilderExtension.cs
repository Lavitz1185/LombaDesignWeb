using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.SeedingData;

internal static class ModelBuilderExtension
{
    public static void SeedingData(this ModelBuilder modelBuilder)
    {
        var daftarKategori = new KategoriProduk[]
        {
            new()
            {
                Id = Guid.NewGuid(),
                Nama = "Makanan",
                AddedAt = DateTime.Now,
            }
        };

        modelBuilder.Entity<KategoriProduk>().HasData(daftarKategori);

        modelBuilder.Entity<Produk>().HasData(
            new
            {
                Id = Guid.NewGuid(),
                Nama = "Se'i Babi",
                Dekripsi = "Paling enak makan dengan nasi",
                Harga = 50e3,
                Stok = 100,
                Berat = 1000d,
                KategorId = daftarKategori[0].Id,
                AddedAt = DateTime.Now,
            });
    }
}
