using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2_6216948_PWS.Migrations
{
    public partial class tout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arenas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arenas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Villagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saisons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saisons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saisons_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commanditaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeagueId = table.Column<int>(type: "int", nullable: false),
                    ArenaID = table.Column<int>(type: "int", nullable: false),
                    DGId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Arenas_ArenaID",
                        column: x => x.ArenaID,
                        principalTable: "Arenas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_DG_DGId",
                        column: x => x.DGId,
                        principalTable: "DG",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVillager",
                columns: table => new
                {
                    UsersFriendsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VillagersFriendsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVillager", x => new { x.UsersFriendsId, x.VillagersFriendsId });
                    table.ForeignKey(
                        name: "FK_UserVillager_AspNetUsers_UsersFriendsId",
                        column: x => x.UsersFriendsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVillager_Villagers_VillagersFriendsId",
                        column: x => x.VillagersFriendsId,
                        principalTable: "Villagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Arenas",
                columns: new[] { "Id", "Name", "Pays", "Ville" },
                values: new object[,]
                {
                    { 1, "Centre Bell", "Canada", "Montréal" },
                    { 2, "Capital One Arena", "United-States", "Washington D.C." },
                    { 3, "PPG Paints Arena", "United-States", "Pittsburgh" },
                    { 4, "Madison Square Garden", "United-States", "New-York" },
                    { 5, "TD Garden", "United-States", "Boston" },
                    { 6, "Budweiser Gardens", "Canada", "London" },
                    { 7, "WFCU Centre", "Canada", "Windsor" },
                    { 8, "TD Place Arena", "Canada", "Ottawa" },
                    { 9, "Leon's Centre", "Canada", "Kingston" },
                    { 10, "Sudbury Community Arena", "Canada", "Sudbury" },
                    { 11, "Scotiabank Centre", "Canada", "Halifax" },
                    { 12, "Colisée Financière Sun Life", "Canada", "Rimouski" },
                    { 13, "Centre Henry-Leonard", "Canada", "Baie-Comeau" }
                });

            migrationBuilder.InsertData(
                table: "DG",
                columns: new[] { "ID", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 51, "Patrice Belanger" },
                    { 2, 45, "Jean Tremblay" },
                    { 3, 39, "Sophie Martin" },
                    { 4, 56, "Louis Dubois" },
                    { 5, 48, "Marie-Claude Leblanc" },
                    { 6, 43, "Éric Desjardins" },
                    { 7, 47, "Lucie Gagnon" },
                    { 8, 52, "Michel Lefebvre" },
                    { 9, 41, "Isabelle Tremblay" },
                    { 10, 48, "Pierre Dupont" },
                    { 11, 44, "Catherine Bergeron" },
                    { 12, 50, "Martin Gauthier" },
                    { 13, 46, "Nathalie Roy" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "nhl.png", "Ligue Nationale de Hockey " },
                    { 2, "OHL.jpg", "Ligue de Hockey d'Ontario " },
                    { 3, "lhjmq.png", "Ligue de hockey junior majeur du Québec " },
                    { 4, "photoinexistante.png", "Ligue de hockey sans equipes" }
                });

            migrationBuilder.InsertData(
                table: "Saisons",
                columns: new[] { "Id", "Annee", "DateDebut", "DateFin", "LeagueId" },
                values: new object[,]
                {
                    { 1, 0, "2019-10-24", "2020-04-10", 1 },
                    { 2, 0, "2020-10-24", "2021-04-10", 1 },
                    { 3, 0, "2021-10-24", "2022-04-10", 1 },
                    { 4, 0, "2018-10-24", "2019-04-10", 2 },
                    { 5, 0, "2019-10-24", "2020-04-10", 2 },
                    { 6, 0, "2020-10-24", "2021-04-10", 2 },
                    { 7, 0, "2018-10-24", "2019-04-10", 3 },
                    { 8, 0, "2019-10-24", "2020-04-10", 3 },
                    { 9, 0, "2020-10-24", "2021-04-10", 3 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ArenaID", "Commanditaire", "DGId", "LeagueId", "Name", "Ville" },
                values: new object[,]
                {
                    { 1, 1, "Reebok", 1, 1, "Canadiens", "Montréal" },
                    { 2, 2, "Adidas", 2, 1, "Capitals", "Washington" },
                    { 3, 3, "Lululemon", 3, 1, "Penguins", "Pittsburgh" },
                    { 4, 4, "Adidas", 4, 1, "Rangers", "New-York" },
                    { 5, 5, "Reebok", 5, 1, "Bruins", "Boston" },
                    { 6, 6, "Hector's Shack", 6, 2, "Knights", "London" },
                    { 7, 7, "Le shack a Junior", 7, 2, "Spitfires", "Windsor" },
                    { 8, 8, "Le shack a Roland", 8, 2, "67's", "Ottawa" },
                    { 9, 9, "The good Restaurant", 9, 2, "Frontenacs", "Kingston " },
                    { 10, 10, "The bad Restaurant", 10, 2, "Wolves", "Sudbury  " },
                    { 11, 11, "The average Restaurant", 11, 3, "Mooseheads", "Halifax   " },
                    { 12, 12, "Sports aux puces", 12, 3, "Océanic", "Rimouski" },
                    { 13, 13, "Sports aux poux", 13, 3, "Drakkar", " Baie-Comeau" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Saisons_LeagueId",
                table: "Saisons",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ArenaID",
                table: "Teams",
                column: "ArenaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_DGId",
                table: "Teams",
                column: "DGId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVillager_VillagersFriendsId",
                table: "UserVillager",
                column: "VillagersFriendsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Saisons");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "UserVillager");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Arenas");

            migrationBuilder.DropTable(
                name: "DG");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Villagers");
        }
    }
}
