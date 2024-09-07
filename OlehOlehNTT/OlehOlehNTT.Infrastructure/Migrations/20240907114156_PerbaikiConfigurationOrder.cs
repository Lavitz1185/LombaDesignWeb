using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PerbaikiConfigurationOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabelDetailOrder_TabelOrder_OrderId1",
                table: "TabelDetailOrder");

            migrationBuilder.DropIndex(
                name: "IX_TabelDetailOrder_OrderId1",
                table: "TabelDetailOrder");

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

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "TabelDetailOrder");

            migrationBuilder.InsertData(
                table: "TabelAppUser",
                columns: new[] { "Id", "Alamat", "Email", "Nama", "NoHP", "PasswordHash" },
                values: new object[] { new Guid("2059868c-4560-4a0c-b1e0-0f820daf65c1"), "DI BUMI", "aditaklal@gmail.com", "Adi Juanito Taklal", "081234567890", "AQAAAAIAAYagAAAAEANLwcgnPskEgQTrGIriPeeXIzl4GKgaYKwg0Qbc33XLRVwhINIf6AgV/TdGiy8svw==" });

            migrationBuilder.InsertData(
                table: "TabelKategoriProduk",
                columns: new[] { "Id", "AddedAt", "ModifiedAt", "Nama" },
                values: new object[] { new Guid("7b3fca97-0411-4c97-89c4-286b296b5ea3"), new DateTime(2024, 9, 7, 19, 41, 56, 426, DateTimeKind.Local).AddTicks(670), null, "Makanan" });

            migrationBuilder.InsertData(
                table: "TabelProduk",
                columns: new[] { "Id", "AddedAt", "Berat", "Dekripsi", "Harga", "KategoriId", "ModifiedAt", "Nama", "Stok", "Ukuran", "UrlGambar", "Warna" },
                values: new object[] { new Guid("57af9c5d-51ee-4c71-bdd8-0f36d55132b7"), new DateTime(2024, 9, 7, 19, 41, 56, 426, DateTimeKind.Local).AddTicks(1092), 1000.0, "Paling enak makan dengan nasi", 50000.0, null, null, "Se'i Babi", 100, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TabelAppUser",
                keyColumn: "Id",
                keyValue: new Guid("2059868c-4560-4a0c-b1e0-0f820daf65c1"));

            migrationBuilder.DeleteData(
                table: "TabelKategoriProduk",
                keyColumn: "Id",
                keyValue: new Guid("7b3fca97-0411-4c97-89c4-286b296b5ea3"));

            migrationBuilder.DeleteData(
                table: "TabelProduk",
                keyColumn: "Id",
                keyValue: new Guid("57af9c5d-51ee-4c71-bdd8-0f36d55132b7"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId1",
                table: "TabelDetailOrder",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TabelDetailOrder_OrderId1",
                table: "TabelDetailOrder",
                column: "OrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TabelDetailOrder_TabelOrder_OrderId1",
                table: "TabelDetailOrder",
                column: "OrderId1",
                principalTable: "TabelOrder",
                principalColumn: "Id");
        }
    }
}
