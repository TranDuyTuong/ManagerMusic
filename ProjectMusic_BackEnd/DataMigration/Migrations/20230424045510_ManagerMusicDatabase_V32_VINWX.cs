using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V32_VINWX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "IdDistrict",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 7);

            migrationBuilder.AddColumn<int>(
                name: "AreaCode",
                table: "Citys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Citys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                columns: new[] { "AreaCode", "DateCreate", "Symbol" },
                values: new object[] { 28, new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(85), "SG" });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                columns: new[] { "AreaCode", "DateCreate", "Symbol" },
                values: new object[] { 24, new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(790), "HN" });

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 463, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "dccde962-672a-43ba-b739-26c60561bba6", new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "0e15063b-aaf6-4799-ae11-02e170fb745d", new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "325c8d2a-7f19-47b4-9c99-9aadf8474464", new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 464, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 24, 11, 55, 9, 465, DateTimeKind.Utc).AddTicks(6457));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCode",
                table: "Citys");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Citys");

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ActiverAccounts",
                keyColumn: "IdAccountActiver",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 988, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "IdCity",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "IdCity", "DateCreate", "NameCity" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(493), "Thành Phố Huế" },
                    { 4, new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(495), "Thành Phố Đã Nẵng" },
                    { 5, new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(502), "Thành Phố Đà Lạt" },
                    { 6, new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(504), "Thành Phố Vũng Tàu" },
                    { 7, new DateTime(2023, 4, 18, 10, 19, 56, 989, DateTimeKind.Utc).AddTicks(506), "Thành Phố Nha Trang" }
                });

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "DeleteNotifications",
                keyColumn: "IdDeleteNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "IdDistrict", "DateCreate", "IdCity", "NameDistrict" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2655), 1, "Quận 1" },
                    { 2, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2877), 2, "Quận Hoàn Kiếm" }
                });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "IdGender",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "LeverUsers",
                keyColumn: "IdLever",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Marriages",
                keyColumn: "IdMarriage",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "ReadUsers",
                keyColumn: "IdRead",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ReceiveRequests",
                keyColumn: "IdReceiveRequest",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "a6804280-f984-48ce-9733-6b61b1acf2ac", new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "e70e8f09-7984-4a24-9352-94b9ceabc87d", new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "IdRole",
                keyValue: new Guid("99ef88a8-d94b-469e-bac0-39694b407976"),
                columns: new[] { "ConcurrencyStamp", "DateCreate" },
                values: new object[] { "54145ef5-9f24-4b64-a85b-71a714536186", new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Saintes",
                keyColumn: "IdSaints",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "IdSeason",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "StaffOrUsers",
                keyColumn: "IdStaffOrUser",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "StatusHappyBirthDayStaffs",
                keyColumn: "IsStatusSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "StatusMusics",
                keyColumn: "IdStatusMusic",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "StatusRoles",
                keyColumn: "IdStatusRole",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "StatusSaintes",
                keyColumn: "IdIdStatusSaints",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "StatusSeasons",
                keyColumn: "IdStatusSeason",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "StatusStaffOffs",
                keyColumn: "StatusStaffOff",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "TypeSentUsers",
                keyColumn: "IdTypeSent",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "ViewNotifications",
                keyColumn: "IdViewNotification",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2023, 4, 18, 10, 19, 56, 991, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "IdDistrict", "DateCreate", "IdCity", "NameDistrict" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2879), 3, "Phường An Cựu" },
                    { 4, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2880), 4, "Quận Hải Châu" },
                    { 5, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2882), 5, "Xã Xuân Thọ" },
                    { 6, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2883), 6, "Phường Thắng Tam" },
                    { 7, new DateTime(2023, 4, 18, 10, 19, 56, 990, DateTimeKind.Utc).AddTicks(2885), 7, "Phường Vĩnh Phước" }
                });
        }
    }
}
