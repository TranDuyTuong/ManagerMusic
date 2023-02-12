using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActiverAccounts",
                columns: new[] { "IdAccountActiver", "DateCreate", "NameAccountActiver" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 58, 36, 412, DateTimeKind.Utc).AddTicks(560), "Hoạt Động" },
                    { 2, new DateTime(2022, 7, 27, 10, 58, 36, 412, DateTimeKind.Utc).AddTicks(827), "Đang Bị Khóa" }
                });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 408, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 409, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "0fdc8881-c8e9-4e4c-ab13-72b101ad4af8", new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "449296bf-610e-4a65-b0a5-a5e7ab4ec395", new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ff44ab1a-3f61-4532-82ce-7b8ad8ea3797", new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 410, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 411, DateTimeKind.Utc).AddTicks(9716));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "c8f3fb8e-5031-4cb8-9c48-cda20319eaa7", new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "9643abcb-71b7-475a-a586-dc495a8b7747", new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "420baa2d-f33d-499d-a92b-a7dfe6d28c4e", new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(8049));
        }
    }
}
