using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V34_VINX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Citys",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DateCreate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 14, 39, 13, 924, DateTimeKind.Utc).AddTicks(1846), true });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                columns: new[] { "DateCreate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 14, 39, 13, 924, DateTimeKind.Utc).AddTicks(6949), true });

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
                columns: new[] { "DateCreate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 14, 39, 13, 925, DateTimeKind.Utc).AddTicks(6897), true });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Citys");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 755, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 755, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "cf884757-da33-4c8d-9dd8-e0e37857c1e5", new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ff32ec79-bf00-4e74-bda5-838829fbf6af", new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "5f2e1d54-26d2-4c15-a61e-2cb4aac1daa2", new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 13, 51, 25, 757, DateTimeKind.Utc).AddTicks(7731));
        }
    }
}
