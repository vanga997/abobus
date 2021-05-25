using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarriageAgencyWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "INT", nullable: false),
                    NationalityName = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Comments = table.Column<string>(type: "NVARCHAR (255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "INT", nullable: false),
                    PositionName = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Salary = table.Column<int>(type: "INT", nullable: false),
                    Responsibility = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Requirements = table.Column<string>(type: "NVARCHAR (255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    RelationId = table.Column<int>(type: "INT", nullable: false),
                    RelationName = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR (255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.RelationId);
                });

            migrationBuilder.CreateTable(
                name: "ZodiacSign",
                columns: table => new
                {
                    ZodiacId = table.Column<int>(type: "INT", nullable: false),
                    ZodiacName = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR (255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZodiacSign", x => x.ZodiacId);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    WorkerId = table.Column<int>(type: "INT", nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Gender = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Age = table.Column<int>(type: "INT", nullable: false),
                    Passport = table.Column<int>(type: "INT", nullable: false),
                    Phone = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    PositionId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_Worker_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "INT", nullable: false),
                    Date = table.Column<DateTime>(type: "DATE", nullable: false),
                    Cost = table.Column<int>(type: "INT", nullable: false),
                    WorkerId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_Worker_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Worker",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "INT", nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Gender = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Age = table.Column<int>(type: "INT", nullable: false),
                    Birthday = table.Column<DateTime>(type: "DATE", nullable: false),
                    Passport = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Height = table.Column<int>(type: "INT", nullable: false),
                    Weight = table.Column<int>(type: "INT", nullable: false),
                    FamilyStatus = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    InfoAboutPartner = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    NumberOfChild = table.Column<int>(type: "INT", nullable: false),
                    BadHabbits = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Hobbies = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR (255)", nullable: false),
                    ServiceId = table.Column<int>(type: "INT", nullable: false),
                    NationalityId = table.Column<int>(type: "INT", nullable: false),
                    ZodiacId = table.Column<int>(type: "INT", nullable: false),
                    RelationId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Client_Nationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Relation_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relation",
                        principalColumn: "RelationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_NationalityId",
                table: "Client",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RelationId",
                table: "Client",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ServiceId",
                table: "Client",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_WorkerId",
                table: "Service",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_PositionId",
                table: "Worker",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ZodiacSign");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Relation");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
