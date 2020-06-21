using Microsoft.EntityFrameworkCore.Migrations;

namespace E_LearningSolution.Migrations
{
    public partial class addedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ELearningTable",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    CourseCode = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    HoursPerDay = table.Column<string>(nullable: true),
                    Prerequisites = table.Column<string>(nullable: true),
                    CourseMaterial = table.Column<string>(nullable: true),
                    Fee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELearningTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ELearningTable");
        }
    }
}
