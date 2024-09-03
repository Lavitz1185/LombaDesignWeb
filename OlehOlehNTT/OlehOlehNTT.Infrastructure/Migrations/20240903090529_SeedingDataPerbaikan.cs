using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataPerbaikan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Harga",
                table: "TabelProduk",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "TabelKategoriProduk",
                columns: new[] { "Id", "AddedAt", "ModifiedAt", "Nama" },
                values: new object[] { new Guid("28a09c14-6db1-4ff0-9d07-b43dce39dcbf"), new DateTime(2024, 9, 3, 17, 5, 29, 534, DateTimeKind.Local).AddTicks(531), null, "Makanan" });

            migrationBuilder.InsertData(
                table: "TabelProduk",
                columns: new[] { "Id", "AddedAt", "Dekripsi", "Harga", "KategoriId", "ModifiedAt", "Nama", "Stok", "Ukuran", "UrlGambar", "Warna" },
                values: new object[] { new Guid("129581ce-3f4d-4117-96b1-e7b2ef30a72a"), new DateTime(2024, 9, 3, 17, 5, 29, 534, DateTimeKind.Local).AddTicks(1214), "Paling enak makan dengan nasi", 50000.0, null, null, "Se'i Babi", 100, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TabelKategoriProduk",
                keyColumn: "Id",
                keyValue: new Guid("28a09c14-6db1-4ff0-9d07-b43dce39dcbf"));

            migrationBuilder.DeleteData(
                table: "TabelProduk",
                keyColumn: "Id",
                keyValue: new Guid("129581ce-3f4d-4117-96b1-e7b2ef30a72a"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Harga",
                table: "TabelProduk",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
