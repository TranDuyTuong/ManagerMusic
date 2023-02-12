using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalChat",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "WasView",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "T_ChatStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "Nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ChatStaffs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 262, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "3e8e22bb-a2a0-482c-a3e2-ad2bca697be6", new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "5e63fdb3-3145-4228-aa4f-0bca70474716", new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "04336680-96d7-4df3-9d2c-3d1a1d823d4e", new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 264, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 263, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 31, 10, 24, 42, 265, DateTimeKind.Utc).AddTicks(2793));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ChatStaffs");

            migrationBuilder.DropColumn(
                name: "TotalChat",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WasView",
                table: "Users");

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
    }
}
