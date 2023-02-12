using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MineType",
                table: "RequestPasswords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeImg",
                table: "RequestPasswords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 515, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 515, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 512, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "67e58f13-7e6f-465d-863c-bda4e4d173d9", new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "875a5609-8c86-46f1-879d-d5a664623568", new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "e7911fac-d4b2-4f39-9a39-07163a269a1d", new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 515, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 515, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 514, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 513, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 515, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 22, 10, 46, 10, 515, DateTimeKind.Utc).AddTicks(1990));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MineType",
                table: "RequestPasswords");

            migrationBuilder.DropColumn(
                name: "TypeImg",
                table: "RequestPasswords");

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
    }
}
