using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTypeSent",
                table: "RequestUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 810, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 810, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 806, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 807, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "8c2d1ae4-179d-4bcb-8832-d7462ada9d8a", new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "fad3a209-bf1f-4ca5-bb1b-6785d8ee1300", new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "24b06c6f-e456-4b20-bfbc-4cf3403d2d8a", new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 808, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 11, 26, 15, 28, 20, 809, DateTimeKind.Utc).AddTicks(9905));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTypeSent",
                table: "RequestUsers");

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
    }
}
