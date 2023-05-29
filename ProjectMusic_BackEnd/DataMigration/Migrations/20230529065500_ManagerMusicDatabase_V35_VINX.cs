using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V35_VINX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 970, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 970, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 962, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 962, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                columns: new[] { "DateCreate", "Identifier" },
                values: new object[] { new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(5088), "28_Q1" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 968, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 968, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 968, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 964, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "4a4b6b57-3224-4413-8689-93e4757d013e", new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "30da51f2-7670-42ef-8127-47ff5fefce8d", new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "d9ee8b44-73b3-45da-891b-54b18547b37d", new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 968, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 968, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 966, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 967, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 965, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 969, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 5, 29, 13, 54, 58, 970, DateTimeKind.Utc).AddTicks(1245));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Districts");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 928, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 928, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 924, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 924, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 925, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 925, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 925, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 925, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 925, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ffd53bfa-3fd0-4a71-8daa-4afffe598989", new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ffe82000-8eff-4877-9c5a-29e270323956", new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "6ab7db49-c9ed-4782-9bcd-98c11c26572e", new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 927, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 926, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 928, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 28, 14, 39, 13, 928, DateTimeKind.Utc).AddTicks(700));
        }
    }
}
