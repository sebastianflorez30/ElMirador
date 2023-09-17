using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElMiradorOOP.Migrations
{
    /// <inheritdoc />
    public partial class IndexName_UserTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Document",
                table: "Users",
                column: "Document",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Document",
                table: "Users");
        }
    }
}
