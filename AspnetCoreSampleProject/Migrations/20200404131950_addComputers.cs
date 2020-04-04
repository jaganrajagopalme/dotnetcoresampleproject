using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetCoreSampleProject.Migrations
{
    public partial class addComputers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    serialNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerName = table.Column<string>(nullable: false),
                    CategoryType = table.Column<string>(nullable: false),
                    InstanceType = table.Column<string>(nullable: false),
                    OsName = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.serialNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
