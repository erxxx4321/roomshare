using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace roomshare.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepositMon",
                table: "Houses",
                newName: "DepMon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepMon",
                table: "Houses",
                newName: "DepositMon");
        }
    }
}
