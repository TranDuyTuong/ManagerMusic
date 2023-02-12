using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "Nvarchar(MAX)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 581, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a20dbaab-20e2-467c-986c-27e286aaf2b8", new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "106c161b-ad75-474d-99e8-d26c7114c957", new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f76d04b1-aa02-479a-b41e-4c2dfa74f39f", new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 582, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 583, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 10, 40, 584, DateTimeKind.Utc).AddTicks(7750));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "Nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Nvarchar(MAX)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 146, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 147, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "73e805e4-c1ac-4ce0-b2dc-5a3159126fce", new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "2d15955c-ae2b-428a-904d-c68431d97e25", new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "714e4527-f970-4544-a9ca-a257b33565ea", new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 149, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 150, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 148, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 28, 15, 52, 8, 151, DateTimeKind.Utc).AddTicks(5576));
        }
    }
}
