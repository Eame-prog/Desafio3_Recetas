using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionRecetas.Migrations
{
    /// <inheritdoc />
    public partial class Roles_UserAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a62ede7-8beb-4a2e-b818-9c376b9690ef", null, "Administrador", "ADMINISTRADOR" },
                    { "f1e7d475-0ad5-40ae-bfb9-9ea47a6c4b82", null, "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ab3e9cda-d416-4857-a684-b1e9b9ca1dea", 0, "14776b9c-a0c3-4e71-8b18-223a2cc36c82", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIWjUylj3oMvUkgOnjX/eGXi1uL2QAJDSdgaPoK3zVndHQV8y4DPjsEuxNHmlBucGg==", null, false, "e1e08107-f2f1-42f6-b819-af5489ead0da", false, "admin@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a62ede7-8beb-4a2e-b818-9c376b9690ef", "ab3e9cda-d416-4857-a684-b1e9b9ca1dea" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1e7d475-0ad5-40ae-bfb9-9ea47a6c4b82");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a62ede7-8beb-4a2e-b818-9c376b9690ef", "ab3e9cda-d416-4857-a684-b1e9b9ca1dea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a62ede7-8beb-4a2e-b818-9c376b9690ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab3e9cda-d416-4857-a684-b1e9b9ca1dea");
        }
    }
}
