using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class updatekeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prohrams",
                table: "Prohrams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "userid",
                table: "Ratings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Prohrams",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "radioid",
                table: "Prohrams",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "commentid",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Ratings_stationid",
                table: "Ratings",
                column: "stationid");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Ratings_userid",
                table: "Ratings",
                column: "userid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prohrams",
                table: "Prohrams",
                column: "ProgramId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Prohrams_radioid",
                table: "Prohrams",
                column: "radioid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "commentid");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Comments_userid",
                table: "Comments",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Ratings_stationid",
                table: "Ratings");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Ratings_userid",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prohrams",
                table: "Prohrams");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Prohrams_radioid",
                table: "Prohrams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Comments_userid",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "userid",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "radioid",
                table: "Prohrams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Prohrams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "commentid",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prohrams",
                table: "Prohrams",
                column: "radioid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "userid");
        }
    }
}
