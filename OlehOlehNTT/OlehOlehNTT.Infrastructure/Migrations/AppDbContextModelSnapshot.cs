﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlehOlehNTT.Infrastructure.Data;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.19");

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.KategoriProduk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TabelKategoriProduk");

                    b.HasData(
                        new
                        {
                            Id = new Guid("28a09c14-6db1-4ff0-9d07-b43dce39dcbf"),
                            AddedAt = new DateTime(2024, 9, 3, 17, 5, 29, 534, DateTimeKind.Local).AddTicks(531),
                            Nama = "Makanan"
                        });
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Produk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dekripsi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Harga")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("KategoriId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Stok")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ukuran")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlGambar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Warna")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("TabelProduk");

                    b.HasData(
                        new
                        {
                            Id = new Guid("129581ce-3f4d-4117-96b1-e7b2ef30a72a"),
                            AddedAt = new DateTime(2024, 9, 3, 17, 5, 29, 534, DateTimeKind.Local).AddTicks(1214),
                            Dekripsi = "Paling enak makan dengan nasi",
                            Harga = 50000.0,
                            Nama = "Se'i Babi",
                            Stok = 100
                        });
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Produk", b =>
                {
                    b.HasOne("OlehOlehNTT.Domain.Entities.KategoriProduk", "Kategori")
                        .WithMany("DaftarProduk")
                        .HasForeignKey("KategoriId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.KategoriProduk", b =>
                {
                    b.Navigation("DaftarProduk");
                });
#pragma warning restore 612, 618
        }
    }
}
