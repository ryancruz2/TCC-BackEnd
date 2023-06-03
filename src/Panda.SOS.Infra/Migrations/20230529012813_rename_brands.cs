using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panda.SOS.Infra.Migrations
{
    /// <inheritdoc />
    public partial class rename_brands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "brands",
                table: "Phones",
                newName: "maker");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "maker",
                table: "Phones",
                newName: "brands");
        }
    }
}
