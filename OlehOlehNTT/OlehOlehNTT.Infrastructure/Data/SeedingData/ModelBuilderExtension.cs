using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Infrastructure.Data.SeedingData;

internal static class ModelBuilderExtension
{
    public static void SeedingData(this ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<AppUser>().HasData(
            new
            {
                Id = Guid.NewGuid(),
                Nama = "Adi Juanito Taklal",
                Email = Email.Create("aditaklal@gmail.com").Value,
                NoHP = NoHP.Create("081234567890").Value,
                Alamat = "DI BUMI",
                PasswordHash = new PasswordHasher<AppUser>().HashPassword(null, "adiairnona")
            }
        );

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
