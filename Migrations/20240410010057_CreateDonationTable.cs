using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoacoesICCPVU.Migrations
{
    /// <inheritdoc />
    public partial class CreateDonationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmitidoEm = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    NumeroOficio = table.Column<string>(type: "TEXT", nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", nullable: false),
                    Doador = table.Column<string>(type: "TEXT", nullable: false),
                    Donatario = table.Column<string>(type: "TEXT", nullable: false),
                    Itens = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacoes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doacoes");
        }
    }
}
