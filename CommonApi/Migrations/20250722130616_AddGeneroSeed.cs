using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommonApi.Migrations
{
    /// <inheritdoc />
    public partial class AddGeneroSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("32f82e7c-7e39-4906-9c41-5d28b3fab3f1"), "Masculino" },
                    { new Guid("b3719f67-3e64-4f4a-a609-7b334521372b"), "Femenino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: new Guid("32f82e7c-7e39-4906-9c41-5d28b3fab3f1"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: new Guid("b3719f67-3e64-4f4a-a609-7b334521372b"));

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Masculino" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Femenino" }
                });
        }
    }
}
