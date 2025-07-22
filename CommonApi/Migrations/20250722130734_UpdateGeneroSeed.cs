using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGeneroSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { new Guid("dbd1a6cb-2b6c-4840-b56b-83dc7ae61581"), "Otro" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: new Guid("dbd1a6cb-2b6c-4840-b56b-83dc7ae61581"));
        }
    }
}
