using Microsoft.EntityFrameworkCore.Migrations;

namespace Monitor_Cheltuieli.Migrations
{
    public partial class InnitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monitor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produs = table.Column<string>(nullable: true),
                    Descriere = table.Column<string>(nullable: true),
                    Cantitate = table.Column<int>(nullable: false),
                    Pret = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitor");
        }
    }
}
