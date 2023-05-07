using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into restaurants (Name, Location, Rating) values ('Ratatouillie','HM-Phase-1','Quite Nice!')");
            migrationBuilder.Sql("insert into restaurants (Name, Location, Rating) values ('Sea House','Male','The Pasta was nice')");
            migrationBuilder.Sql("insert into restaurants (Name, Location, Rating) values ('KFC','HM-Phase-1','They have the best chicken!')");
            migrationBuilder.Sql("insert into restaurants (Name, Location, Rating) values ('Dain Tree','HM-Phase-2','Great for the price')");
            migrationBuilder.Sql("insert into restaurants (Name, Location, Rating) values ('Lemongrass','Male','Fastest delivery, and quite cheap with great food')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
