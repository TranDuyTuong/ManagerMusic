using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUserDecenRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryRoles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "5fe70926-41ae-4145-aa18-f2919a336b27", new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "6a7f30be-4493-4dd0-ad02-0b1941cf6375", new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "73382ce5-30b7-4b10-90e0-ac7ee6b50cd2", new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(3882));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryRoles");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 643, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "09be1b0b-d71a-4fad-b30b-ad77d1a3364a", new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "1ffc693e-5970-40fe-883c-266a7599949c", new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "7b38e83f-b881-4cec-91a7-6e2c6ac3a033", new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 645, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 644, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 21, 10, 2, 29, 646, DateTimeKind.Utc).AddTicks(3764));
        }
    }
}
