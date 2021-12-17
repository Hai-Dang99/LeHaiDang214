using Microsoft.EntityFrameworkCore.Migrations;

namespace LeHaiDang214.Migrations
{
    public partial class Create_Table_UniversityLHD214s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityLHD214s",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityLHD214s", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityLHD214s");
        }
    }
}
