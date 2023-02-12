using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoMusic",
                table: "Musics",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 328, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 329, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "9e11d3ff-43d3-49dc-8211-207f05696c97", new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "b7d85caa-9046-4144-9008-6747f13ed70d", new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a37e2a10-60e3-463c-988d-2ea07418e362", new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 331, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 330, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 10, 58, 40, 332, DateTimeKind.Utc).AddTicks(4902));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NoMusic",
                table: "Musics",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 434, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f76e469f-76a0-414b-94ac-26779c1a98a7", new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "ec47b36c-37dd-4240-9a85-c9135a31fe86", new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "afa7e6c6-3e41-44a6-9644-5956ab5a1c68", new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 435, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 436, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 11, 9, 20, 21, 437, DateTimeKind.Utc).AddTicks(7714));
        }
    }
}
