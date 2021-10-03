using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntregaBebida.Repository.Migrations
{
    public partial class mgMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosBebidas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdBebida = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdPedido = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosBebidas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosBebidas_Bebidas_IdBebida",
                        column: x => x.IdBebida,
                        principalTable: "Bebidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosBebidas_Pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosBebidas_IdBebida",
                table: "PedidosBebidas",
                column: "IdBebida");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosBebidas_IdPedido",
                table: "PedidosBebidas",
                column: "IdPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidosBebidas");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
