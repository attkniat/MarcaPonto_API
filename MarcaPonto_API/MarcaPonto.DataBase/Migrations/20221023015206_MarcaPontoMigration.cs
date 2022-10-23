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
                values: new object[] { "48ef6c7b-a4a1-4045-ab27-ab1b287cbf59", "1234567890", "Customer1@email.com", "Customer 01", "customer01", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "89a7696a-a44d-4be9-811e-ddeae5fedfb6", "2234567890", "Customer2@email.com", "Customer 02", "customer02", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "c1aa9821-fb4f-4117-ad9c-7b8997901f15", "3234567890", "Customer3@email.com", "Customer 03", "customer03", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
