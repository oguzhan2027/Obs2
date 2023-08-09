using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    public partial class migq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fakultes",
                columns: table => new
                {
                    FakulteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakulteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultes", x => x.FakulteID);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmens",
                columns: table => new
                {
                    OgretmenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenAdres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmens", x => x.OgretmenID);
                });

            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FakulteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.BolumID);
                    table.ForeignKey(
                        name: "FK_Bolums_Fakultes_FakulteID",
                        column: x => x.FakulteID,
                        principalTable: "Fakultes",
                        principalColumn: "FakulteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Derses",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenID = table.Column<int>(type: "int", nullable: false),
                    BolumID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derses", x => x.DersID);
                    table.ForeignKey(
                        name: "FK_Derses_Bolums_BolumID",
                        column: x => x.BolumID,
                        principalTable: "Bolums",
                        principalColumn: "BolumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Derses_Ogretmens_OgretmenID",
                        column: x => x.OgretmenID,
                        principalTable: "Ogretmens",
                        principalColumn: "OgretmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciID);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_BolumID",
                        column: x => x.BolumID,
                        principalTable: "Bolums",
                        principalColumn: "BolumID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersListesi",
                columns: table => new
                {
                    DersListesiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersListesi", x => x.DersListesiID);
                    table.ForeignKey(
                        name: "FK_DersListesi_Derses_DersID",
                        column: x => x.DersID,
                        principalTable: "Derses",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersListesi_Ogrencis_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginRole = table.Column<bool>(type: "bit", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false),
                    OgretmenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginID);
                    table.ForeignKey(
                        name: "FK_Logins_Ogrencis_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logins_Ogretmens_OgretmenID",
                        column: x => x.OgretmenID,
                        principalTable: "Ogretmens",
                        principalColumn: "OgretmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devamsızlıks",
                columns: table => new
                {
                    DevamsızlıkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevamsızlıkDurumu = table.Column<bool>(type: "bit", nullable: false),
                    DersListesiID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devamsızlıks", x => x.DevamsızlıkID);
                    table.ForeignKey(
                        name: "FK_Devamsızlıks_DersListesi_DersListesiID",
                        column: x => x.DersListesiID,
                        principalTable: "DersListesi",
                        principalColumn: "DersListesiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devamsızlıks_Ogrencis_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Nots",
                columns: table => new
                {
                    NotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VizeNotu = table.Column<int>(type: "int", nullable: false),
                    FinalNotu = table.Column<int>(type: "int", nullable: false),
                    Ortalama = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DersListesiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nots", x => x.NotID);
                    table.ForeignKey(
                        name: "FK_Nots_DersListesi_DersListesiID",
                        column: x => x.DersListesiID,
                        principalTable: "DersListesi",
                        principalColumn: "DersListesiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolums_FakulteID",
                table: "Bolums",
                column: "FakulteID");

            migrationBuilder.CreateIndex(
                name: "IX_Derses_BolumID",
                table: "Derses",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_Derses_OgretmenID",
                table: "Derses",
                column: "OgretmenID");

            migrationBuilder.CreateIndex(
                name: "IX_DersListesi_DersID",
                table: "DersListesi",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_DersListesi_OgrenciID",
                table: "DersListesi",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Devamsızlıks_DersListesiID",
                table: "Devamsızlıks",
                column: "DersListesiID");

            migrationBuilder.CreateIndex(
                name: "IX_Devamsızlıks_OgrenciID",
                table: "Devamsızlıks",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_OgrenciID",
                table: "Logins",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_OgretmenID",
                table: "Logins",
                column: "OgretmenID");

            migrationBuilder.CreateIndex(
                name: "IX_Nots_DersListesiID",
                table: "Nots",
                column: "DersListesiID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_BolumID",
                table: "Ogrencis",
                column: "BolumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devamsızlıks");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Nots");

            migrationBuilder.DropTable(
                name: "DersListesi");

            migrationBuilder.DropTable(
                name: "Derses");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ogretmens");

            migrationBuilder.DropTable(
                name: "Bolums");

            migrationBuilder.DropTable(
                name: "Fakultes");
        }
    }
}
