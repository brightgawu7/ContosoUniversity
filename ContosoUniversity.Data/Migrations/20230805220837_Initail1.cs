using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContosoUniversity.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initail1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrollmentID",
                table: "Enrollment",
                newName: "EnrollmentId");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Credits", "Title" },
                values: new object[,]
                {
                    { 1, 3, "Chemistry" },
                    { 2, 3, "Microeconomics" },
                    { 3, 3, "Macroeconomics" },
                    { 4, 4, "Calculus" },
                    { 5, 4, "Trigonometry" },
                    { 6, 3, "Composition" },
                    { 7, 4, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carson", "Alexander" },
                    { 2, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meredith", "Alonso" },
                    { 3, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arturo", "Anand" },
                    { 4, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gytis", "Barzdukas" },
                    { 5, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yan", "Li" },
                    { 6, new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", "Justice" },
                    { 7, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Norman" },
                    { 8, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nino", "Olivetto" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 3, 1 },
                    { 3, 3, 2, 1 },
                    { 4, 4, 2, 2 },
                    { 5, 5, 4, 2 },
                    { 6, 6, 4, 2 },
                    { 7, 1, null, 3 },
                    { 8, 1, null, 4 },
                    { 9, 2, 4, 4 },
                    { 10, 3, 3, 5 },
                    { 11, 4, null, 6 },
                    { 12, 7, 1, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "EnrollmentId",
                table: "Enrollment",
                newName: "EnrollmentID");
        }
    }
}
