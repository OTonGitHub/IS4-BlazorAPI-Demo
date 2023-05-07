using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantTableColRenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Restaurants",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Restaurants",
                newName: "Location");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Restaurants",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Restaurants",
                newName: "location");
        }
    }
}
