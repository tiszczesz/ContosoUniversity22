using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity22.Migrations
{
    public partial class firstChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "CurseID",
                table: "Enrollment");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "FirstMidName");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrollment",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment");

            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "FirstName");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrollment",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CurseID",
                table: "Enrollment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
