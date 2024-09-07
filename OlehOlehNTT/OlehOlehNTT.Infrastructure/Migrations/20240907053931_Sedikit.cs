using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Sedikit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TabelKategoriProduk",
                keyColumn: "Id",
                keyValue: new Guid("28a09c14-6db1-4ff0-9d07-b43dce39dcbf"));

            migrationBuilder.DeleteData(
                table: "TabelProduk",
                keyColumn: "Id",
                keyValue: new Guid("129581ce-3f4d-4117-96b1-e7b2ef30a72a"));

            migrationBuilder.AddColumn<double>(
                name: "Berat",
                table: "TabelProduk",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "TabelAppUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    NoHP = table.Column<string>(type: "TEXT", nullable: false),
                    Alamat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelAppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelKurir",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    EstimasiWaktu = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    OngkosKirim = table.Column<double>(type: "REAL", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelKurir", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelMetodePembayaran",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelMetodePembayaran", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    MetodePembayaranId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AppUserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    KurirId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelOrder_TabelAppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "TabelAppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabelOrder_TabelKurir_KurirId",
                        column: x => x.KurirId,
                        principalTable: "TabelKurir",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabelOrder_TabelMetodePembayaran_MetodePembayaranId",
                        column: x => x.MetodePembayaranId,
                        principalTable: "TabelMetodePembayaran",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabelDetailOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Jumlah = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProdukId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderId1 = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelDetailOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelDetailOrder_TabelOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TabelOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabelDetailOrder_TabelOrder_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "TabelOrder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TabelDetailOrder_TabelProduk_ProdukId",
                        column: x => x.ProdukId,
                        principalTable: "TabelProduk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TabelKategoriProduk",
                columns: new[] { "Id", "AddedAt", "ModifiedAt", "Nama" },
                values: new object[] { new Guid("9b457df4-dc01-4f1d-95bf-aec52e806443"), new DateTime(2024, 9, 7, 13, 39, 31, 575, DateTimeKind.Local).AddTicks(178), null, "Makanan" });

            migrationBuilder.InsertData(
                table: "TabelProduk",
                columns: new[] { "Id", "AddedAt", "Berat", "Dekripsi", "Harga", "KategoriId", "ModifiedAt", "Nama", "Stok", "Ukuran", "UrlGambar", "Warna" },
                values: new object[] { new Guid("a7a69ec4-0e07-4d74-b89d-75e6767061b7"), new DateTime(2024, 9, 7, 13, 39, 31, 575, DateTimeKind.Local).AddTicks(796), 1000.0, "Paling enak makan dengan nasi", 50000.0, null, null, "Se'i Babi", 100, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_TabelAppUser_Email",
                table: "TabelAppUser",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabelDetailOrder_OrderId",
                table: "TabelDetailOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TabelDetailOrder_OrderId1",
                table: "TabelDetailOrder",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_TabelDetailOrder_ProdukId",
                table: "TabelDetailOrder",
                column: "ProdukId");

            migrationBuilder.CreateIndex(
                name: "IX_TabelOrder_AppUserId",
                table: "TabelOrder",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TabelOrder_KurirId",
                table: "TabelOrder",
                column: "KurirId");

            migrationBuilder.CreateIndex(
                name: "IX_TabelOrder_MetodePembayaranId",
                table: "TabelOrder",
                column: "MetodePembayaranId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelDetailOrder");

            migrationBuilder.DropTable(
                name: "TabelOrder");

            migrationBuilder.DropTable(
                name: "TabelAppUser");

            migrationBuilder.DropTable(
                name: "TabelKurir");

            migrationBuilder.DropTable(
                name: "TabelMetodePembayaran");

            migrationBuilder.DeleteData(
                table: "TabelKategoriProduk",
                keyColumn: "Id",
                keyValue: new Guid("9b457df4-dc01-4f1d-95bf-aec52e806443"));

            migrationBuilder.DeleteData(
                table: "TabelProduk",
                keyColumn: "Id",
                keyValue: new Guid("a7a69ec4-0e07-4d74-b89d-75e6767061b7"));

            migrationBuilder.DropColumn(
                name: "Berat",
                table: "TabelProduk");

            migrationBuilder.InsertData(
                table: "TabelKategoriProduk",
                columns: new[] { "Id", "AddedAt", "ModifiedAt", "Nama" },
                values: new object[] { new Guid("28a09c14-6db1-4ff0-9d07-b43dce39dcbf"), new DateTime(2024, 9, 3, 17, 5, 29, 534, DateTimeKind.Local).AddTicks(531), null, "Makanan" });

            migrationBuilder.InsertData(
                table: "TabelProduk",
                columns: new[] { "Id", "AddedAt", "Dekripsi", "Harga", "KategoriId", "ModifiedAt", "Nama", "Stok", "Ukuran", "UrlGambar", "Warna" },
                values: new object[] { new Guid("129581ce-3f4d-4117-96b1-e7b2ef30a72a"), new DateTime(2024, 9, 3, 17, 5, 29, 534, DateTimeKind.Local).AddTicks(1214), "Paling enak makan dengan nasi", 50000.0, null, null, "Se'i Babi", 100, null, null, null });
        }
    }
}
