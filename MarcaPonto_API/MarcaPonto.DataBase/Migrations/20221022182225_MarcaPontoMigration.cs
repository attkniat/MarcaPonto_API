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
                values: new object[] { "1844ffd1-e384-4622-8213-95eae3b152f9", "1234567890", "Customer1@email.com", "Customer 01", "customer01", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "7b9d4c8b-8a18-4116-a7f5-b6a451d7a07e", "2234567890", "Customer2@email.com", "Customer 02", "customer02", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "bc50b967-8d2d-4d32-a8a3-dc2507aef3ea", "3234567890", "Customer3@email.com", "Customer 03", "customer03", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "44e50611-e715-4770-83bc-314ec5527716", "4234567890", "Customer4@email.com", "Customer 04", "customer04", "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "7e48a3e6-27be-4f53-a92d-e3170a716541", "5234567890", "Customer5@email.com", "Customer 05", "customer05", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
