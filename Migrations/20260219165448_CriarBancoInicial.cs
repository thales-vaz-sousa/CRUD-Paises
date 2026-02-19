using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_paises.Migrations
{
    /// <inheritdoc />
    public partial class CriarBancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Populacao = table.Column<long>(type: "INTEGER", nullable: false),
                    Ddi = table.Column<int>(type: "INTEGER", nullable: false),
                    AreaTotal = table.Column<double>(type: "REAL", nullable: false),
                    Sigla = table.Column<string>(type: "TEXT", nullable: false),
                    Idioma = table.Column<string>(type: "TEXT", nullable: false),
                    Continente = table.Column<string>(type: "TEXT", nullable: false),
                    PaisOnu = table.Column<bool>(type: "INTEGER", nullable: false),
                    Fundacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
