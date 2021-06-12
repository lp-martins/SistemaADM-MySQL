using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class CriacaoDoBancoETabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanoDeContas",
                columns: table => new
                {
                    NumeroDaConta = table.Column<string>(type: "varchar(12)", nullable: false),
                    NomeDaConta = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDeContas", x => x.NumeroDaConta);
                });

            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "DATE", nullable: false),
                    Debito = table.Column<string>(type: "varchar(12)", nullable: false),
                    Credito = table.Column<string>(type: "varchar(12)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal", nullable: false),
                    ReciboFiscal = table.Column<string>(type: "varchar(25)", nullable: false),
                    PlanoDeContaID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamentos_PlanoDeContas_PlanoDeContaID",
                        column: x => x.PlanoDeContaID,
                        principalTable: "PlanoDeContas",
                        principalColumn: "NumeroDaConta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_PlanoDeContaID",
                table: "Lancamentos",
                column: "PlanoDeContaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "PlanoDeContas");
        }
    }
}
