using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 1, "Darth Vader" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 2, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 3, "Obi-Wan Kenobi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
