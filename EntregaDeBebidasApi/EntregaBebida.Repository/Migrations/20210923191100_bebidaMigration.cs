using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntregaBebida.Repository.Migrations
{
    public partial class bebidaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bebidas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ValorCusto = table.Column<double>(type: "REAL", nullable: false),
                    ValorVenda = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebidas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebidas");
        }
    }
}
