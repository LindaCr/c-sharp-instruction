using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreDBFirst.Migrations
{
    public partial class fixedtotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orderlines",
                type: "decimal(9,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orderlines");
        }
    }
}
