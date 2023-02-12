using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdUser",
                table: "Saintes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 750, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "d82da368-9131-4ddb-ac91-1885df7328c1", new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "35e310d5-2265-4a65-bb22-41bc3acf9175", new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "63a39011-5025-4d93-83b5-d2b164d30cb3", new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 751, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 752, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 16, 53, 753, DateTimeKind.Utc).AddTicks(8283));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Saintes");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 734, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 734, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 730, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 731, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "da4275c3-9d71-405c-9414-6433aa018df6", new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f4362dc7-2520-42a5-9af3-69e659de5681", new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "f0e39d03-ad1a-4872-a912-4644258efc10", new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 732, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 29, 12, 12, 57, 733, DateTimeKind.Utc).AddTicks(9632));
        }
    }
}
