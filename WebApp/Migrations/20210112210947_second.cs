using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b9ecee4-130b-4d18-832f-5eb5538bb5ec", "18454caf-1e49-4efd-b53d-08a8aa074995", "Administrators", "ADMINISTRATORS" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c592222-5e1c-4556-836a-28ef89164027", 0, "0a2c016f-fd94-4b5c-8fc0-aa61e2ecabab", "ivanoff@i.ua", true, false, null, "IVANOFF@I.UA", "IVANOFF@I.UA", "AQAAAAEAACcQAAAAEJpIGeU8Raa9V3+FqO27qk4oRPnlrtd6NC1qP2MDJDguOZMu+qR3s5y4AAmJ3txDmg==", null, false, "KMTW3BACEMSXRX3TNCHPBHM3TDDH6UWU", false, "ivanoff@i.ua" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8b9ecee4-130b-4d18-832f-5eb5538bb5ec", "7c592222-5e1c-4556-836a-28ef89164027" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b9ecee4-130b-4d18-832f-5eb5538bb5ec", "7c592222-5e1c-4556-836a-28ef89164027" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b9ecee4-130b-4d18-832f-5eb5538bb5ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c592222-5e1c-4556-836a-28ef89164027");
        }
    }
}
