using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcaPonto.DataBase.Migrations
{
    public partial class MarcaPontoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "88b49a5f-048b-4af7-9ae4-578aceccc19d", "1234567890", "Customer1@email.com", "Customer 01", "customer01", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "81821e02-f617-4bce-a8ff-5e85997c1cf1", "2234567890", "Customer2@email.com", "Customer 02", "customer02", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "58f534bf-f7a7-431f-afea-a045a76bae75", "3234567890", "Customer3@email.com", "Customer 03", "customer03", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "c5785ed0-cf69-4c68-a6f5-ea97e86ca6a7", "4234567890", "Customer4@email.com", "Customer 04", "customer04", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "87c83265-4d01-43de-8d42-d536145b8dbe", "5234567890", "Customer5@email.com", "Customer 05", "customer05", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
