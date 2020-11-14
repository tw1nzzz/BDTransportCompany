using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BDTransportCompany.Migrations
{
    public partial class Sty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<long>(nullable: false),
                    Customer = table.Column<string>(nullable: true),
                    WhereFrom = table.Column<string>(nullable: true),
                    Where = table.Column<string>(nullable: true),
                    DateOfDeparture = table.Column<DateTime>(nullable: false),
                    DateOfArrival = table.Column<DateTime>(nullable: false),
                    CargoID = table.Column<long>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    RecordOfThePayment = table.Column<string>(nullable: true),
                    TheMarkOnTheReturn = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo_ID = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    TypesOfCargosID = table.Column<long>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    Features = table.Column<string>(nullable: true),
                    RoutesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cargos_Routes_RoutesID",
                        column: x => x.RoutesID,
                        principalTable: "Routes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Car_ID = table.Column<long>(nullable: false),
                    CarBrandID = table.Column<long>(nullable: false),
                    TypeOfCarID = table.Column<long>(nullable: false),
                    RegistrationNumber = table.Column<int>(nullable: false),
                    BodyNumber = table.Column<int>(nullable: false),
                    EngineNumber = table.Column<int>(nullable: false),
                    YearOfIssue = table.Column<DateTime>(nullable: false),
                    PositionID1 = table.Column<long>(nullable: false),
                    LastMaintenanceDate = table.Column<DateTime>(nullable: false),
                    PositionID2 = table.Column<long>(nullable: false),
                    RoutesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cars_Routes_RoutesID",
                        column: x => x.RoutesID,
                        principalTable: "Routes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfCargos",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypesOfCargos_ID = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    TypeOfCarID = table.Column<long>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CargosID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfCargos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypesOfCargos_Cargos_CargosID",
                        column: x => x.CargosID,
                        principalTable: "Cargos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarsBrands",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrand_ID = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Specifications = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CarsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsBrands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarsBrands_Cars_CarsID",
                        column: x => x.CarsID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_ID = table.Column<long>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PassportData = table.Column<string>(nullable: true),
                    PositionID = table.Column<long>(nullable: false),
                    CarsID = table.Column<long>(nullable: true),
                    CarsID1 = table.Column<long>(nullable: true),
                    RoutesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Cars_CarsID",
                        column: x => x.CarsID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Cars_CarsID1",
                        column: x => x.CarsID1,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Routes_RoutesID",
                        column: x => x.RoutesID,
                        principalTable: "Routes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfCars",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeofCar_ID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CarsID = table.Column<long>(nullable: true),
                    TypesOfCargosID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfCars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypesOfCars_Cars_CarsID",
                        column: x => x.CarsID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypesOfCars_TypesOfCargos_TypesOfCargosID",
                        column: x => x.TypesOfCargosID,
                        principalTable: "TypesOfCargos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position_ID = table.Column<long>(nullable: false),
                    JobTitle = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Responsibilities = table.Column<string>(nullable: true),
                    Demands = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positions_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_RoutesID",
                table: "Cargos",
                column: "RoutesID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RoutesID",
                table: "Cars",
                column: "RoutesID");

            migrationBuilder.CreateIndex(
                name: "IX_CarsBrands_CarsID",
                table: "CarsBrands",
                column: "CarsID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_StaffID",
                table: "Positions",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CarsID",
                table: "Staff",
                column: "CarsID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CarsID1",
                table: "Staff",
                column: "CarsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoutesID",
                table: "Staff",
                column: "RoutesID");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfCargos_CargosID",
                table: "TypesOfCargos",
                column: "CargosID");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfCars_CarsID",
                table: "TypesOfCars",
                column: "CarsID");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfCars_TypesOfCargosID",
                table: "TypesOfCars",
                column: "TypesOfCargosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsBrands");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "TypesOfCars");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "TypesOfCargos");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
