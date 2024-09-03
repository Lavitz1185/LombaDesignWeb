using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlehOlehNTT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataPertama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddetAt",
                table: "TabelProduk",
                newName: "AddedAt");

            migrationBuilder.RenameColumn(
                name: "AddetAt",
                table: "TabelKategoriProduk",
                newName: "AddedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddedAt",
                table: "TabelProduk",
                newName: "AddetAt");

            migrationBuilder.RenameColumn(
                name: "AddedAt",
                table: "TabelKategoriProduk",
                newName: "AddetAt");
        }
    }
}
