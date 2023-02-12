using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Marriages_IdMarriage",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StatusStaffOffs_StatusStaffOff",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "StatusStaffOff",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdMarriage",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CancelHideStaff",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 430, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "64ad69c2-3cb2-4ba9-9246-eb58f04f922d", new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "cd129873-b7f9-4ec1-badd-d3d15ae7cee2", new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "930d864d-d5eb-44bc-80cc-bd24e6cd13fe", new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 432, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 431, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 29, 13, 40, 7, 433, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Marriages_IdMarriage",
                table: "Users",
                column: "IdMarriage",
                principalTable: "Marriages",
                principalColumn: "IdMarriage",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StatusStaffOffs_StatusStaffOff",
                table: "Users",
                column: "StatusStaffOff",
                principalTable: "StatusStaffOffs",
                principalColumn: "StatusStaffOff",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Marriages_IdMarriage",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StatusStaffOffs_StatusStaffOff",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "StatusStaffOff",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdMarriage",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CancelHideStaff",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Marriages_IdMarriage",
                table: "Users",
                column: "IdMarriage",
                principalTable: "Marriages",
                principalColumn: "IdMarriage",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StatusStaffOffs_StatusStaffOff",
                table: "Users",
                column: "StatusStaffOff",
                principalTable: "StatusStaffOffs",
                principalColumn: "StatusStaffOff",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
