using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectionStringApp.Migrations
{
    public partial class first_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"), new DateTime(2020, 8, 27, 16, 17, 41, 434, DateTimeKind.Local).AddTicks(1058), "Very Sporty", "Sport Cars" },
                    { new Guid("5ade63d4-abf0-4b09-b018-04c99d31f6e1"), new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7410), "Very Flying", "Aeroplane" },
                    { new Guid("8bc51e94-bb2f-4f69-bf12-b9b0826d0263"), new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7485), "Computer i guess", "Laptop" },
                    { new Guid("b5d459d0-d2e2-403a-b88b-f00fa5a192f9"), new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7494), "Use for making calls and what again?", "Smart Phone" },
                    { new Guid("8a6cd291-78d2-4468-bfc5-5c795ffc0c8e"), new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7499), "What is Jake? of course you know Jake", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("2292b9a7-d37d-49b9-bea9-67fdeb23eac8"), new Guid("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"), new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1096), "This is another fast car for racing, You mean Asphat 9? oh yeah", "Ferrari Koeniggseg" },
                    { new Guid("0b779d52-ee94-4870-8b61-6b4bc6ddb41c"), new Guid("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"), new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1159), "Its a very fast car, i think", "Lamboghini Vandetta" },
                    { new Guid("ef076389-b608-4d32-ac38-5f3c7c8dca32"), new Guid("8bc51e94-bb2f-4f69-bf12-b9b0826d0263"), new DateTime(2020, 8, 27, 16, 17, 41, 437, DateTimeKind.Local).AddTicks(9220), "Mac Book pro from Apple", "Macbook Pro 13" },
                    { new Guid("717ccd4e-da97-4631-881a-40eb624f6c51"), new Guid("b5d459d0-d2e2-403a-b88b-f00fa5a192f9"), new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1207), "Never heard of that smartphone, i guess its for alien", "Samsung Galaxy Mars X" },
                    { new Guid("9242e049-5d69-4cbc-a0c9-4664eb439749"), new Guid("8a6cd291-78d2-4468-bfc5-5c795ffc0c8e"), new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1214), "What is that exactly?", "JAKE SR71 Valkyrie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
