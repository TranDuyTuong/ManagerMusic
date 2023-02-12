using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameFile",
                table: "FilePlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 200, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 200, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 195, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f530331d-f09b-4cb1-a980-e422f36127fc", new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "555433e7-8638-422e-a7d4-504a24945e06", new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "54b08cb2-a715-4bea-828c-a6904f3e3227", new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 197, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 198, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 199, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 6, 21, 19, 16, 200, DateTimeKind.Utc).AddTicks(371));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameFile",
                table: "FilePlans");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 842, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 842, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 838, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 839, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "d80d3126-7c31-4146-a475-bb3f8073b8d2", new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "2b66f7ad-5c84-424b-aaa7-23af8f7d6541", new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "b5067bda-c5e9-4e88-b66c-c91bb6b8a64e", new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 840, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 5, 14, 42, 39, 841, DateTimeKind.Utc).AddTicks(9857));
        }
    }
}
