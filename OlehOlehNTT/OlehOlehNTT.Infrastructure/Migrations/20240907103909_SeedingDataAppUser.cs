using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TabelKategoriProduk",
                keyColumn: "Id",
                keyValue: new Guid("9b457df4-dc01-4f1d-95bf-aec52e806443"));

            migrationBuilder.DeleteData(
                table: "TabelProduk",
                keyColumn: "Id",
                keyValue: new Guid("a7a69ec4-0e07-4d74-b89d-75e6767061b7"));

            migrationBuilder.InsertData(
                table: "TabelAppUser",
                columns: new[] { "Id", "Alamat", "Email", "Nama", "NoHP", "PasswordHash" },
                values: new object[] { new Guid("5f3add67-90a5-43aa-bc8e-bce3a57c21da"), "DI BUMI", "aditaklal@gmail.com", "Adi Juanito Taklal", "081234567890", "AQAAAAIAAYagAAAAEKboqqd0sjg1V6K6NpKhDD3jxni8DWxgmFMB4wDaEgCkte7DpPvfCUG/qWm8AqNMCw==" });

            migrationBuilder.InsertData(
                table: "TabelKategoriProduk",
                columns: new[] { "Id", "AddedAt", "ModifiedAt", "Nama" },
                values: new object[] { new Guid("929054cc-8fad-4723-a3fa-cf3dcbc2e32d"), new DateTime(2024, 9, 7, 18, 39, 9, 694, DateTimeKind.Local).AddTicks(7300), null, "Makanan" });

            migrationBuilder.InsertData(
                table: "TabelProduk",
                columns: new[] { "Id", "AddedAt", "Berat", "Dekripsi", "Harga", "KategoriId", "ModifiedAt", "Nama", "Stok", "Ukuran", "UrlGambar", "Warna" },
                values: new object[] { new Guid("49259e88-c85b-4621-9ecb-de8d2748d6a2"), new DateTime(2024, 9, 7, 18, 39, 9, 694, DateTimeKind.Local).AddTicks(7692), 1000.0, "Paling enak makan dengan nasi", 50000.0, null, null, "Se'i Babi", 100, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TabelAppUser",
                keyColumn: "Id",
                keyValue: new Guid("5f3add67-90a5-43aa-bc8e-bce3a57c21da"));

            migrationBuilder.DeleteData(
                table: "TabelKategoriProduk",
                keyColumn: "Id",
                keyValue: new Guid("929054cc-8fad-4723-a3fa-cf3dcbc2e32d"));

            migrationBuilder.DeleteData(
                table: "TabelProduk",
                keyColumn: "Id",
                keyValue: new Guid("49259e88-c85b-4621-9ecb-de8d2748d6a2"));

            migrationBuilder.InsertData(
                table: "TabelKategoriProduk",
                columns: new[] { "Id", "AddedAt", "ModifiedAt", "Nama" },
                values: new object[] { new Guid("9b457df4-dc01-4f1d-95bf-aec52e806443"), new DateTime(2024, 9, 7, 13, 39, 31, 575, DateTimeKind.Local).AddTicks(178), null, "Makanan" });

            migrationBuilder.InsertData(
                table: "TabelProduk",
                columns: new[] { "Id", "AddedAt", "Berat", "Dekripsi", "Harga", "KategoriId", "ModifiedAt", "Nama", "Stok", "Ukuran", "UrlGambar", "Warna" },
                values: new object[] { new Guid("a7a69ec4-0e07-4d74-b89d-75e6767061b7"), new DateTime(2024, 9, 7, 13, 39, 31, 575, DateTimeKind.Local).AddTicks(796), 1000.0, "Paling enak makan dengan nasi", 50000.0, null, null, "Se'i Babi", 100, null, null, null });
        }
    }
}
