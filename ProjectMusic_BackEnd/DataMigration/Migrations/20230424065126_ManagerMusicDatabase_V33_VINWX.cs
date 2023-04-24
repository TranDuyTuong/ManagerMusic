using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V33_VINWX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "IdDistrict", "DateCreate", "IdCity", "NameDistrict" },
                values: new object[] { 1, new DateTime(2023, 4, 24, 13, 51, 25, 756, DateTimeKind.Utc).AddTicks(2935), 1, "Quận 1" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "dccde962-672a-43ba-b739-26c60561bba6", new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "0e15063b-aaf6-4799-ae11-02e170fb745d", new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "325c8d2a-7f19-47b4-9c99-9aadf8474464", new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(6457));
        }
    }
}
