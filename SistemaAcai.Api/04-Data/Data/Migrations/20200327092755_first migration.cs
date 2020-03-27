using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PEDIDO",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATE_AT = table.Column<DateTime>(nullable: true),
                    UPDATE_AT = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDO_ADICIONAIS",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATE_AT = table.Column<DateTime>(nullable: true),
                    UPDATE_AT = table.Column<DateTime>(nullable: true),
                    ID_PEDIDO = table.Column<Guid>(nullable: false),
                    NOME = table.Column<string>(maxLength: 50, nullable: false),
                    PRECO = table.Column<decimal>(nullable: false),
                    TEMPO_PREPARO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO_ADICIONAIS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEDIDO_ADICIONAIS_PEDIDO_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDO_SABOR",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATE_AT = table.Column<DateTime>(nullable: true),
                    UPDATE_AT = table.Column<DateTime>(nullable: true),
                    ID_PEDIDO = table.Column<Guid>(nullable: false),
                    NOME = table.Column<string>(maxLength: 50, nullable: false),
                    PRECO = table.Column<decimal>(nullable: false),
                    TEMPO_PREPARO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO_SABOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEDIDO_SABOR_PEDIDO_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDO_TAMANHO",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATE_AT = table.Column<DateTime>(nullable: true),
                    UPDATE_AT = table.Column<DateTime>(nullable: true),
                    ID_PEDIDO = table.Column<Guid>(nullable: false),
                    NOME = table.Column<string>(maxLength: 50, nullable: false),
                    PRECO = table.Column<decimal>(nullable: false),
                    TEMPO_PREPARO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO_TAMANHO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEDIDO_TAMANHO_PEDIDO_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_ADICIONAIS_ID_PEDIDO",
                table: "PEDIDO_ADICIONAIS",
                column: "ID_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_SABOR_ID_PEDIDO",
                table: "PEDIDO_SABOR",
                column: "ID_PEDIDO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_TAMANHO_ID_PEDIDO",
                table: "PEDIDO_TAMANHO",
                column: "ID_PEDIDO",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PEDIDO_ADICIONAIS");

            migrationBuilder.DropTable(
                name: "PEDIDO_SABOR");

            migrationBuilder.DropTable(
                name: "PEDIDO_TAMANHO");

            migrationBuilder.DropTable(
                name: "PEDIDO");
        }
    }
}
