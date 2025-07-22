using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommonApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCiudadSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre", "RegionId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Leticia", new Guid("a1c3f2d4-88f9-4ad9-9155-1e889b9c2b01") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Medellín", new Guid("b2e7a12c-6ac9-4f9e-963e-9b6d3825f962") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Bello", new Guid("b2e7a12c-6ac9-4f9e-963e-9b6d3825f962") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Itagüí", new Guid("b2e7a12c-6ac9-4f9e-963e-9b6d3825f962") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Envigado", new Guid("b2e7a12c-6ac9-4f9e-963e-9b6d3825f962") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Arauca", new Guid("c6bfb1d0-cbde-4a7f-8ad1-62f7645d38a3") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Barranquilla", new Guid("a0c8c530-05ce-4b31-a167-378bb8c44754") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Soledad", new Guid("a0c8c530-05ce-4b31-a167-378bb8c44754") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Malambo", new Guid("a0c8c530-05ce-4b31-a167-378bb8c44754") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Cartagena", new Guid("dc6cc70b-dfd1-4ec9-b34d-3d0df51c3c83") },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Magangué", new Guid("dc6cc70b-dfd1-4ec9-b34d-3d0df51c3c83") },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Bogotá", new Guid("fc6cc79b-dfd1-42c9-b35d-3d0df51c1c83") },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Tunja", new Guid("76a47836-06a2-4e9a-bd1f-68d0e59d6f67") },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Duitama", new Guid("76a47836-06a2-4e9a-bd1f-68d0e59d6f67") },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Sogamoso", new Guid("76a47836-06a2-4e9a-bd1f-68d0e59d6f67") },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Manizales", new Guid("fd1149ea-6a2d-44b7-9ec4-0cd342a2ed17") },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Florencia", new Guid("ae6e8c56-4d8a-4d97-8840-8036a30828d2") },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Yopal", new Guid("b32b60a3-fd1d-4a56-9ce6-91cf994ef080") },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Popayán", new Guid("fe4db8a1-3cf2-43e3-981c-bbcde0b3e6db") },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Valledupar", new Guid("d9b9ea69-355b-4c95-a0a5-9bcb1f7e5b70") },
                    { new Guid("10000000-0000-0000-0000-000000000021"), "Quibdó", new Guid("4ae71910-0a47-4421-a12d-02b82b6bbcb7") },
                    { new Guid("10000000-0000-0000-0000-000000000022"), "Montería", new Guid("cd65a502-2c6f-4298-8e5e-7bb0fc12f350") },
                    { new Guid("10000000-0000-0000-0000-000000000023"), "Soacha", new Guid("f4ac9a6e-0bd5-48b0-bbee-0343d7424694") },
                    { new Guid("10000000-0000-0000-0000-000000000024"), "Fusagasugá", new Guid("f4ac9a6e-0bd5-48b0-bbee-0343d7424694") },
                    { new Guid("10000000-0000-0000-0000-000000000025"), "Chía", new Guid("f4ac9a6e-0bd5-48b0-bbee-0343d7424694") },
                    { new Guid("10000000-0000-0000-0000-000000000026"), "Zipaquirá", new Guid("f4ac9a6e-0bd5-48b0-bbee-0343d7424694") },
                    { new Guid("10000000-0000-0000-0000-000000000027"), "Inírida", new Guid("4cfa9a62-69fd-4ae2-9c52-22819be6edb4") },
                    { new Guid("10000000-0000-0000-0000-000000000028"), "San José del Guaviare", new Guid("0d124589-3f7b-46bc-b31c-d7e51aef4c4b") },
                    { new Guid("10000000-0000-0000-0000-000000000029"), "Neiva", new Guid("93ac9a53-e0fc-4ff0-a15e-4455e2797cb3") },
                    { new Guid("10000000-0000-0000-0000-000000000030"), "Riohacha", new Guid("5e49d1a1-5f4b-4ea6-8476-994d32d042ef") },
                    { new Guid("10000000-0000-0000-0000-000000000031"), "Santa Marta", new Guid("e3c9a2fb-c9ad-4176-b8dc-214008ea9821") },
                    { new Guid("10000000-0000-0000-0000-000000000032"), "Villavicencio", new Guid("65ce7390-b287-43b7-bf0a-408d6fdc1e43") },
                    { new Guid("10000000-0000-0000-0000-000000000033"), "Pasto", new Guid("9d54652e-9964-48d5-a4e5-933c21f064cc") },
                    { new Guid("10000000-0000-0000-0000-000000000034"), "Tumaco", new Guid("9d54652e-9964-48d5-a4e5-933c21f064cc") },
                    { new Guid("10000000-0000-0000-0000-000000000035"), "Cúcuta", new Guid("b13cdb17-7e7f-49c2-b25e-bf8c4d529ad4") },
                    { new Guid("10000000-0000-0000-0000-000000000036"), "Mocoa", new Guid("2e6e2044-d35e-4d6c-8d7b-00f6b1bb760a") },
                    { new Guid("10000000-0000-0000-0000-000000000037"), "Armenia", new Guid("6a8b6502-8f7f-4d41-b48a-b858bfb4b8e4") },
                    { new Guid("10000000-0000-0000-0000-000000000038"), "Pereira", new Guid("94f4cfcd-98c6-4f76-b151-139aa420f6d5") },
                    { new Guid("10000000-0000-0000-0000-000000000039"), "Dosquebradas", new Guid("94f4cfcd-98c6-4f76-b151-139aa420f6d5") },
                    { new Guid("10000000-0000-0000-0000-000000000040"), "San Andrés", new Guid("2f5b57dc-3026-48a5-bd47-8fa5d5a5c6f1") },
                    { new Guid("10000000-0000-0000-0000-000000000041"), "Bucaramanga", new Guid("f00f77a9-4042-49b3-8759-01c4bcba8e03") },
                    { new Guid("10000000-0000-0000-0000-000000000042"), "Floridablanca", new Guid("f00f77a9-4042-49b3-8759-01c4bcba8e03") },
                    { new Guid("10000000-0000-0000-0000-000000000043"), "Girón", new Guid("f00f77a9-4042-49b3-8759-01c4bcba8e03") },
                    { new Guid("10000000-0000-0000-0000-000000000044"), "Sincelejo", new Guid("4ff29fa6-6c34-4a9f-92a4-073b6a8dfb8f") },
                    { new Guid("10000000-0000-0000-0000-000000000045"), "Ibagué", new Guid("872b38a4-d4a5-4bd1-b650-24b137ff7b26") },
                    { new Guid("10000000-0000-0000-0000-000000000046"), "Cali", new Guid("01172b87-e3f6-4f60-8f0b-313aab662c6a") },
                    { new Guid("10000000-0000-0000-0000-000000000047"), "Palmira", new Guid("01172b87-e3f6-4f60-8f0b-313aab662c6a") },
                    { new Guid("10000000-0000-0000-0000-000000000048"), "Buenaventura", new Guid("01172b87-e3f6-4f60-8f0b-313aab662c6a") },
                    { new Guid("10000000-0000-0000-0000-000000000049"), "Tuluá", new Guid("01172b87-e3f6-4f60-8f0b-313aab662c6a") },
                    { new Guid("10000000-0000-0000-0000-000000000050"), "Mitú", new Guid("df905248-bd83-474b-9b58-33e9f478b6cb") },
                    { new Guid("10000000-0000-0000-0000-000000000051"), "Puerto Carreño", new Guid("ae32c0db-ecfc-4975-a063-f2e13767451b") }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Codigo", "Nombre", "PrefijoTelefonico" },
                values: new object[,]
                {
                    { new Guid("0175eafe-e0fc-477d-95b6-7b55770d73a2"), "JE", "Jersey", "" },
                    { new Guid("01b4e9d1-a84e-41c9-8768-253209225a21"), "CO", "Colombia", "+57" },
                    { new Guid("02ba7af3-2a07-43da-ba9f-f4eb03ba021c"), "AL", "Albania", "+355" },
                    { new Guid("044bc2d0-46db-42a4-897e-3247af887f61"), "NF", "Norfolk Island", "" },
                    { new Guid("04a02196-4f59-4bac-aeaf-4970ca528ca7"), "MW", "Malawi", "+265" },
                    { new Guid("05144185-e27f-485e-9e8b-e79fa6e92a20"), "IM", "Isle of Man", "" },
                    { new Guid("05743052-b2a2-4991-bfa6-ccd15a44d844"), "KG", "Kyrgyzstan", "+996" },
                    { new Guid("061af03b-946a-42d2-b4a6-573fbf59fa2d"), "TW", "Taiwan, Province of China", "+886" },
                    { new Guid("061e119c-fee4-4d88-af65-17a7d6f180f8"), "VI", "Virgin Islands, U.S.", "" },
                    { new Guid("072cc336-9afd-43c3-a2b3-865ea688ff7d"), "BL", "Saint Barthélemy", "" },
                    { new Guid("07dea8ac-af76-4166-8aa6-afba8457334d"), "LR", "Liberia", "+231" },
                    { new Guid("080c717f-84a8-40e3-98d1-f974c35497cc"), "SH", "Saint Helena, Ascension and Tristan da Cunha", "" },
                    { new Guid("08f13aa3-b89d-4201-ac95-a9a208e2a628"), "CF", "Central African Republic", "+236" },
                    { new Guid("0934278d-a7c4-40f5-8a0f-08663d1e4c8b"), "KR", "Korea, Republic of", "+82" },
                    { new Guid("0bafb85a-2e90-4416-8e30-0513a7af9465"), "MT", "Malta", "+356" },
                    { new Guid("0d4f504a-38e8-4853-8a9f-2e49e100546d"), "MA", "Morocco", "+212" },
                    { new Guid("0da556cf-6e6e-40c5-89c8-73f3b02137fd"), "IS", "Iceland", "+354" },
                    { new Guid("0f697547-58e8-4f6c-808b-a5d50032bf37"), "BA", "Bosnia and Herzegovina", "+387" },
                    { new Guid("10f6dbcd-5afa-41a4-8d15-d5a71bea243f"), "VA", "Holy See (Vatican City State)", "+379" },
                    { new Guid("1241d22e-3c1c-4ac5-9c7e-c45d5dba0022"), "TM", "Turkmenistan", "+993" },
                    { new Guid("12a097c5-1661-436f-aa7b-23f64ae690d9"), "ZA", "South Africa", "+27" },
                    { new Guid("138a7f0f-d49e-4c2e-9aa8-85ab4bebd2cc"), "GI", "Gibraltar", "" },
                    { new Guid("1391ba6f-8245-4d57-b9a4-1ea694efa78b"), "MP", "Northern Mariana Islands", "" },
                    { new Guid("1498fc70-28c9-4ab2-bf68-7833c00a8007"), "KE", "Kenya", "+254" },
                    { new Guid("154ef284-76ca-4851-bd9b-dd372b02c521"), "IN", "India", "+91" },
                    { new Guid("15ae4960-14ec-4600-a148-5ec447af0bbe"), "GE", "Georgia", "+995" },
                    { new Guid("15ce09f2-f9c8-4bfd-996c-dee92d005bf9"), "GD", "Grenada", "+1" },
                    { new Guid("16e69a5f-bdd5-456a-a70e-e063acfd73fe"), "HU", "Hungary", "+36" },
                    { new Guid("184df0f2-066e-4210-8c0e-6a6a6f5cad49"), "MX", "Mexico", "+52" },
                    { new Guid("18fe29e3-d5c6-4bb5-8592-9f20fc65657f"), "AD", "Andorra", "+376" },
                    { new Guid("1a2b0024-097c-4d50-a7fa-19d2708f4689"), "GM", "Gambia", "+220" },
                    { new Guid("1b79e74d-b3ce-44c0-b59c-8ec59e15eb39"), "KY", "Cayman Islands", "+1" },
                    { new Guid("1ba3e674-700f-4ff6-8a62-30deca7eb46d"), "ET", "Ethiopia", "+251" },
                    { new Guid("1db0faf4-b95c-4b87-a9d0-082bc0e17397"), "IR", "Iran, Islamic Republic of", "+98" },
                    { new Guid("220b36fb-b33f-423e-b056-6e8beadd59bb"), "UM", "United States Minor Outlying Islands", "" },
                    { new Guid("22227c40-e32e-429e-801f-98bf751ec249"), "RU", "Russian Federation", "+7" },
                    { new Guid("22c33c28-db68-4d5b-a601-6bcb3e3ae39a"), "SO", "Somalia", "+252" },
                    { new Guid("23b482a6-185d-4728-aaf0-c23de231145d"), "TL", "Timor-Leste", "+670" },
                    { new Guid("2526eef8-3162-4797-93e4-6c0e5dc70aa1"), "SJ", "Svalbard and Jan Mayen", "" },
                    { new Guid("2565dd78-2c20-4677-a756-99c8161d5f89"), "DJ", "Djibouti", "+253" },
                    { new Guid("2745df9d-811a-4c49-b228-5f005b9aa14c"), "KN", "Saint Kitts and Nevis", "+1" },
                    { new Guid("27924651-e7c7-4e32-ba54-f771662a01b6"), "BH", "Bahrain", "+973" },
                    { new Guid("2b5b680c-9430-4bb2-a93c-9a2aac8f4b67"), "MU", "Mauritius", "+230" },
                    { new Guid("2b63c5da-4cb1-46ac-9905-4c96417ba4e8"), "KM", "Comoros", "+269" },
                    { new Guid("2b804e67-45d2-4e8f-8b68-3935f68682a4"), "SY", "Syrian Arab Republic", "+963" },
                    { new Guid("2c2e2a1f-e553-4877-b3ef-591a3b09c043"), "AI", "Anguilla", "+1" },
                    { new Guid("2d381bc2-797e-4f79-88ca-517006bf60e0"), "SL", "Sierra Leone", "+232" },
                    { new Guid("2d9e99db-af7c-455d-bc77-dc124ddb6a6d"), "SB", "Solomon Islands", "+677" },
                    { new Guid("2e1d080f-b221-4700-93ae-3821425396c1"), "MD", "Moldova, Republic of", "+373" },
                    { new Guid("31b5ad3f-ff02-4f8e-a2ff-4c9075c1a8f4"), "LK", "Sri Lanka", "+94" },
                    { new Guid("31df9a7b-abae-4ede-acd8-4fcb7f5dc5dd"), "AE", "United Arab Emirates", "+971" },
                    { new Guid("3335ad9f-7c3a-4db9-9915-bb4716f6a9ee"), "NI", "Nicaragua", "+505" },
                    { new Guid("33fcab49-83c1-4de8-847c-05d71b9b6c53"), "SS", "South Sudan", "+211" },
                    { new Guid("367ef737-9489-4be1-a6b7-8f0ed7466ad6"), "PR", "Puerto Rico", "" },
                    { new Guid("39ced6e0-5e57-49d2-9492-f1ac0c8aa252"), "LA", "Lao People's Democratic Republic", "+856" },
                    { new Guid("3a073360-a3a9-4a2d-a4f2-6d1d7c736436"), "ZW", "Zimbabwe", "+263" },
                    { new Guid("3a382aac-1397-4e64-9071-db5f4ea2dba3"), "QA", "Qatar", "+974" },
                    { new Guid("3b8ab57f-7087-4dbd-82b4-8e1fbbce1acf"), "KI", "Kiribati", "+686" },
                    { new Guid("3dc17b3b-3b05-4816-aac1-078a3361a8a8"), "DE", "Germany", "+49" },
                    { new Guid("41328c76-4bb6-4291-bca6-a641422e7a6a"), "BQ", "Bonaire, Sint Eustatius and Saba", "" },
                    { new Guid("41f9988b-fb3e-4a4f-979e-95afbcc1d00f"), "AX", "Åland Islands", "" },
                    { new Guid("42b59997-1c27-4538-995e-e7f09ba1097f"), "NC", "New Caledonia", "" },
                    { new Guid("43c22b11-4d2c-468e-a3c8-20a0a024adb3"), "SM", "San Marino", "+378" },
                    { new Guid("43d3ae78-c4d0-4659-bec4-e6cf0f3f5656"), "RS", "Serbia", "+381" },
                    { new Guid("445b666e-ed3c-4081-9053-1cadb2dd31cc"), "VU", "Vanuatu", "+678" },
                    { new Guid("4469d134-0d50-44aa-8532-291e9bf38914"), "TH", "Thailand", "+66" },
                    { new Guid("45042289-f833-4f58-b467-df2628f7a7b6"), "HN", "Honduras", "+504" },
                    { new Guid("464c8815-4bd7-43fd-9d9e-d4278726fe99"), "EE", "Estonia", "+372" },
                    { new Guid("469ec266-6431-4098-b88a-d3e22e0d1e64"), "CN", "China", "+86" },
                    { new Guid("47371b31-e542-428d-9564-d56898b49966"), "LT", "Lithuania", "+370" },
                    { new Guid("473e0cbb-2950-4694-a903-789e8642f4b2"), "CR", "Costa Rica", "+506" },
                    { new Guid("480cd126-b93f-4287-9426-4d56f4fb0ff1"), "LU", "Luxembourg", "+352" },
                    { new Guid("4a90f851-331c-4a98-b160-514d1eecbaac"), "HT", "Haiti", "+509" },
                    { new Guid("4ad910f2-547c-4cd8-a9da-c8d2922d7ef0"), "TC", "Turks and Caicos Islands", "" },
                    { new Guid("4b908fad-1df2-4f6f-a754-de04c126ce7a"), "BO", "Bolivia, Plurinational State of", "+591" },
                    { new Guid("4d4f8989-6957-4c7c-92f2-8b5ec23422d2"), "KP", "Korea, Democratic People's Republic of", "+850" },
                    { new Guid("4db26fc0-c9dc-4055-9cc4-0c44c77693d8"), "CC", "Cocos (Keeling) Islands", "+61" },
                    { new Guid("4e0062a2-12a1-40db-bf00-1abaec85786e"), "GN", "Guinea", "+224" },
                    { new Guid("4fa0ad89-642b-4491-bb51-f3a1949c072d"), "EG", "Egypt", "+20" },
                    { new Guid("515bc3aa-e0d6-4b85-9dff-ec6c7d5980a7"), "CV", "Cabo Verde", "+238" },
                    { new Guid("517ff285-1129-4d65-b892-0aa9ac00df41"), "ST", "Sao Tome and Principe", "+239" },
                    { new Guid("5251f726-8fdd-4f88-82a9-dbf10bff0ecf"), "GU", "Guam", "+1" },
                    { new Guid("5386b6cc-bd39-4c6f-bc40-5d786fe1b43c"), "JM", "Jamaica", "+1" },
                    { new Guid("54927b62-97d8-4be1-a2d7-45b1bf9dec87"), "SC", "Seychelles", "+248" },
                    { new Guid("55363f08-79da-4fb1-b897-17d297840ab6"), "PM", "Saint Pierre and Miquelon", "" },
                    { new Guid("55b664d7-77f7-4033-8de0-7b4561f6b024"), "TG", "Togo", "+228" },
                    { new Guid("55b7e759-ec29-4099-b05b-40685016cd12"), "YT", "Mayotte", "" },
                    { new Guid("56f3f981-4da6-4332-8741-cc8152aa2d66"), "CA", "Canada", "+1" },
                    { new Guid("5755f60b-7b47-4d0c-8bdb-62c5b88a8710"), "UY", "Uruguay", "+598" },
                    { new Guid("57d3cff4-ab90-4bf5-8f19-099aefac061b"), "DO", "Dominican Republic", "+1" },
                    { new Guid("59109d1e-cad7-4a51-a521-cddee298778d"), "PN", "Pitcairn", "" },
                    { new Guid("5a4ddac3-dcf8-430c-90a0-f49f479468da"), "GP", "Guadeloupe", "" },
                    { new Guid("5a62bc4e-d297-4fb3-80be-52b886a6228b"), "SN", "Senegal", "+221" },
                    { new Guid("5d891bf1-f70b-4c03-aa9d-26bb055c12e4"), "BV", "Bouvet Island", "" },
                    { new Guid("5f7beef2-4ad7-4bda-b7f9-1bedf0ed7381"), "DK", "Denmark", "+45" },
                    { new Guid("6024c3a7-a7d2-43fc-8182-951465a16ad5"), "LY", "Libya", "+218" },
                    { new Guid("613c5059-ac6e-447f-9fd1-157bb43eed4e"), "SZ", "Eswatini", "+268" },
                    { new Guid("6171e500-26f9-4ca0-b42a-eda27744c435"), "PF", "French Polynesia", "" },
                    { new Guid("63758084-fab2-4294-b052-305fb8a0c6f0"), "FR", "France", "+33" },
                    { new Guid("640e0b05-ca1c-466e-9c71-82749ba55802"), "MC", "Monaco", "+377" },
                    { new Guid("6580417d-a5af-45d0-96d5-8a242eceb32c"), "TR", "Turkey", "+90" },
                    { new Guid("6675716c-a063-4216-a7d2-2e360e3d61af"), "NA", "Namibia", "+264" },
                    { new Guid("68b1fe10-e3e0-4f25-a6f7-7ed8c1628347"), "NE", "Niger", "+227" },
                    { new Guid("6a58d04b-1f92-47e9-acb0-bba29938bbeb"), "VN", "Viet Nam", "+84" },
                    { new Guid("6ade9194-bcf5-43ea-a87d-8507e3a5dca4"), "AG", "Antigua and Barbuda", "+1" },
                    { new Guid("6af36669-ec22-4245-a489-a8cc13913277"), "NZ", "New Zealand", "+64" },
                    { new Guid("6b69b1ff-250b-44db-9902-7459bf002ef8"), "BI", "Burundi", "+257" },
                    { new Guid("6bd3f304-1e33-46e4-9d98-acc680183af2"), "GR", "Greece", "+30" },
                    { new Guid("6c71d347-d157-44c1-ab3d-05910b8739c4"), "BN", "Brunei Darussalam", "+673" },
                    { new Guid("6cd0e26d-0545-45a1-bafa-36a23fdfacfd"), "CM", "Cameroon", "+237" },
                    { new Guid("6cfa5e79-342b-46e0-ba93-d25847a0738d"), "CX", "Christmas Island", "+61" },
                    { new Guid("71fc5344-dd39-4469-b9ae-e07cd0ce27e3"), "AS", "American Samoa", "+1" },
                    { new Guid("720f62a1-5f7d-44fd-9b6f-9384dff5b7d5"), "ER", "Eritrea", "+291" },
                    { new Guid("726a60e3-0a03-4653-8298-0e9c60946e5e"), "PS", "Palestine, State of", "" },
                    { new Guid("72edfaf1-32df-459e-8923-2e9443f6902c"), "GL", "Greenland", "" },
                    { new Guid("73243e76-cc22-4215-9e6b-fb68d8b97e33"), "CL", "Chile", "+56" },
                    { new Guid("73355092-a266-4187-8542-99a5e1c462f5"), "GB", "United Kingdom", "+44" },
                    { new Guid("738fda2e-06ff-4d67-82e3-63a492927c10"), "TV", "Tuvalu", "+688" },
                    { new Guid("74ab3fb3-8960-4de9-b62c-3977902d2b82"), "KZ", "Kazakhstan", "+7" },
                    { new Guid("75f8e82d-bafa-4040-9cd8-2b636a1787c2"), "FI", "Finland", "+358" },
                    { new Guid("76012696-fd23-4c1a-bc09-4578a83b468c"), "AO", "Angola", "+244" },
                    { new Guid("76bca202-39a1-4ae8-995a-4a2c8f4a92bc"), "CH", "Switzerland", "+41" },
                    { new Guid("78e75007-0477-4fea-8f46-fef5b7ffce1f"), "MS", "Montserrat", "" },
                    { new Guid("7ae261bb-adac-40da-b235-7b462594b886"), "LV", "Latvia", "+371" },
                    { new Guid("7b489311-0cea-4089-80c6-2f0122f75d25"), "NL", "Netherlands", "+31" },
                    { new Guid("7c4ba916-00f4-42c5-963a-a84b4c1476a3"), "PA", "Panama", "+507" },
                    { new Guid("7cb3f11c-9da0-48cf-9e7b-adce897f176e"), "VG", "Virgin Islands, British", "" },
                    { new Guid("7fa1ba51-f943-4199-a964-e4b195080629"), "SA", "Saudi Arabia", "+966" },
                    { new Guid("806aed22-1593-40e2-b78c-5f19d6a2ba1c"), "JO", "Jordan", "+962" },
                    { new Guid("82b70a8f-a208-45cd-80bf-cd24cb199350"), "OM", "Oman", "+968" },
                    { new Guid("838eb209-1479-4baf-8b22-a3e84bb11b3b"), "EH", "Western Sahara", "" },
                    { new Guid("83a7a2b4-1468-4bf2-bdbb-3d2b75cbfe04"), "PL", "Poland", "+48" },
                    { new Guid("8481c402-0475-412c-9eeb-7d1259b9d3a6"), "VC", "Saint Vincent and the Grenadines", "+1" },
                    { new Guid("84ec14ec-04a6-43ae-b293-48749895b85a"), "MG", "Madagascar", "+261" },
                    { new Guid("852ed757-556c-4b45-b061-bfbbcfeb1204"), "PW", "Palau", "+680" },
                    { new Guid("8664b76e-1eae-46dd-b6d0-165da12a06f2"), "JP", "Japan", "+81" },
                    { new Guid("8752198d-7e86-4ece-bf23-5ee2a07c2924"), "SX", "Sint Maarten (Dutch part)", "" },
                    { new Guid("8769baf1-96a0-4c87-ac5b-34661b5346fb"), "BB", "Barbados", "+1" },
                    { new Guid("87e7c17c-ed65-4b4f-ba81-ea3ee9b69be8"), "PG", "Papua New Guinea", "+675" },
                    { new Guid("89102701-131d-4e2f-9989-41d68cf2f5cf"), "GQ", "Equatorial Guinea", "+240" },
                    { new Guid("898b4733-187c-41d6-b3da-c109a0dfe93f"), "TK", "Tokelau", "" },
                    { new Guid("8d453f03-06c4-4b44-ad4f-634fbdb53923"), "AW", "Aruba", "+297" },
                    { new Guid("8e9e346a-530e-48d4-b8da-f9d5b1355fc5"), "PK", "Pakistan", "+92" },
                    { new Guid("8eb1381b-2dd7-4186-9cf5-dad62192d859"), "SD", "Sudan", "+249" },
                    { new Guid("8f8caa72-1b6a-4bb1-83c4-b84cf1a6ecdb"), "BW", "Botswana", "+267" },
                    { new Guid("94b09b47-cc18-46f0-8d17-9acdf66196f0"), "BJ", "Benin", "+229" },
                    { new Guid("9605c8db-42ce-4f9b-a033-f8d6123c2a8e"), "IQ", "Iraq", "+964" },
                    { new Guid("98e2ab38-d3f4-411d-a79b-934d9c4be6aa"), "NP", "Nepal", "+977" },
                    { new Guid("9a786c02-3cf0-4225-88f1-11fa01ade59c"), "SR", "Suriname", "+597" },
                    { new Guid("9d4083bd-4db8-4bc6-ad92-7b72a840d391"), "TZ", "Tanzania, United Republic of", "+255" },
                    { new Guid("9ed7ca59-53b7-45a5-8aa0-477a332e456d"), "BY", "Belarus", "+375" },
                    { new Guid("a10a02a5-3a40-41f6-9c63-7f9c500ec05a"), "WS", "Samoa", "+685" },
                    { new Guid("a151002b-206b-49cf-919f-9da6a9d7d412"), "TD", "Chad", "+235" },
                    { new Guid("a1898717-6ec9-4c82-864b-ff008cf3e84b"), "AU", "Australia", "+61" },
                    { new Guid("a21912e8-1c97-47ab-a0bf-e1434a2475c4"), "CG", "Congo", "+242" },
                    { new Guid("a318dbd4-88e4-4f93-866b-7fa6b14662b5"), "TO", "Tonga", "+676" },
                    { new Guid("a4367d73-1486-4edc-a960-1c1be75d1325"), "GH", "Ghana", "+233" },
                    { new Guid("a4710c26-89fc-4be2-b7be-b740ed146fe2"), "TJ", "Tajikistan", "+992" },
                    { new Guid("a611aafd-5855-419e-8def-63cd52ff221f"), "NR", "Nauru", "+674" },
                    { new Guid("a6583fc7-4ed9-4328-9a7c-f0cc73df2141"), "VE", "Venezuela, Bolivarian Republic of", "+58" },
                    { new Guid("a68a3122-bf44-4348-9d19-e8a7ffbdb72e"), "KH", "Cambodia", "+855" },
                    { new Guid("a6cbf582-db47-407b-bb58-c1dd84951a9f"), "HK", "Hong Kong", "+852" },
                    { new Guid("a8f4d294-69dc-4fb3-b416-5252666e3f96"), "MR", "Mauritania", "+222" },
                    { new Guid("ab8a4653-5833-465b-8653-dc68dace8831"), "KW", "Kuwait", "+965" },
                    { new Guid("ac3ec321-41b8-4205-93ab-dbae9e77225d"), "MH", "Marshall Islands", "+692" },
                    { new Guid("afe97c10-52b7-46f1-a805-ddcb5ff195d9"), "BS", "Bahamas", "+1" },
                    { new Guid("b02a17cb-b391-4fd5-a5b2-52b187b09180"), "MV", "Maldives", "+960" },
                    { new Guid("b0619130-f5b7-46f2-b3f7-a23c010f310a"), "ES", "Spain", "+34" },
                    { new Guid("b0b172f1-b36d-4e18-959b-dce1597e4741"), "GA", "Gabon", "+241" },
                    { new Guid("b33aaa0c-5ca5-4ac0-b206-d72dd7b7ad84"), "GS", "South Georgia and the South Sandwich Islands", "" },
                    { new Guid("b3e8ef89-491c-4079-b17d-38af3af4db27"), "EC", "Ecuador", "+593" },
                    { new Guid("b5851fd6-c85d-48e0-aad7-3d27ab5f2913"), "TT", "Trinidad and Tobago", "+1" },
                    { new Guid("b6f9f2ed-7c0c-43a5-9362-46de555d4513"), "MY", "Malaysia", "+60" },
                    { new Guid("b7787770-cc59-4087-a24c-19be6605496c"), "US", "United States", "+1" },
                    { new Guid("b8e1f519-bd55-464e-a0db-926591f50f17"), "IO", "British Indian Ocean Territory", "+246" },
                    { new Guid("b8efbb37-61b2-4b7f-bd44-cb67a861abb2"), "SV", "El Salvador", "+503" },
                    { new Guid("b99ad51c-61f6-4f4d-b436-eb5a7be86bd6"), "BE", "Belgium", "+32" },
                    { new Guid("b9a3cc4c-dccf-4e88-972c-713f2290af96"), "AF", "Afghanistan", "+93" },
                    { new Guid("bbeb06b9-e681-4d08-bdf6-e138c931f19b"), "TF", "French Southern Territories", "" },
                    { new Guid("bbf9c801-18ed-44c8-8b8b-2a515e7255a3"), "FK", "Falkland Islands (Malvinas)", "" },
                    { new Guid("bceed9dc-b277-40e6-a8c0-82a194309333"), "PH", "Philippines", "+63" },
                    { new Guid("bd93ae94-8f8b-4bfb-af5d-704c94dcba3e"), "NU", "Niue", "" },
                    { new Guid("bf9d4d3a-5943-4170-a395-a510cd6f6ca1"), "ID", "Indonesia", "+62" },
                    { new Guid("bfc729de-e643-4894-9432-c56b7e5bd07d"), "DM", "Dominica", "+1" },
                    { new Guid("c11af6f5-0860-49ce-88c8-b2ade5b6a58b"), "BM", "Bermuda", "+1" },
                    { new Guid("c1a52df1-8eca-423e-a23b-afadf473903d"), "GT", "Guatemala", "+502" },
                    { new Guid("c2839720-9f18-4c7f-9e04-9d1e58d4e28b"), "BD", "Bangladesh", "+880" },
                    { new Guid("c54a6668-b584-4a12-a24f-42d40f1a3c46"), "MQ", "Martinique", "" },
                    { new Guid("c5a9a325-9c07-4a68-878d-f48d70381d33"), "FO", "Faroe Islands", "" },
                    { new Guid("c786b948-a7bc-4e9d-963f-925a9019704e"), "IL", "Israel", "+972" },
                    { new Guid("c7b79b9c-da30-45bd-9ce1-df685b06c713"), "MZ", "Mozambique", "+258" },
                    { new Guid("c7f032b1-8714-4632-afd5-2ba30f8ff5b4"), "AQ", "Antarctica", "+672" },
                    { new Guid("c90d7b6f-1ce5-41f3-88d8-2881f1b75e40"), "ME", "Montenegro", "+382" },
                    { new Guid("c9cfb9ac-3802-4aac-ba0b-e472caf9ca35"), "AT", "Austria", "+43" },
                    { new Guid("c9f1b8bf-bba1-48a5-ab9e-318bdd356759"), "GW", "Guinea-Bissau", "+245" },
                    { new Guid("ca15ffad-0b29-4e23-93a6-58d1b6f8fe58"), "LC", "Saint Lucia", "+1" },
                    { new Guid("cb80ee86-e223-460c-9e1b-888477ad3f13"), "LB", "Lebanon", "+961" },
                    { new Guid("cc480fc8-8ad3-4be3-8216-a461618b18f2"), "SI", "Slovenia", "+386" },
                    { new Guid("cfe6feb4-0236-42f4-83d2-588fb07a6653"), "MM", "Myanmar", "+95" },
                    { new Guid("d186044b-a9a1-4e30-85a4-777fd5a8af1f"), "TN", "Tunisia", "+216" },
                    { new Guid("d39c4226-3abc-46c1-b442-24f114c69d6c"), "CK", "Cook Islands", "+682" },
                    { new Guid("d3af6f5f-53d9-472a-b408-048c66cce779"), "SK", "Slovakia", "+421" },
                    { new Guid("d3f02533-9fc8-4d40-b5dc-a3892a81d179"), "PY", "Paraguay", "+595" },
                    { new Guid("d4ab3aa6-cfdf-44d6-b7b4-341eab239687"), "BF", "Burkina Faso", "+226" },
                    { new Guid("d4b4cc81-505e-415d-be7d-516ecbcac635"), "BG", "Bulgaria", "+359" },
                    { new Guid("d5b0da45-f393-4588-9448-81ba20f31b8c"), "MF", "Saint Martin (French part)", "" },
                    { new Guid("d5dfe5ee-b906-4984-b5ee-8440d5a5bd31"), "RO", "Romania", "+40" },
                    { new Guid("d6ccea7c-8f66-4036-b1e9-90c7ab744da0"), "ML", "Mali", "+223" },
                    { new Guid("d6ccf9c9-ae22-4f48-97bc-25d04a817717"), "GG", "Guernsey", "" },
                    { new Guid("d78c6595-8d92-4528-9239-a6b5145938f3"), "PT", "Portugal", "+351" },
                    { new Guid("d8c97b03-967e-4920-9eec-44021e911d09"), "IE", "Ireland", "+353" },
                    { new Guid("d8f84d1c-8721-41d0-80db-b1356989a3c8"), "IT", "Italy", "+39" },
                    { new Guid("d928fd01-2a6c-48c5-b71b-364c317d1aab"), "GF", "French Guiana", "" },
                    { new Guid("dbcad264-5348-4a6d-903a-67bbea02c147"), "AM", "Armenia", "+374" },
                    { new Guid("dd03d510-cbdd-4b66-9cca-1c36457ecff3"), "HR", "Croatia", "+385" },
                    { new Guid("dd608886-a83b-4fcf-8020-d7c478d6f090"), "NO", "Norway", "+47" },
                    { new Guid("ddb32677-57e8-4b14-87b0-e63f671e668f"), "MK", "North Macedonia", "+389" },
                    { new Guid("df05966f-c1a9-4be4-83d3-01c6b6adec8c"), "BZ", "Belize", "+501" },
                    { new Guid("df144ffa-edf1-40ad-b193-11d19b7c31e7"), "BR", "Brazil", "+55" },
                    { new Guid("e20db8a8-7fde-4d9b-a0f4-3a36c8c91445"), "ZM", "Zambia", "+260" },
                    { new Guid("e236d89c-399b-4c1d-89e1-96e6473602ae"), "RE", "Réunion", "" },
                    { new Guid("e2dd03f5-15e0-45c5-bf95-e07d41705d5f"), "AZ", "Azerbaijan", "+994" },
                    { new Guid("e3557751-b129-46bf-a2b2-a9a6f358bf49"), "SE", "Sweden", "+46" },
                    { new Guid("e50c5c81-7fab-49a0-a09e-3da874c62ccf"), "CD", "Congo, The Democratic Republic of the", "+243" },
                    { new Guid("e651d2bb-a497-4fdf-a604-6fb52cc1fb0c"), "FM", "Micronesia, Federated States of", "+691" },
                    { new Guid("e6d7f25c-a97b-494d-b3b1-e42f48b0333e"), "WF", "Wallis and Futuna", "" },
                    { new Guid("e6f19f16-5f90-4514-a16a-44596788df74"), "CZ", "Czechia", "+420" },
                    { new Guid("e8fdd6d2-d58a-4307-bbb2-9b261a40dc73"), "CW", "Curaçao", "" },
                    { new Guid("e9187d90-8f38-474e-95db-6aa392b62114"), "YE", "Yemen", "+967" },
                    { new Guid("ec30150a-5e5a-44b9-94b4-0f4f0c174078"), "UZ", "Uzbekistan", "+998" },
                    { new Guid("ee4f9f63-fea8-4cb0-90e8-b4a0d8e2e9f8"), "MO", "Macao", "+853" },
                    { new Guid("f0236f95-e9a9-45e6-ba23-4b6611f7b986"), "UA", "Ukraine", "+380" },
                    { new Guid("f094fb0b-d75a-45c2-87fa-db3f126bdaa6"), "PE", "Peru", "+51" },
                    { new Guid("f1e997a4-d2ce-46d3-8ab8-0376211ef280"), "UG", "Uganda", "+256" },
                    { new Guid("f24d2952-efac-43c8-aead-84b642ce5973"), "LI", "Liechtenstein", "+423" },
                    { new Guid("f406f393-d791-4817-9cdc-ccf5638b454a"), "NG", "Nigeria", "+234" },
                    { new Guid("f4afb1bf-8311-4618-afd5-cda9b3cae107"), "HM", "Heard Island and McDonald Islands", "" },
                    { new Guid("f4ba0c45-a514-4d61-ae04-87a7ad1745a0"), "SG", "Singapore", "+65" },
                    { new Guid("f4f4c88e-a07f-4761-b2aa-34de8d0d025e"), "MN", "Mongolia", "+976" },
                    { new Guid("f5068d9e-b235-412e-84a8-fcaa1f94c59b"), "DZ", "Algeria", "+213" },
                    { new Guid("f5f3797b-2a28-4c78-90df-abd6c14e93cc"), "BT", "Bhutan", "+975" },
                    { new Guid("f656e4e6-cf18-4a28-a98b-37f157a03ee4"), "AR", "Argentina", "+54" },
                    { new Guid("f71f394a-56c6-404a-b888-56fead5caf24"), "RW", "Rwanda", "+250" },
                    { new Guid("f8cacb32-db84-4b69-9d77-ba20a2ec2ae1"), "CY", "Cyprus", "+357" },
                    { new Guid("fac592cd-0938-431f-80de-a9bef0d9ea93"), "FJ", "Fiji", "+679" },
                    { new Guid("fb313951-8e51-4652-bac3-80360b5b306d"), "LS", "Lesotho", "+266" },
                    { new Guid("fbdc814e-3ef8-42fa-94b2-2f9bdaf889ed"), "GY", "Guyana", "+592" },
                    { new Guid("fc6dd333-a976-4f9b-95f4-c15cfd748cde"), "CI", "Côte d'Ivoire", "+225" },
                    { new Guid("ffb87363-2f3f-4dd3-b239-1a38f8fb2bea"), "CU", "Cuba", "+53" }
                });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { new Guid("01172b87-e3f6-4f60-8f0b-313aab662c6a"), "Valle del Cauca", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("0d124589-3f7b-46bc-b31c-d7e51aef4c4b"), "Guaviare", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("2e6e2044-d35e-4d6c-8d7b-00f6b1bb760a"), "Putumayo", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("2f5b57dc-3026-48a5-bd47-8fa5d5a5c6f1"), "San Andrés y Providencia", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("4ae71910-0a47-4421-a12d-02b82b6bbcb7"), "Chocó", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("4cfa9a62-69fd-4ae2-9c52-22819be6edb4"), "Guainía", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("4ff29fa6-6c34-4a9f-92a4-073b6a8dfb8f"), "Sucre", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("5e49d1a1-5f4b-4ea6-8476-994d32d042ef"), "La Guajira", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("65ce7390-b287-43b7-bf0a-408d6fdc1e43"), "Meta", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("6a8b6502-8f7f-4d41-b48a-b858bfb4b8e4"), "Quindío", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("76a47836-06a2-4e9a-bd1f-68d0e59d6f67"), "Boyacá", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("872b38a4-d4a5-4bd1-b650-24b137ff7b26"), "Tolima", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("93ac9a53-e0fc-4ff0-a15e-4455e2797cb3"), "Huila", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("94f4cfcd-98c6-4f76-b151-139aa420f6d5"), "Risaralda", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("9d54652e-9964-48d5-a4e5-933c21f064cc"), "Nariño", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("a0c8c530-05ce-4b31-a167-378bb8c44754"), "Atlántico", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("a1c3f2d4-88f9-4ad9-9155-1e889b9c2b01"), "Amazonas", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("ae32c0db-ecfc-4975-a063-f2e13767451b"), "Vichada", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("ae6e8c56-4d8a-4d97-8840-8036a30828d2"), "Caquetá", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("b13cdb17-7e7f-49c2-b25e-bf8c4d529ad4"), "Norte de Santander", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("b2e7a12c-6ac9-4f9e-963e-9b6d3825f962"), "Antioquia", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("b32b60a3-fd1d-4a56-9ce6-91cf994ef080"), "Casanare", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("c6bfb1d0-cbde-4a7f-8ad1-62f7645d38a3"), "Arauca", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("cd65a502-2c6f-4298-8e5e-7bb0fc12f350"), "Córdoba", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("d9b9ea69-355b-4c95-a0a5-9bcb1f7e5b70"), "Cesar", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("dc6cc70b-dfd1-4ec9-b34d-3d0df51c3c83"), "Bolívar", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("df905248-bd83-474b-9b58-33e9f478b6cb"), "Vaupés", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("e3c9a2fb-c9ad-4176-b8dc-214008ea9821"), "Magdalena", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("f00f77a9-4042-49b3-8759-01c4bcba8e03"), "Santander", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("f4ac9a6e-0bd5-48b0-bbee-0343d7424694"), "Cundinamarca", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("fc6cc79b-dfd1-42c9-b35d-3d0df51c1c83"), "Bogotá D.C.", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("fd1149ea-6a2d-44b7-9ec4-0cd342a2ed17"), "Caldas", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("fe4db8a1-3cf2-43e3-981c-bbcde0b3e6db"), "Cauca", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") }
                });

            migrationBuilder.InsertData(
                table: "TiposDocumento",
                columns: new[] { "Id", "Abreviatura", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { new Guid("3bb70e61-e370-48f0-b9b8-5c6d5104c6f5"), "RC", "Registro Civil", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("4f9dd50a-9d98-4b27-bcb9-994e4dc6b221"), "SC", "Salvoconducto", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("5f7d0e8d-c2de-40d3-a1db-e3a5076d826e"), "PA", "Pasaporte", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("79947df7-5e67-4d49-b776-02aaee1971e6"), "PEP", "Permiso Especial de Permanencia", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("8b4e0c73-61d7-48cf-b6f0-d3ad1666f261"), "CD", "Carné Diplomático", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("94e9c676-2e8f-4968-9c9a-0ff9f0ffba25"), "CE", "Cédula de Extranjería", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("ac7a2f58-14c3-4b0b-a579-378edc6c5291"), "NIT", "Número de Identificación Tributaria", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("db5f8657-d4b5-4e7c-9267-f2d32bc8bb3e"), "DNI", "Documento Nacional de Identidad", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("f0a12f4c-e91e-40a5-a1f4-7f01a3a27101"), "CC", "Cédula de Ciudadanía", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") },
                    { new Guid("f2b38e65-6313-4682-a27b-83c7b89ff8d2"), "TI", "Tarjeta de Identidad", new Guid("01b4e9d1-a84e-41c9-8768-253209225a21") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0175eafe-e0fc-477d-95b6-7b55770d73a2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("01b4e9d1-a84e-41c9-8768-253209225a21"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("02ba7af3-2a07-43da-ba9f-f4eb03ba021c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("044bc2d0-46db-42a4-897e-3247af887f61"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("04a02196-4f59-4bac-aeaf-4970ca528ca7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("05144185-e27f-485e-9e8b-e79fa6e92a20"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("05743052-b2a2-4991-bfa6-ccd15a44d844"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("061af03b-946a-42d2-b4a6-573fbf59fa2d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("061e119c-fee4-4d88-af65-17a7d6f180f8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("072cc336-9afd-43c3-a2b3-865ea688ff7d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("07dea8ac-af76-4166-8aa6-afba8457334d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("080c717f-84a8-40e3-98d1-f974c35497cc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("08f13aa3-b89d-4201-ac95-a9a208e2a628"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0934278d-a7c4-40f5-8a0f-08663d1e4c8b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0bafb85a-2e90-4416-8e30-0513a7af9465"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0d4f504a-38e8-4853-8a9f-2e49e100546d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0da556cf-6e6e-40c5-89c8-73f3b02137fd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0f697547-58e8-4f6c-808b-a5d50032bf37"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("10f6dbcd-5afa-41a4-8d15-d5a71bea243f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1241d22e-3c1c-4ac5-9c7e-c45d5dba0022"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("12a097c5-1661-436f-aa7b-23f64ae690d9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("138a7f0f-d49e-4c2e-9aa8-85ab4bebd2cc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1391ba6f-8245-4d57-b9a4-1ea694efa78b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1498fc70-28c9-4ab2-bf68-7833c00a8007"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("154ef284-76ca-4851-bd9b-dd372b02c521"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("15ae4960-14ec-4600-a148-5ec447af0bbe"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("15ce09f2-f9c8-4bfd-996c-dee92d005bf9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("16e69a5f-bdd5-456a-a70e-e063acfd73fe"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("184df0f2-066e-4210-8c0e-6a6a6f5cad49"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("18fe29e3-d5c6-4bb5-8592-9f20fc65657f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1a2b0024-097c-4d50-a7fa-19d2708f4689"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1b79e74d-b3ce-44c0-b59c-8ec59e15eb39"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1ba3e674-700f-4ff6-8a62-30deca7eb46d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1db0faf4-b95c-4b87-a9d0-082bc0e17397"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("220b36fb-b33f-423e-b056-6e8beadd59bb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("22227c40-e32e-429e-801f-98bf751ec249"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("22c33c28-db68-4d5b-a601-6bcb3e3ae39a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("23b482a6-185d-4728-aaf0-c23de231145d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2526eef8-3162-4797-93e4-6c0e5dc70aa1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2565dd78-2c20-4677-a756-99c8161d5f89"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2745df9d-811a-4c49-b228-5f005b9aa14c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("27924651-e7c7-4e32-ba54-f771662a01b6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2b5b680c-9430-4bb2-a93c-9a2aac8f4b67"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2b63c5da-4cb1-46ac-9905-4c96417ba4e8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2b804e67-45d2-4e8f-8b68-3935f68682a4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2c2e2a1f-e553-4877-b3ef-591a3b09c043"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2d381bc2-797e-4f79-88ca-517006bf60e0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2d9e99db-af7c-455d-bc77-dc124ddb6a6d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2e1d080f-b221-4700-93ae-3821425396c1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("31b5ad3f-ff02-4f8e-a2ff-4c9075c1a8f4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("31df9a7b-abae-4ede-acd8-4fcb7f5dc5dd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3335ad9f-7c3a-4db9-9915-bb4716f6a9ee"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("33fcab49-83c1-4de8-847c-05d71b9b6c53"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("367ef737-9489-4be1-a6b7-8f0ed7466ad6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("39ced6e0-5e57-49d2-9492-f1ac0c8aa252"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3a073360-a3a9-4a2d-a4f2-6d1d7c736436"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3a382aac-1397-4e64-9071-db5f4ea2dba3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3b8ab57f-7087-4dbd-82b4-8e1fbbce1acf"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3dc17b3b-3b05-4816-aac1-078a3361a8a8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("41328c76-4bb6-4291-bca6-a641422e7a6a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("41f9988b-fb3e-4a4f-979e-95afbcc1d00f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("42b59997-1c27-4538-995e-e7f09ba1097f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("43c22b11-4d2c-468e-a3c8-20a0a024adb3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("43d3ae78-c4d0-4659-bec4-e6cf0f3f5656"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("445b666e-ed3c-4081-9053-1cadb2dd31cc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4469d134-0d50-44aa-8532-291e9bf38914"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("45042289-f833-4f58-b467-df2628f7a7b6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("464c8815-4bd7-43fd-9d9e-d4278726fe99"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("469ec266-6431-4098-b88a-d3e22e0d1e64"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("47371b31-e542-428d-9564-d56898b49966"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("473e0cbb-2950-4694-a903-789e8642f4b2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("480cd126-b93f-4287-9426-4d56f4fb0ff1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4a90f851-331c-4a98-b160-514d1eecbaac"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4ad910f2-547c-4cd8-a9da-c8d2922d7ef0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4b908fad-1df2-4f6f-a754-de04c126ce7a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4d4f8989-6957-4c7c-92f2-8b5ec23422d2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4db26fc0-c9dc-4055-9cc4-0c44c77693d8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4e0062a2-12a1-40db-bf00-1abaec85786e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4fa0ad89-642b-4491-bb51-f3a1949c072d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("515bc3aa-e0d6-4b85-9dff-ec6c7d5980a7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("517ff285-1129-4d65-b892-0aa9ac00df41"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5251f726-8fdd-4f88-82a9-dbf10bff0ecf"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5386b6cc-bd39-4c6f-bc40-5d786fe1b43c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("54927b62-97d8-4be1-a2d7-45b1bf9dec87"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("55363f08-79da-4fb1-b897-17d297840ab6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("55b664d7-77f7-4033-8de0-7b4561f6b024"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("55b7e759-ec29-4099-b05b-40685016cd12"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("56f3f981-4da6-4332-8741-cc8152aa2d66"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5755f60b-7b47-4d0c-8bdb-62c5b88a8710"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("57d3cff4-ab90-4bf5-8f19-099aefac061b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("59109d1e-cad7-4a51-a521-cddee298778d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5a4ddac3-dcf8-430c-90a0-f49f479468da"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5a62bc4e-d297-4fb3-80be-52b886a6228b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5d891bf1-f70b-4c03-aa9d-26bb055c12e4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5f7beef2-4ad7-4bda-b7f9-1bedf0ed7381"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6024c3a7-a7d2-43fc-8182-951465a16ad5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("613c5059-ac6e-447f-9fd1-157bb43eed4e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6171e500-26f9-4ca0-b42a-eda27744c435"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("63758084-fab2-4294-b052-305fb8a0c6f0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("640e0b05-ca1c-466e-9c71-82749ba55802"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6580417d-a5af-45d0-96d5-8a242eceb32c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6675716c-a063-4216-a7d2-2e360e3d61af"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("68b1fe10-e3e0-4f25-a6f7-7ed8c1628347"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6a58d04b-1f92-47e9-acb0-bba29938bbeb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6ade9194-bcf5-43ea-a87d-8507e3a5dca4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6af36669-ec22-4245-a489-a8cc13913277"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6b69b1ff-250b-44db-9902-7459bf002ef8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6bd3f304-1e33-46e4-9d98-acc680183af2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6c71d347-d157-44c1-ab3d-05910b8739c4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6cd0e26d-0545-45a1-bafa-36a23fdfacfd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6cfa5e79-342b-46e0-ba93-d25847a0738d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("71fc5344-dd39-4469-b9ae-e07cd0ce27e3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("720f62a1-5f7d-44fd-9b6f-9384dff5b7d5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("726a60e3-0a03-4653-8298-0e9c60946e5e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("72edfaf1-32df-459e-8923-2e9443f6902c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("73243e76-cc22-4215-9e6b-fb68d8b97e33"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("73355092-a266-4187-8542-99a5e1c462f5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("738fda2e-06ff-4d67-82e3-63a492927c10"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("74ab3fb3-8960-4de9-b62c-3977902d2b82"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("75f8e82d-bafa-4040-9cd8-2b636a1787c2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("76012696-fd23-4c1a-bc09-4578a83b468c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("76bca202-39a1-4ae8-995a-4a2c8f4a92bc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("78e75007-0477-4fea-8f46-fef5b7ffce1f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7ae261bb-adac-40da-b235-7b462594b886"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7b489311-0cea-4089-80c6-2f0122f75d25"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7c4ba916-00f4-42c5-963a-a84b4c1476a3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7cb3f11c-9da0-48cf-9e7b-adce897f176e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7fa1ba51-f943-4199-a964-e4b195080629"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("806aed22-1593-40e2-b78c-5f19d6a2ba1c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("82b70a8f-a208-45cd-80bf-cd24cb199350"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("838eb209-1479-4baf-8b22-a3e84bb11b3b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("83a7a2b4-1468-4bf2-bdbb-3d2b75cbfe04"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8481c402-0475-412c-9eeb-7d1259b9d3a6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("84ec14ec-04a6-43ae-b293-48749895b85a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("852ed757-556c-4b45-b061-bfbbcfeb1204"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8664b76e-1eae-46dd-b6d0-165da12a06f2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8752198d-7e86-4ece-bf23-5ee2a07c2924"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8769baf1-96a0-4c87-ac5b-34661b5346fb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("87e7c17c-ed65-4b4f-ba81-ea3ee9b69be8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("89102701-131d-4e2f-9989-41d68cf2f5cf"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("898b4733-187c-41d6-b3da-c109a0dfe93f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8d453f03-06c4-4b44-ad4f-634fbdb53923"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8e9e346a-530e-48d4-b8da-f9d5b1355fc5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8eb1381b-2dd7-4186-9cf5-dad62192d859"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8f8caa72-1b6a-4bb1-83c4-b84cf1a6ecdb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("94b09b47-cc18-46f0-8d17-9acdf66196f0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9605c8db-42ce-4f9b-a033-f8d6123c2a8e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("98e2ab38-d3f4-411d-a79b-934d9c4be6aa"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9a786c02-3cf0-4225-88f1-11fa01ade59c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9d4083bd-4db8-4bc6-ad92-7b72a840d391"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9ed7ca59-53b7-45a5-8aa0-477a332e456d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a10a02a5-3a40-41f6-9c63-7f9c500ec05a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a151002b-206b-49cf-919f-9da6a9d7d412"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a1898717-6ec9-4c82-864b-ff008cf3e84b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a21912e8-1c97-47ab-a0bf-e1434a2475c4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a318dbd4-88e4-4f93-866b-7fa6b14662b5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a4367d73-1486-4edc-a960-1c1be75d1325"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a4710c26-89fc-4be2-b7be-b740ed146fe2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a611aafd-5855-419e-8def-63cd52ff221f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a6583fc7-4ed9-4328-9a7c-f0cc73df2141"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a68a3122-bf44-4348-9d19-e8a7ffbdb72e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a6cbf582-db47-407b-bb58-c1dd84951a9f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a8f4d294-69dc-4fb3-b416-5252666e3f96"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ab8a4653-5833-465b-8653-dc68dace8831"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ac3ec321-41b8-4205-93ab-dbae9e77225d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("afe97c10-52b7-46f1-a805-ddcb5ff195d9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b02a17cb-b391-4fd5-a5b2-52b187b09180"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b0619130-f5b7-46f2-b3f7-a23c010f310a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b0b172f1-b36d-4e18-959b-dce1597e4741"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b33aaa0c-5ca5-4ac0-b206-d72dd7b7ad84"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b3e8ef89-491c-4079-b17d-38af3af4db27"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b5851fd6-c85d-48e0-aad7-3d27ab5f2913"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b6f9f2ed-7c0c-43a5-9362-46de555d4513"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b7787770-cc59-4087-a24c-19be6605496c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b8e1f519-bd55-464e-a0db-926591f50f17"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b8efbb37-61b2-4b7f-bd44-cb67a861abb2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b99ad51c-61f6-4f4d-b436-eb5a7be86bd6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b9a3cc4c-dccf-4e88-972c-713f2290af96"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bbeb06b9-e681-4d08-bdf6-e138c931f19b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bbf9c801-18ed-44c8-8b8b-2a515e7255a3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bceed9dc-b277-40e6-a8c0-82a194309333"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bd93ae94-8f8b-4bfb-af5d-704c94dcba3e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bf9d4d3a-5943-4170-a395-a510cd6f6ca1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bfc729de-e643-4894-9432-c56b7e5bd07d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c11af6f5-0860-49ce-88c8-b2ade5b6a58b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c1a52df1-8eca-423e-a23b-afadf473903d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c2839720-9f18-4c7f-9e04-9d1e58d4e28b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c54a6668-b584-4a12-a24f-42d40f1a3c46"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c5a9a325-9c07-4a68-878d-f48d70381d33"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c786b948-a7bc-4e9d-963f-925a9019704e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c7b79b9c-da30-45bd-9ce1-df685b06c713"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c7f032b1-8714-4632-afd5-2ba30f8ff5b4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c90d7b6f-1ce5-41f3-88d8-2881f1b75e40"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c9cfb9ac-3802-4aac-ba0b-e472caf9ca35"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c9f1b8bf-bba1-48a5-ab9e-318bdd356759"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ca15ffad-0b29-4e23-93a6-58d1b6f8fe58"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cb80ee86-e223-460c-9e1b-888477ad3f13"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cc480fc8-8ad3-4be3-8216-a461618b18f2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cfe6feb4-0236-42f4-83d2-588fb07a6653"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d186044b-a9a1-4e30-85a4-777fd5a8af1f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d39c4226-3abc-46c1-b442-24f114c69d6c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d3af6f5f-53d9-472a-b408-048c66cce779"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d3f02533-9fc8-4d40-b5dc-a3892a81d179"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d4ab3aa6-cfdf-44d6-b7b4-341eab239687"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d4b4cc81-505e-415d-be7d-516ecbcac635"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d5b0da45-f393-4588-9448-81ba20f31b8c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d5dfe5ee-b906-4984-b5ee-8440d5a5bd31"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d6ccea7c-8f66-4036-b1e9-90c7ab744da0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d6ccf9c9-ae22-4f48-97bc-25d04a817717"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d78c6595-8d92-4528-9239-a6b5145938f3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d8c97b03-967e-4920-9eec-44021e911d09"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d8f84d1c-8721-41d0-80db-b1356989a3c8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d928fd01-2a6c-48c5-b71b-364c317d1aab"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dbcad264-5348-4a6d-903a-67bbea02c147"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dd03d510-cbdd-4b66-9cca-1c36457ecff3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dd608886-a83b-4fcf-8020-d7c478d6f090"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ddb32677-57e8-4b14-87b0-e63f671e668f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("df05966f-c1a9-4be4-83d3-01c6b6adec8c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("df144ffa-edf1-40ad-b193-11d19b7c31e7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e20db8a8-7fde-4d9b-a0f4-3a36c8c91445"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e236d89c-399b-4c1d-89e1-96e6473602ae"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e2dd03f5-15e0-45c5-bf95-e07d41705d5f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e3557751-b129-46bf-a2b2-a9a6f358bf49"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e50c5c81-7fab-49a0-a09e-3da874c62ccf"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e651d2bb-a497-4fdf-a604-6fb52cc1fb0c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e6d7f25c-a97b-494d-b3b1-e42f48b0333e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e6f19f16-5f90-4514-a16a-44596788df74"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e8fdd6d2-d58a-4307-bbb2-9b261a40dc73"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e9187d90-8f38-474e-95db-6aa392b62114"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ec30150a-5e5a-44b9-94b4-0f4f0c174078"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ee4f9f63-fea8-4cb0-90e8-b4a0d8e2e9f8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f0236f95-e9a9-45e6-ba23-4b6611f7b986"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f094fb0b-d75a-45c2-87fa-db3f126bdaa6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f1e997a4-d2ce-46d3-8ab8-0376211ef280"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f24d2952-efac-43c8-aead-84b642ce5973"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f406f393-d791-4817-9cdc-ccf5638b454a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f4afb1bf-8311-4618-afd5-cda9b3cae107"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f4ba0c45-a514-4d61-ae04-87a7ad1745a0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f4f4c88e-a07f-4761-b2aa-34de8d0d025e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f5068d9e-b235-412e-84a8-fcaa1f94c59b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f5f3797b-2a28-4c78-90df-abd6c14e93cc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f656e4e6-cf18-4a28-a98b-37f157a03ee4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f71f394a-56c6-404a-b888-56fead5caf24"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f8cacb32-db84-4b69-9d77-ba20a2ec2ae1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fac592cd-0938-431f-80de-a9bef0d9ea93"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fb313951-8e51-4652-bac3-80360b5b306d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fbdc814e-3ef8-42fa-94b2-2f9bdaf889ed"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fc6dd333-a976-4f9b-95f4-c15cfd748cde"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ffb87363-2f3f-4dd3-b239-1a38f8fb2bea"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("01172b87-e3f6-4f60-8f0b-313aab662c6a"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("0d124589-3f7b-46bc-b31c-d7e51aef4c4b"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("2e6e2044-d35e-4d6c-8d7b-00f6b1bb760a"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("2f5b57dc-3026-48a5-bd47-8fa5d5a5c6f1"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("4ae71910-0a47-4421-a12d-02b82b6bbcb7"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("4cfa9a62-69fd-4ae2-9c52-22819be6edb4"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("4ff29fa6-6c34-4a9f-92a4-073b6a8dfb8f"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("5e49d1a1-5f4b-4ea6-8476-994d32d042ef"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("65ce7390-b287-43b7-bf0a-408d6fdc1e43"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("6a8b6502-8f7f-4d41-b48a-b858bfb4b8e4"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("76a47836-06a2-4e9a-bd1f-68d0e59d6f67"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("872b38a4-d4a5-4bd1-b650-24b137ff7b26"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("93ac9a53-e0fc-4ff0-a15e-4455e2797cb3"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("94f4cfcd-98c6-4f76-b151-139aa420f6d5"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("9d54652e-9964-48d5-a4e5-933c21f064cc"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("a0c8c530-05ce-4b31-a167-378bb8c44754"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("a1c3f2d4-88f9-4ad9-9155-1e889b9c2b01"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("ae32c0db-ecfc-4975-a063-f2e13767451b"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("ae6e8c56-4d8a-4d97-8840-8036a30828d2"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("b13cdb17-7e7f-49c2-b25e-bf8c4d529ad4"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("b2e7a12c-6ac9-4f9e-963e-9b6d3825f962"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("b32b60a3-fd1d-4a56-9ce6-91cf994ef080"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("c6bfb1d0-cbde-4a7f-8ad1-62f7645d38a3"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("cd65a502-2c6f-4298-8e5e-7bb0fc12f350"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("d9b9ea69-355b-4c95-a0a5-9bcb1f7e5b70"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("dc6cc70b-dfd1-4ec9-b34d-3d0df51c3c83"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("df905248-bd83-474b-9b58-33e9f478b6cb"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("e3c9a2fb-c9ad-4176-b8dc-214008ea9821"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("f00f77a9-4042-49b3-8759-01c4bcba8e03"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("f4ac9a6e-0bd5-48b0-bbee-0343d7424694"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("fc6cc79b-dfd1-42c9-b35d-3d0df51c1c83"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("fd1149ea-6a2d-44b7-9ec4-0cd342a2ed17"));

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: new Guid("fe4db8a1-3cf2-43e3-981c-bbcde0b3e6db"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("3bb70e61-e370-48f0-b9b8-5c6d5104c6f5"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("4f9dd50a-9d98-4b27-bcb9-994e4dc6b221"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("5f7d0e8d-c2de-40d3-a1db-e3a5076d826e"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("79947df7-5e67-4d49-b776-02aaee1971e6"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("8b4e0c73-61d7-48cf-b6f0-d3ad1666f261"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("94e9c676-2e8f-4968-9c9a-0ff9f0ffba25"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("ac7a2f58-14c3-4b0b-a579-378edc6c5291"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("db5f8657-d4b5-4e7c-9267-f2d32bc8bb3e"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("f0a12f4c-e91e-40a5-a1f4-7f01a3a27101"));

            migrationBuilder.DeleteData(
                table: "TiposDocumento",
                keyColumn: "Id",
                keyValue: new Guid("f2b38e65-6313-4682-a27b-83c7b89ff8d2"));

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre", "RegionId" },
                values: new object[] { new Guid("44444444-4444-4444-4444-444444444444"), "Bogotá", new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Codigo", "Nombre", "PrefijoTelefonico" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), "CO", "Colombia", "+57" });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre", "PaisId" },
                values: new object[] { new Guid("22222222-2222-2222-2222-222222222222"), "Cundinamarca", new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.InsertData(
                table: "TiposDocumento",
                columns: new[] { "Id", "Abreviatura", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { new Guid("77777777-7777-7777-7777-777777777777"), "CC", "Cédula de Ciudadanía", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "TI", "Tarjeta de Identidad", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "CE", "Cédula de Extranjería", new Guid("11111111-1111-1111-1111-111111111111") }
                });
        }
    }
}
