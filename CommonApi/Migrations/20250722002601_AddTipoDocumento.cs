using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommonApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTipoDocumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposDocumento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumento", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TiposDocumento",
                columns: new[] { "Id", "Abreviatura", "Nombre" },
                values: new object[,]
                {
                    { new Guid("77777777-7777-7777-7777-777777777777"), "CC", "Cédula de Ciudadanía" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "TI", "Tarjeta de Identidad" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "CE", "Cédula de Extranjería" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposDocumento");
        }
    }
}
