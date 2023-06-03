using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panda.SOS.Infra.Migrations
{
    /// <inheritdoc />
    public partial class drop_column_description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Phones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Phones",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
