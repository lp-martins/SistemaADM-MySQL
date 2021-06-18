using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class MigrationcomBalancete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balancetes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDaConta = table.Column<string>(type: "varchar(40)", nullable: false),
                    NumeroDaConta = table.Column<string>(type: "varchar(12)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balancetes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanoDeContas",
                columns: table => new
                {
                    NumeroDaConta = table.Column<string>(type: "varchar(12)", nullable: false),
                    NomeDaConta = table.Column<string>(type: "varchar(50)", nullable: false),
                    BalanceteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDeContas", x => x.NumeroDaConta);
                    table.ForeignKey(
                        name: "FK_PlanoDeContas_Balancetes_BalanceteId",
                        column: x => x.BalanceteId,
                        principalTable: "Balancetes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Lancamentos_PlanoDeContas_Credito",
                        column: x => x.Credito,
                        principalTable: "PlanoDeContas",
                        principalColumn: "NumeroDaConta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_Credito",
                table: "Lancamentos",
                column: "Credito");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDeContas_BalanceteId",
                table: "PlanoDeContas",
                column: "BalanceteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "PlanoDeContas");

            migrationBuilder.DropTable(
                name: "Balancetes");
        }
    }
}
