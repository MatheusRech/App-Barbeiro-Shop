using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rech.Barbeiro.Shop.Database.Migrations
{
    /// <inheritdoc />
    public partial class RolesUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("19ba23e3-b4f1-4220-a884-090599dae20c"), null, "AdministradorPicaDasGalaxias", "ADMINISTRADORPICADASGALAXIAS" },
                    { new Guid("3fe18c63-baa1-4bcb-815a-fd62821e5207"), null, "Cliente", "CLIENTE" },
                    { new Guid("ae4fedf9-0e99-46e6-b9ae-3843eb83ed99"), null, "Barbearia", "BARBEARIA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("19ba23e3-b4f1-4220-a884-090599dae20c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3fe18c63-baa1-4bcb-815a-fd62821e5207"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae4fedf9-0e99-46e6-b9ae-3843eb83ed99"));
        }
    }
}
