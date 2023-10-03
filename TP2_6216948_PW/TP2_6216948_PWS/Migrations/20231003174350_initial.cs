using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2_6216948_PWS.Migrations
{
    public partial class initial : Migration
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
                    { 1, "/Assets/Images/NHL.png", "Ligue Nationale de Hockey " },
                    { 2, "/Assets/Images/OHL.png", "Ligue de Hockey d'Ontario " },
                    { 3, "/Assets/Images/lhjmq.png", "Ligue de hockey junior majeur du Québec " }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saisons");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Arenas");

            migrationBuilder.DropTable(
                name: "DG");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
