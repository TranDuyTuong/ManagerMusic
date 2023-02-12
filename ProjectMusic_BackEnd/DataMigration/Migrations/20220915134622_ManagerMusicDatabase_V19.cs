using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageBase64",
                table: "ChatImageStaffs",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBase64",
                table: "ChatImageStaffs");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 187, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 187, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 183, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 184, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "b51c8e2f-1a39-4839-83a3-63d0d8f50c86", new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "eed6f661-b49a-4b27-808b-37b47617d82a", new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "cb3b6dfa-5098-45ba-b95e-75df8820de2a", new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 186, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 185, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 187, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 7, 8, 43, 19, 187, DateTimeKind.Utc).AddTicks(860));
        }
    }
}
