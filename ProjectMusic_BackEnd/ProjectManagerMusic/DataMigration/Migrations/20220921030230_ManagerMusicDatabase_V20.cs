using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameFile",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameFile",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TypeImage",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 870, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 870, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 864, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "c43c1a3a-7775-4c24-b784-17689919b2ad", new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "c137aa30-ce8a-4e19-a372-ffb028a0835e", new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a729ae4f-8e47-4d2f-b2ca-f0f83148a208", new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 870, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 870, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 866, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 868, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 869, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 867, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 870, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 15, 20, 46, 20, 870, DateTimeKind.Utc).AddTicks(3056));
        }
    }
}
