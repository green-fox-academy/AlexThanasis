using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDOEF.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssigneeId",
                table: "ToDos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assignees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_AssigneeId",
                table: "ToDos",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Assignees_AssigneeId",
                table: "ToDos",
                column: "AssigneeId",
                principalTable: "Assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Assignees_AssigneeId",
                table: "ToDos");

            migrationBuilder.DropTable(
                name: "Assignees");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_AssigneeId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "ToDos");
        }
    }
}
