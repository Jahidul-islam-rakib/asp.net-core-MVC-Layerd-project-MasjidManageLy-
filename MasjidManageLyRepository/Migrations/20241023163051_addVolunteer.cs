using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasjidManageLyRepository.Migrations
{
    /// <inheritdoc />
    public partial class addVolunteer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
