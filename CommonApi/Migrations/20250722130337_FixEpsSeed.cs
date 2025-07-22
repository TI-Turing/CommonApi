using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommonApi.Migrations
{
    /// <inheritdoc />
    public partial class FixEpsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.InsertData(
                table: "Eps",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("060a90ed-2344-41bf-af9a-cae7a89c9d6a"), "EPM – Empresas Públicas de Medellín" },
                    { new Guid("159fc4e1-ddc9-4485-b46c-328383027035"), "Fondo de Pasivo Social de Ferrocarriles Nacionales de Colombia" },
                    { new Guid("16fd9481-33d4-4bf0-8a38-f58c012927d6"), "Asociación Indígena del Cauca EPSI" },
                    { new Guid("1966fa0a-d883-4b3c-a5e2-863f11b42119"), "Mallamas EPSI" },
                    { new Guid("2b7bf4cf-6f16-44cf-9460-90c5c5962871"), "Salud Mía EPS" },
                    { new Guid("2ea120bb-c389-45ca-84c3-80f62e86cfc1"), "Comfenalco Valle" },
                    { new Guid("31a69236-bfa5-4fdc-b6f3-49b6c4269149"), "Compensar EPS" },
                    { new Guid("352cfa32-de41-4900-bdb2-2927c9417187"), "Capital Salud EPS‑S" },
                    { new Guid("409b003a-5259-43ba-8c62-b0531d0c5899"), "Servicio Occidental de Salud EPS – SOS" },
                    { new Guid("4b625dbc-636b-4b43-b7bc-1887de79e32a"), "Savia Salud EPS" },
                    { new Guid("4c8e70b6-ee3b-437d-89bc-21f55d155c27"), "Nueva EPS" },
                    { new Guid("5a1b2c3d-4e5f-6789-abcd-1234567890ef"), "Cajacopi Atlántico" },
                    { new Guid("60b09cce-a0c1-470f-9ef8-ea6fbd605372"), "Emssanar E.S.S." },
                    { new Guid("61bf11f2-b288-47d5-be92-a94546157e5a"), "EPS Sura" },
                    { new Guid("7699d9ef-d8ba-4e3d-a687-398a13791faa"), "Pijaos Salud EPSI" },
                    { new Guid("7b14bab2-b62b-4fd7-a94d-1e21ca7a2b0f"), "Aliansalud EPS" },
                    { new Guid("8952a46d-512b-44ec-9f96-60e217d10a78"), "Salud Total EPS S.A." },
                    { new Guid("8f4bd47e-07ac-4d18-b58c-93db8f9bb163"), "Coosalud EPS‑S" },
                    { new Guid("a4d7ed3d-c095-4e83-bc43-3e5059458bb2"), "EPS Familiar de Colombia" },
                    { new Guid("a9e095b6-64da-463a-8dfd-2ad10d2e85d9"), "EPS Sanitas" },
                    { new Guid("ab3bc976-fb43-451f-ba69-2a507ac2fdff"), "Mutual Ser EPS" },
                    { new Guid("ad4a1d53-9189-4919-a909-8ca5ef20856a"), "Comfachocó" },
                    { new Guid("b2f454d6-2348-4f1d-ae87-404c4c9d2f25"), "Anas Wayuu EPSI" },
                    { new Guid("c8ebc328-0d7d-4092-a879-5f4515b685cb"), "Capresoca" },
                    { new Guid("d25f45f8-f741-4bba-a1b1-915585114f7f"), "Comfaoriente" },
                    { new Guid("eee8cbfd-19ed-4175-956d-129ba75d3c6b"), "Dusakawi EPSI" },
                    { new Guid("f12784a3-54c6-4eea-9748-2b6b69b47c29"), "Famisanar" },
                    { new Guid("f79604cc-9e7a-4037-bd53-20ec4bd0a81e"), "Asmet Salud" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("060a90ed-2344-41bf-af9a-cae7a89c9d6a"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("159fc4e1-ddc9-4485-b46c-328383027035"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("16fd9481-33d4-4bf0-8a38-f58c012927d6"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("1966fa0a-d883-4b3c-a5e2-863f11b42119"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("2b7bf4cf-6f16-44cf-9460-90c5c5962871"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("2ea120bb-c389-45ca-84c3-80f62e86cfc1"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("31a69236-bfa5-4fdc-b6f3-49b6c4269149"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("352cfa32-de41-4900-bdb2-2927c9417187"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("409b003a-5259-43ba-8c62-b0531d0c5899"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("4b625dbc-636b-4b43-b7bc-1887de79e32a"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("4c8e70b6-ee3b-437d-89bc-21f55d155c27"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("5a1b2c3d-4e5f-6789-abcd-1234567890ef"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("60b09cce-a0c1-470f-9ef8-ea6fbd605372"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("61bf11f2-b288-47d5-be92-a94546157e5a"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("7699d9ef-d8ba-4e3d-a687-398a13791faa"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("7b14bab2-b62b-4fd7-a94d-1e21ca7a2b0f"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("8952a46d-512b-44ec-9f96-60e217d10a78"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("8f4bd47e-07ac-4d18-b58c-93db8f9bb163"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("a4d7ed3d-c095-4e83-bc43-3e5059458bb2"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("a9e095b6-64da-463a-8dfd-2ad10d2e85d9"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("ab3bc976-fb43-451f-ba69-2a507ac2fdff"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("ad4a1d53-9189-4919-a909-8ca5ef20856a"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("b2f454d6-2348-4f1d-ae87-404c4c9d2f25"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("c8ebc328-0d7d-4092-a879-5f4515b685cb"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("d25f45f8-f741-4bba-a1b1-915585114f7f"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("eee8cbfd-19ed-4175-956d-129ba75d3c6b"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("f12784a3-54c6-4eea-9748-2b6b69b47c29"));

            migrationBuilder.DeleteData(
                table: "Eps",
                keyColumn: "Id",
                keyValue: new Guid("f79604cc-9e7a-4037-bd53-20ec4bd0a81e"));

            migrationBuilder.InsertData(
                table: "Eps",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { new Guid("33333333-3333-3333-3333-333333333333"), "Nueva EPS" });
        }
    }
}
