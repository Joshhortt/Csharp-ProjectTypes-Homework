using Microsoft.EntityFrameworkCore.Migrations;

namespace BookRazorList.Migrations
{
    public partial class AddISBNToTheBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "TheBook",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "TheBook");
        }
    }
}
