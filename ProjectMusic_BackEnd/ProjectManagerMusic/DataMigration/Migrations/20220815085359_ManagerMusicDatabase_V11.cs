using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 505, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 506, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "fd3d989b-3db4-42f1-8f49-83fb1c35b70f", new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "0322c6f7-ec5c-485e-9436-66b2d8782151", new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "89d32f9f-fce7-49f3-8f0c-df57b355f290", new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.InsertData(
                table: "Saintes",
                columns: new[] { "IdSaints", "DateCreate", "IdStatusSaints", "NameSaints" },
                values: new object[] { 7, new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2232), 1, "Lễ Về Ơn Gọi" });

            migrationBuilder.InsertData(
                table: "Saintes",
                columns: new[] { "IdSaints", "DateCreate", "IdStatusSaints", "NameSaints" },
                values: new object[] { 8, new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(2233), 1, "Không thuộc lễ ngoại lịch" });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 508, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 507, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 15, 15, 53, 58, 509, DateTimeKind.Utc).AddTicks(3140));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 160, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 161, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a61c1250-f2b8-44d3-8c41-d162bda5af7c", new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "febe6b9e-7d67-41bc-9f4d-71842239f3ef", new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "42478f6e-edd1-47fa-aa59-918b173e4962", new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 164, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 162, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 163, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 14, 10, 22, 58, 165, DateTimeKind.Utc).AddTicks(8198));
        }
    }
}
