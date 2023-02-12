using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TimeUp",
                table: "PlanStaffs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 98, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 100, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "1c75155b-f9b3-40ed-9462-e2dae0125151", new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "1f4fc909-4c40-45f6-a373-cca841b91183", new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "7faf108f-4e7c-4173-9835-d2e076038cd8", new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 102, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 103, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 101, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 10, 1, 14, 20, 15, 104, DateTimeKind.Utc).AddTicks(6212));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeUp",
                table: "PlanStaffs");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 963, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 963, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 957, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "aca4ef52-f908-4488-988e-2df548e6a7a3", new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "6adccfff-6eee-4964-a834-2f5ff0ace3cf", new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "2fe9c97c-bee0-4766-a6e8-e9155db8eedc", new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 959, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 961, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 962, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 960, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 963, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 29, 14, 56, 35, 963, DateTimeKind.Utc).AddTicks(873));
        }
    }
}
