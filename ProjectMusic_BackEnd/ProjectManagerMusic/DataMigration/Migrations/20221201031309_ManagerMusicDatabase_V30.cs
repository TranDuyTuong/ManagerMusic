using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "TypeSentUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DateCreate", "Status" },
                values: new object[] { new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(3690), true });

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                columns: new[] { "DateCreate", "Status" },
                values: new object[] { new DateTime(2022, 12, 1, 10, 13, 8, 792, DateTimeKind.Utc).AddTicks(4118), true });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TypeSentUsers");

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
    }
}
