using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcaPonto.DataBase.Migrations
{
    public partial class MarcaPontoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
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
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "6aaa5bc9-135d-4ebb-9cd5-366bd4480c66", "1234567890", "Customer1@email.com", "Customer 01", "customer01", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "811097d6-06b3-4e86-a7f5-019972384ac1", "2234567890", "Customer2@email.com", "Customer 02", "customer02", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "aa25f3c1-fbab-49ee-8138-8c8c4d99fa57", "3234567890", "Customer3@email.com", "Customer 03", "customer03", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "c798f23f-8b32-4382-8cf0-558f0cd9aa93", "4234567890", "Customer4@email.com", "Customer 04", "customer04", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "c4b77872-0989-4580-9aea-67247db10031", "5234567890", "Customer5@email.com", "Customer 05", "customer05", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
