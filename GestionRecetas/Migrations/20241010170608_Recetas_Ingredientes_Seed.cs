using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionRecetas.Migrations
{
    /// <inheritdoc />
    public partial class Recetas_Ingredientes_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10eed190-8f05-4a24-b674-3a407fd8d1d2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "151f3cc7-45d0-4755-892a-d83a279cdd1a", "9c2c1aa1-b86a-4462-b83f-9eb84562f740" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "151f3cc7-45d0-4755-892a-d83a279cdd1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c2c1aa1-b86a-4462-b83f-9eb84562f740");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05ef5a82-534b-47de-b0ee-f4ce4d93d31d", null, "Usuario", "USUARIO" },
                    { "e2e0fe16-1de1-4f5f-9759-d51f0b89b8ed", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ecf5457-f480-4345-83c8-750ec345b975", 0, "6a83fd59-825f-47af-972b-e159dcc3451b", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAENXbu72BS5koDskH4Kht18DdLZy0rTQyW+gqK4IfBar2C1hwBYLIx0QvHYVGMUxm/w==", null, false, "97a60554-29ed-4091-80a0-a2574bfa4ffa", false, "admin@hotmail.com" });

            migrationBuilder.InsertData(
                table: "Recetas",
                columns: new[] { "ID", "DescripcionReceta", "NombreReceta", "TiempoReceta" },
                values: new object[,]
                {
                    { 1, "Ensalada clásica con pollo, lechuga y aderezo César", "Ensalada César", "20 minutos" },
                    { 2, "Pasta con salsa de crema, huevo y queso parmesano", "Pasta Carbonara", "30 minutos" },
                    { 3, "Sopa ligera de tomate con albahaca", "Sopa de Tomate", "40 minutos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2e0fe16-1de1-4f5f-9759-d51f0b89b8ed", "2ecf5457-f480-4345-83c8-750ec345b975" });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "ID", "Cantidad", "NombreIngrediente", "RecetaId", "Unidad" },
                values: new object[,]
                {
                    { 1, "1", "Lechuga romana", 1, "Unidad" },
                    { 2, "200", "Pollo a la parrilla", 1, "Gramos" },
                    { 3, "50", "Aderezo César", 1, "Mililitros" },
                    { 4, "250", "Pasta espagheti", 2, "Gramos" },
                    { 5, "100", "Crema de leche", 2, "Mililitros" },
                    { 6, "1", "Huevo", 2, "Unidad" },
                    { 7, "50", "Queso parmesano", 2, "Gramos" },
                    { 8, "500", "Tomates frescos", 3, "Gramos" },
                    { 9, "5", "Albahaca", 3, "Hojas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05ef5a82-534b-47de-b0ee-f4ce4d93d31d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2e0fe16-1de1-4f5f-9759-d51f0b89b8ed", "2ecf5457-f480-4345-83c8-750ec345b975" });

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredientes",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e0fe16-1de1-4f5f-9759-d51f0b89b8ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ecf5457-f480-4345-83c8-750ec345b975");

            migrationBuilder.DeleteData(
                table: "Recetas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recetas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recetas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10eed190-8f05-4a24-b674-3a407fd8d1d2", null, "Usuario", "USUARIO" },
                    { "151f3cc7-45d0-4755-892a-d83a279cdd1a", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c2c1aa1-b86a-4462-b83f-9eb84562f740", 0, "f4141e7b-89d1-4ea0-abde-2562d818670b", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDi+gWRW2diy+UNNV7r3az0NWmqHVyJCVxGYBSN9/1cpPRgKD8+fb6CNKIO3V2eKPw==", null, false, "d17091f8-8b56-4305-9d74-9b6e152d8ff3", false, "admin@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "151f3cc7-45d0-4755-892a-d83a279cdd1a", "9c2c1aa1-b86a-4462-b83f-9eb84562f740" });
        }
    }
}
