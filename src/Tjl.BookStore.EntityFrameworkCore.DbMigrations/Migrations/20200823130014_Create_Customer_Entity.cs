using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tjl.BookStore.Migrations
{
    public partial class Create_Customer_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ConnStringName = table.Column<string>(maxLength: 500, nullable: false),
                    Ket = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCustomers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCustomers");
        }
    }
}
