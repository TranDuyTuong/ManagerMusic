using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V31_VINWX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 988, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a6804280-f984-48ce-9733-6b61b1acf2ac", new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "e70e8f09-7984-4a24-9352-94b9ceabc87d", new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "54145ef5-9f24-4b64-a85b-71a714536186", new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(9014));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 794, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 794, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 790, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 791, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "b06e71f4-cc62-449a-b80e-b1f8c6e5a8aa", new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "9649eece-c00c-4213-9d4c-c45a4d34b0fc", new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "35ffc3b0-01de-4a63-94ae-afae0ee410f2", new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 12, 1, 10, 13, 8, 793, DateTimeKind.Utc).AddTicks(9263));
        }
    }
}
