﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlehOlehNTT.Infrastructure.Data;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240907103909_SeedingDataAppUser")]
    partial class SeedingDataAppUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.19");

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NoHP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("TabelAppUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5f3add67-90a5-43aa-bc8e-bce3a57c21da"),
                            Alamat = "DI BUMI",
                            Email = "aditaklal@gmail.com",
                            Nama = "Adi Juanito Taklal",
                            NoHP = "081234567890",
                            PasswordHash = "AQAAAAIAAYagAAAAEKboqqd0sjg1V6K6NpKhDD3jxni8DWxgmFMB4wDaEgCkte7DpPvfCUG/qWm8AqNMCw=="
                        });
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.DetailOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Jumlah")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OrderId1")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProdukId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderId1");

                    b.HasIndex("ProdukId");

                    b.ToTable("TabelDetailOrder");
                });

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
                            Id = new Guid("929054cc-8fad-4723-a3fa-cf3dcbc2e32d"),
                            AddedAt = new DateTime(2024, 9, 7, 18, 39, 9, 694, DateTimeKind.Local).AddTicks(7300),
                            Nama = "Makanan"
                        });
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Kurir", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("EstimasiWaktu")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("OngkosKirim")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("TabelKurir");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.MetodePembayaran", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TabelMetodePembayaran");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AppUserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("KurirId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MetodePembayaranId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("KurirId");

                    b.HasIndex("MetodePembayaranId");

                    b.ToTable("TabelOrder");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Produk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<double>("Berat")
                        .HasColumnType("REAL");

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
                            Id = new Guid("49259e88-c85b-4621-9ecb-de8d2748d6a2"),
                            AddedAt = new DateTime(2024, 9, 7, 18, 39, 9, 694, DateTimeKind.Local).AddTicks(7692),
                            Berat = 1000.0,
                            Dekripsi = "Paling enak makan dengan nasi",
                            Harga = 50000.0,
                            Nama = "Se'i Babi",
                            Stok = 100
                        });
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.DetailOrder", b =>
                {
                    b.HasOne("OlehOlehNTT.Domain.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlehOlehNTT.Domain.Entities.Order", null)
                        .WithMany("DaftarDetailOrder")
                        .HasForeignKey("OrderId1");

                    b.HasOne("OlehOlehNTT.Domain.Entities.Produk", "Produk")
                        .WithMany()
                        .HasForeignKey("ProdukId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Produk");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Order", b =>
                {
                    b.HasOne("OlehOlehNTT.Domain.Entities.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlehOlehNTT.Domain.Entities.Kurir", "Kurir")
                        .WithMany()
                        .HasForeignKey("KurirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlehOlehNTT.Domain.Entities.MetodePembayaran", "MetodePembayaran")
                        .WithMany()
                        .HasForeignKey("MetodePembayaranId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Kurir");

                    b.Navigation("MetodePembayaran");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Produk", b =>
                {
                    b.HasOne("OlehOlehNTT.Domain.Entities.KategoriProduk", "Kategori")
                        .WithMany("DaftarProduk")
                        .HasForeignKey("KategoriId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.KategoriProduk", b =>
                {
                    b.Navigation("DaftarProduk");
                });

            modelBuilder.Entity("OlehOlehNTT.Domain.Entities.Order", b =>
                {
                    b.Navigation("DaftarDetailOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
