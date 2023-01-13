using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsSelling.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Displacement = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BodyTypeId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    MakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_BodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "BodyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Makes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BodyTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hatchback" },
                    { 2, "Coupe" },
                    { 3, "Sedan" },
                    { 4, "SUV" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gasoline" },
                    { 2, "Diesel" },
                    { 3, "Bio-diesel" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Audi" },
                    { 2, "Citroen" },
                    { 3, "BMW" },
                    { 4, "Dacia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BodyTypeId",
                table: "Cars",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MakeId",
                table: "Cars",
                column: "MakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "BodyTypes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Makes");
        }
    }
}
