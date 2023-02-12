using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_UpdateMusics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TokenData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileNameOld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileNameNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameMusicOld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameMuiscNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorOld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSeasonOld = table.Column<int>(type: "int", nullable: false),
                    IdSaintOld = table.Column<int>(type: "int", nullable: false),
                    IdSeasonNew = table.Column<int>(type: "int", nullable: false),
                    IdSaintNew = table.Column<int>(type: "int", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_UpdateMusics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 966, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 966, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 952, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 962, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 962, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 962, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 962, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 962, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 962, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 963, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "78f2bcea-1850-405c-8f55-0f8c3a74d716", new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "e4ba4b29-5e6c-431f-844d-d7289d11135d", new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a3843669-0385-40f9-b1a9-4247548988df", new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 966, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 966, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 965, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 964, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 966, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 18, 11, 25, 26, 966, DateTimeKind.Utc).AddTicks(2418));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_UpdateMusics");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 847, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "bbcabb00-af97-4af0-8329-ac363a24cb27", new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "d03d4027-9ef9-4a0e-a8a7-4e5a32c9e632", new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "79630264-2f62-45b1-a25d-eecc6bc060ac", new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 848, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 849, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2022, 8, 16, 12, 4, 41, 850, DateTimeKind.Utc).AddTicks(7213));
        }
    }
}
