using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.Logger
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExceptionDetails",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExceptionMessage = table.Column<string>(type: "TEXT", nullable: true),
                    ControllerName = table.Column<string>(type: "TEXT", nullable: true),
                    ActionName = table.Column<string>(type: "TEXT", nullable: true),
                    StackTrace = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionDetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExceptionDetails");
        }
    }
}
