using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bc73fd5-fa38-4ffa-8b29-2efcab5fbde6"), "Medium" },
                    { new Guid("45dc3547-777d-4930-a95c-fb03dad3caea"), "Easy" },
                    { new Guid("80b4fc51-be6a-4483-a60d-eef1c1463803"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("29d14b93-c03e-43f7-b67b-877c2d2a9247"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("70f95d49-c54e-4e2b-832d-d9b1a32a7ce2"), "NTL", "Northland", null },
                    { new Guid("7cc11c09-aee2-443b-bd91-acfed260e5a8"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("841ada3e-f9ea-4b44-9add-8eb07d00022d"), "STL", "Southland", null },
                    { new Guid("a8d8cbb0-4a42-4828-bda7-52576aa29877"), "BOP", "Bay Of Plenty", null },
                    { new Guid("dd886cb3-3400-45e3-9538-d2a47d2ff0a3"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("0bc73fd5-fa38-4ffa-8b29-2efcab5fbde6"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("45dc3547-777d-4930-a95c-fb03dad3caea"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("80b4fc51-be6a-4483-a60d-eef1c1463803"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("29d14b93-c03e-43f7-b67b-877c2d2a9247"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("70f95d49-c54e-4e2b-832d-d9b1a32a7ce2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7cc11c09-aee2-443b-bd91-acfed260e5a8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("841ada3e-f9ea-4b44-9add-8eb07d00022d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a8d8cbb0-4a42-4828-bda7-52576aa29877"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd886cb3-3400-45e3-9538-d2a47d2ff0a3"));
        }
    }
}
