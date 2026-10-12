using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4_seminars.Migrations
{
    /// <inheritdoc />
    public partial class SetupDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarMakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Modelyear = table.Column<string>(type: "TEXT", nullable: false),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ElectricVehicleType = table.Column<string>(type: "TEXT", nullable: false),
                    CAFV = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    County = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    VIN = table.Column<string>(type: "TEXT", nullable: false),
                    ElectricRange = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseMSRP = table.Column<int>(type: "INTEGER", nullable: false),
                    LegislativeDistrict = table.Column<int>(type: "INTEGER", nullable: false),
                    DOLVehicleID = table.Column<int>(type: "INTEGER", nullable: false),
                    VehicleLocation = table.Column<string>(type: "TEXT", nullable: false),
                    ElectricUtility = table.Column<string>(type: "TEXT", nullable: false),
                    CT2020 = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    CarMakeId = table.Column<int>(type: "INTEGER", nullable: false),
                    FuelTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.VIN);
                    table.ForeignKey(
                        name: "FK_Cars_CarMakes_CarMakeId",
                        column: x => x.CarMakeId,
                        principalTable: "CarMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarMakeId",
                table: "Cars",
                column: "CarMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LocationId",
                table: "Cars",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarMakes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
