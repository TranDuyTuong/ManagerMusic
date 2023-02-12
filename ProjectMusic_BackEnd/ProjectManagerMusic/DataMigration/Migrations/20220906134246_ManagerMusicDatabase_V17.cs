using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_ChatStaffs",
                table: "T_ChatStaffs");

            migrationBuilder.RenameTable(
                name: "T_ChatStaffs",
                newName: "ChatStaffs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatStaffs",
                table: "ChatStaffs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ChatImageStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IdChat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatImageStaffs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 536, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 536, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 530, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "337dc20a-1b1e-41fe-95e8-b3a0808cba77", new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "c68f54d6-3ee4-4264-9159-ea6cd06f4f43", new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "0394dd97-3f3e-47fb-96ab-6b70e99aa42d", new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 532, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 534, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 535, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 533, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 536, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 9, 6, 20, 42, 44, 536, DateTimeKind.Utc).AddTicks(770));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatImageStaffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatStaffs",
                table: "ChatStaffs");

            migrationBuilder.RenameTable(
                name: "ChatStaffs",
                newName: "T_ChatStaffs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_ChatStaffs",
                table: "T_ChatStaffs",
                column: "Id");

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
    }
}
