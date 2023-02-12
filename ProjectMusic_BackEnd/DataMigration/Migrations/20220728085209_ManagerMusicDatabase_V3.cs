using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdStaff",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdStaff",
                table: "Users",
                type: "nvarchar(max)",
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
                value: new DateTime(2022, 7, 27, 10, 58, 36, 412, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 7, 27, 10, 58, 36, 412, DateTimeKind.Utc).AddTicks(827));

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
    }
}
