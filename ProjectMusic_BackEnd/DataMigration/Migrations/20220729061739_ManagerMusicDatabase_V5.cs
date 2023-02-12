using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Nvarchar(MAX)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "Nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 99, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 99, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 94, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 95, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 95, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 95, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 95, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 95, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 95, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f4547a97-7ff7-4ba6-9f7f-646cfde7d12e", new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "4e4a0732-6650-4ad3-99cb-146bfd078a3d", new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "bb426e2a-f984-43a6-b0c5-aa2686aeeda5", new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 97, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 96, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 17, 38, 98, DateTimeKind.Utc).AddTicks(9167));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "Nvarchar(MAX)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
