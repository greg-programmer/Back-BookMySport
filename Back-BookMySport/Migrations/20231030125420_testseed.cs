using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Back_BookMySport.Migrations
{
    /// <inheritdoc />
    public partial class testseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Description", "FinishTime", "GymId", "ImagePath", "MaxBooking", "Name", "SportCategoryId", "StartTime" },
                values: new object[,]
                {
                    { 14, "Séance de Boxe", new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 10h à 11h", 4, new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Séance de Boxe", new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 11h à 12h", 4, new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Séance de Boxe", new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 12h à 13h", 4, new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Séance de Boxe", new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 13h à 14h", 4, new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Séance de Boxe", new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 14h à 15h", 4, new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Séance de Boxe", new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 15h à 16h", 4, new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Séance de Boxe", new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 16h à 17h", 4, new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Séance de Boxe", new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 17h à 18h", 4, new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Séance de Boxe", new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 18h à 19h", 4, new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Séance de Boxe", new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 19h à 20h", 4, new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Séance de Boxe", new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 20h à 21h", 4, new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Séance de Boxe", new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 21h à 22h", 4, new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Séance de Boxe", new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), 1, "", 3, "Séance de 22h à 23h", 4, new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Séance de fitness", new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 10h à 11h", 1, new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Séance de fitness", new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 11h à 12h", 1, new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Séance de fitness", new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 12h à 13h", 1, new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Séance de fitness", new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 13h à 14h", 1, new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Séance de fitness", new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 14h à 15h", 1, new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Séance de fitness", new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 15h à 16h", 1, new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Séance de fitness", new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 16h à 17h", 1, new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Séance de fitness", new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 17h à 18h", 1, new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Séance de fitness", new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 18h à 19h", 1, new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Séance de fitness", new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 19h à 20h", 1, new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Séance de fitness", new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 20h à 21h", 1, new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Séance de fitness", new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 21h à 22h", 1, new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Séance de fitness", new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 3, "Séance de 22h à 23h", 1, new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Séance de football", new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 10h à 11h", 3, new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Séance de football", new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 11h à 12h", 3, new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Séance de football", new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 12h à 13h", 3, new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Séance de football", new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 13h à 14h", 3, new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Séance de football", new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 14h à 15h", 3, new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Séance de football", new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 15h à 16h", 3, new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Séance de football", new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 16h à 17h", 3, new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Séance de football", new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 17h à 18h", 3, new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Séance de football", new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 18h à 19h", 3, new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Séance de football", new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 19h à 20h", 3, new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Séance de football", new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 20h à 21h", 3, new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, "Séance de football", new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 21h à 22h", 3, new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "Séance de football", new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 22h à 23h", 3, new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, "Séance de basketball", new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 10h à 11h", 2, new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, "Séance de basketball", new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 11h à 12h", 2, new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "Séance de basketball", new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 12h à 13h", 2, new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, "Séance de basketball", new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 13h à 14h", 2, new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, "Séance de basketball", new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 14h à 15h", 2, new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, "Séance de basketball", new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 15h à 16h", 2, new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, "Séance de basketball", new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 16h à 17h", 2, new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, "Séance de basketball", new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 17h à 18h", 2, new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, "Séance de basketball", new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 18h à 19h", 2, new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, "Séance de basketball", new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 19h à 20h", 2, new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, "Séance de basketball", new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 20h à 21h", 2, new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, "Séance de basketball", new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 21h à 22h", 2, new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, "Séance de basketball", new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 22h à 23h", 2, new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, "Séance de basketball", new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 10h à 11h", 5, new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, "Séance de basketball", new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 11h à 12h", 5, new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, "Séance de basketball", new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 12h à 13h", 5, new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, "Séance de basketball", new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 13h à 14h", 5, new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, "Séance de basketball", new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 14h à 15h", 5, new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, "Séance de basketball", new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 15h à 16h", 5, new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, "Séance de basketball", new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 16h à 17h", 5, new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, "Séance de basketball", new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 17h à 18h", 5, new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, "Séance de basketball", new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 18h à 19h", 5, new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, "Séance de basketball", new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 19h à 20h", 5, new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, "Séance de basketball", new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 20h à 21h", 5, new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, "Séance de basketball", new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 21h à 22h", 5, new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, "Séance de basketball", new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), 3, "", 10, "Séance de 22h à 23h", 5, new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, "Séance de football", new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 10h à 11h", 3, new DateTime(2023, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, "Séance de football", new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 11h à 12h", 3, new DateTime(2023, 10, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, "Séance de football", new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 12h à 13h", 3, new DateTime(2023, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, "Séance de football", new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 13h à 14h", 3, new DateTime(2023, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, "Séance de football", new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 14h à 15h", 3, new DateTime(2023, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, "Séance de football", new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 15h à 16h", 3, new DateTime(2023, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, "Séance de football", new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 16h à 17h", 3, new DateTime(2023, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, "Séance de football", new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 17h à 18h", 3, new DateTime(2023, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, "Séance de football", new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 18h à 19h", 3, new DateTime(2023, 10, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, "Séance de football", new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 19h à 20h", 3, new DateTime(2023, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, "Séance de football", new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 20h à 21h", 3, new DateTime(2023, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, "Séance de football", new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 21h à 22h", 3, new DateTime(2023, 10, 30, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, "Séance de football", new DateTime(2023, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), 4, "", 10, "Séance de 22h à 23h", 3, new DateTime(2023, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 21, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 22, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
