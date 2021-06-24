using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkPlaceOnTour.BACKEND.Migrations
{
    public partial class CreateUserProfiletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(maxLength: 50, nullable: false),
                    SubscriptionLevel = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProfiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "Id", "Subject", "SubscriptionLevel" },
                values: new object[] { new Guid("7f8ce18c-d156-4c85-9575-56bf59938b0c"), "85ec1977-8471-439f-956c-5b2d0672f31e", "User" });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "Id", "Subject", "SubscriptionLevel" },
                values: new object[] { new Guid("38ff72e7-834a-4f5d-a0d1-acfaffad05c2"), "b1be83d4-31a3-4e57-beb4-d9c4b5e8abda", "User" });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "Id", "Subject", "SubscriptionLevel" },
                values: new object[] { new Guid("d214f046-af8c-4c8b-8093-9a9c984f9b55"), "6cecd6ae-653a-42bd-bc7c-fd135c1aaddb", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProfiles");
        }
    }
}
