using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RYAN_sport.Migrations.SportDB
{
    public partial class SportDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    ContentAbout = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "AplicationtUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Birthday = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplicationtUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exercisePackages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    TitlePackage = table.Column<string>(nullable: true),
                    ContentPackage = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    datePackage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercisePackages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "galerys",
                columns: table => new
                {
                    GaleryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    SportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_galerys", x => x.GaleryID);
                });

            migrationBuilder.CreateTable(
                name: "HeaderImages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    SportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderImages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SportRooms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Hotline = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportRooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    SportRoomID = table.Column<long>(nullable: false),
                    SubjectsID = table.Column<long>(nullable: false),
                    SportRoomID1 = table.Column<int>(nullable: true),
                    SubjectsID1 = table.Column<int>(nullable: true),
                    AplicationtUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Levels_AplicationtUser_AplicationtUserId",
                        column: x => x.AplicationtUserId,
                        principalTable: "AplicationtUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Levels_SportRooms_SportRoomID1",
                        column: x => x.SportRoomID1,
                        principalTable: "SportRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Levels_Subjects_SubjectsID1",
                        column: x => x.SubjectsID1,
                        principalTable: "Subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberCard = table.Column<string>(nullable: true),
                    LevelID = table.Column<long>(nullable: false),
                    SubscriptionID = table.Column<long>(nullable: false),
                    AplicationtUserID = table.Column<long>(nullable: false),
                    LevelID1 = table.Column<int>(nullable: true),
                    SubscriptionID1 = table.Column<int>(nullable: true),
                    AplicationtUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cards_AplicationtUser_AplicationtUserId",
                        column: x => x.AplicationtUserId,
                        principalTable: "AplicationtUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_Levels_LevelID1",
                        column: x => x.LevelID1,
                        principalTable: "Levels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_subscriptions_SubscriptionID1",
                        column: x => x.SubscriptionID1,
                        principalTable: "subscriptions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_AplicationtUserId",
                table: "Cards",
                column: "AplicationtUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_LevelID1",
                table: "Cards",
                column: "LevelID1");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_SubscriptionID1",
                table: "Cards",
                column: "SubscriptionID1");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_AplicationtUserId",
                table: "Levels",
                column: "AplicationtUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_SportRoomID1",
                table: "Levels",
                column: "SportRoomID1");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_SubjectsID1",
                table: "Levels",
                column: "SubjectsID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "exercisePackages");

            migrationBuilder.DropTable(
                name: "galerys");

            migrationBuilder.DropTable(
                name: "HeaderImages");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "subscriptions");

            migrationBuilder.DropTable(
                name: "AplicationtUser");

            migrationBuilder.DropTable(
                name: "SportRooms");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
