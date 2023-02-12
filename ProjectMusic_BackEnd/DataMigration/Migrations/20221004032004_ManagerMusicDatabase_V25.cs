using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlan = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationPlans", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationPlans");

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
    }
}
