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

            migrationBuilder.CreateTable(
                name: "Ponto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    DataCadastro = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "aa3ed8e7-2abf-489e-9505-710e914ce158", "1234567890", "Customer1@email.com", "Customer 01", "customer01", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "8d0f8934-c985-4837-9bf6-4b9d54bc021f", "2234567890", "Customer2@email.com", "Customer 02", "customer02", "Customer" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password", "Role" },
                values: new object[] { "f1428e85-4162-4732-9711-b2b6792ce9a2", "3234567890", "Customer3@email.com", "Customer 03", "customer03", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Ponto");
        }
    }
}
