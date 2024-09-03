using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelKategoriProduk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    AddetAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelKategoriProduk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelProduk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    Dekripsi = table.Column<string>(type: "TEXT", nullable: false),
                    Harga = table.Column<decimal>(type: "TEXT", nullable: false),
                    Stok = table.Column<int>(type: "INTEGER", nullable: false),
                    UrlGambar = table.Column<string>(type: "TEXT", nullable: true),
                    Ukuran = table.Column<string>(type: "TEXT", nullable: true),
                    Warna = table.Column<string>(type: "TEXT", nullable: true),
                    AddetAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    KategoriId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelProduk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelProduk_TabelKategoriProduk_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "TabelKategoriProduk",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelProduk_KategoriId",
                table: "TabelProduk",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelProduk");

            migrationBuilder.DropTable(
                name: "TabelKategoriProduk");
        }
    }
}
