using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MimeType",
                table: "FileMusics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f76e469f-76a0-414b-94ac-26779c1a98a7", new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ec47b36c-37dd-4240-9a85-c9135a31fe86", new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "afa7e6c6-3e41-44a6-9644-5956ab5a1c68", new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(7714));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MimeType",
                table: "FileMusics");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 237, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ec59916c-6721-424b-8ac1-3455db02ca1f", new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "29864d68-b2dd-4199-aeb5-cc3d2d689c6c", new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "15464af3-60b9-42b0-954f-7927f5a8cb3f", new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 238, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 239, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 9, 12, 45, 29, 240, DateTimeKind.Utc).AddTicks(6293));
        }
    }
}
