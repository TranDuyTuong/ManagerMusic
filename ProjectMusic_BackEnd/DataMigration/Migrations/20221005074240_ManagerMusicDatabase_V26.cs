using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StatusView",
                table: "NotificationPlans",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusView",
                table: "NotificationPlans");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 655, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "5c5b9298-bf33-4906-875d-429f6d5d7d1f", new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "c338ee88-8a5d-490a-9549-e84ca51a085b", new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ed5fec35-f288-4aec-bd17-4641daef2472", new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 657, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 656, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 4, 10, 20, 3, 658, DateTimeKind.Utc).AddTicks(3525));
        }
    }
}
