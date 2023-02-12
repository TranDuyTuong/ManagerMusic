using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilePlans",
                columns: table => new
                {
                    IdFile = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlan = table.Column<int>(type: "int", nullable: false),
                    TypeFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilePlans", x => x.IdFile);
                });

            migrationBuilder.CreateTable(
                name: "PlanStaffs",
                columns: table => new
                {
                    IdPlan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePlan = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    ContentPlan = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUserPlan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUserRequest = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTimeComplete = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdStatusPlan = table.Column<int>(type: "int", nullable: false),
                    AcceptPlan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanStaffs", x => x.IdPlan);
                });

            migrationBuilder.CreateTable(
                name: "StatusPlans",
                columns: table => new
                {
                    IdStatusPlan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStauts = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPlans", x => x.IdStatusPlan);
                });

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 960, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "df74fcef-9403-4264-9d80-a95b3f914699", new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "4f6a45dc-8190-4fea-b16b-405693bf38e9", new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "b793ff79-7611-4628-af3a-b316a4f27062", new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.InsertData(
                table: "StatusPlans",
                columns: new[] { "IdStatusPlan", "NameStauts" },
                values: new object[,]
                {
                    { 1, "Hoàn Thành" },
                    { 2, "Hủy Bỏ" },
                    { 3, "Chưa Hoàn Thành" },
                    { 4, "Đang Thực Hiện" },
                    { 5, "Chưa Thực Hiện" }
                });

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 962, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 961, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 28, 10, 6, 32, 963, DateTimeKind.Utc).AddTicks(3836));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilePlans");

            migrationBuilder.DropTable(
                name: "PlanStaffs");

            migrationBuilder.DropTable(
                name: "StatusPlans");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 141, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "5fe70926-41ae-4145-aa18-f2919a336b27", new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "6a7f30be-4493-4dd0-ad02-0b1941cf6375", new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "73382ce5-30b7-4b10-90e0-ac7ee6b50cd2", new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 143, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 142, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 23, 21, 25, 57, 144, DateTimeKind.Utc).AddTicks(3882));
        }
    }
}
