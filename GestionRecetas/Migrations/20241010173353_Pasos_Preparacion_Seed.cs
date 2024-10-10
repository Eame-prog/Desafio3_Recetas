using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionRecetas.Migrations
{
    /// <inheritdoc />
    public partial class Pasos_Preparacion_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26f88d37-58ca-4f74-899e-6116ffdcf8c5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "524517c6-f953-4f58-90b4-cda7b49f5c76", "31d672a1-86a4-48b8-8f21-21df672b690b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524517c6-f953-4f58-90b4-cda7b49f5c76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d672a1-86a4-48b8-8f21-21df672b690b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "371807ac-5c48-40b9-acef-d60a79714d2e", null, "Usuario", "USUARIO" },
                    { "f92f5a1b-2ff5-4789-b153-5a6182aa223c", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8f911d2-89ab-41bb-a248-5af8d3b1cb05", 0, "9995eeda-c316-4f00-90e3-78767b2345ca", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAENpEjGUkPU8PSJcMStfDDCROFqd3u6eFJxNH6Bt8Dog1qOtAI9VVUX+ZhBTcq9i/GQ==", null, false, "43913634-8e07-47a2-ba9a-b4353e160167", false, "admin@hotmail.com" });

            migrationBuilder.InsertData(
                table: "PasosPreparaciones",
                columns: new[] { "ID", "Descripcion", "Orden", "RecetaId" },
                values: new object[,]
                {
                    { 1, "Lavar la lechuga romana y cortarla en trozos", 1, 1 },
                    { 2, "Asar el pollo a la parrilla y cortarlo en tiras", 2, 1 },
                    { 3, "Mezclar la lechuga, el pollo y el aderezo césar", 3, 1 },
                    { 4, "Cocinar la pasta en agua hirvindo con sal", 1, 2 },
                    { 5, "Mezclar el huevo, la crema y el queso parmesano", 2, 2 },
                    { 6, "Añadir la mezcla a la pasta caliente", 3, 2 },
                    { 7, "Cortar los tomates y hervirlos hasta que se ablanden", 1, 3 },
                    { 8, "Licuar los tomates y agregar la albahaca", 2, 3 },
                    { 9, "Cocinar por 10 minutos más y servir caliente", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f92f5a1b-2ff5-4789-b153-5a6182aa223c", "b8f911d2-89ab-41bb-a248-5af8d3b1cb05" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "371807ac-5c48-40b9-acef-d60a79714d2e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f92f5a1b-2ff5-4789-b153-5a6182aa223c", "b8f911d2-89ab-41bb-a248-5af8d3b1cb05" });

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PasosPreparaciones",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f92f5a1b-2ff5-4789-b153-5a6182aa223c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8f911d2-89ab-41bb-a248-5af8d3b1cb05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26f88d37-58ca-4f74-899e-6116ffdcf8c5", null, "Usuario", "USUARIO" },
                    { "524517c6-f953-4f58-90b4-cda7b49f5c76", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "31d672a1-86a4-48b8-8f21-21df672b690b", 0, "f360b70e-4672-4f2b-ab07-d6fdeffabf0c", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAENK7yDu60lRotrmM5US4xEnhCUyDkx2c5BdrGhagNlFL5CgusxIOUe/y43dn81Zm9Q==", null, false, "5e6685c7-a30b-4eb5-9d71-33da18588ba0", false, "admin@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "524517c6-f953-4f58-90b4-cda7b49f5c76", "31d672a1-86a4-48b8-8f21-21df672b690b" });
        }
    }
}
