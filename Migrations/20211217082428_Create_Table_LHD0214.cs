using Microsoft.EntityFrameworkCore.Migrations;

namespace LeHaiDang214.Migrations
{
    public partial class Create_Table_LHD0214 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LHD0214s",
                columns: table => new
                {
                    LHDID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LHDName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LHDGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHD0214s", x => x.LHDID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LHD0214s");
        }
    }
}
