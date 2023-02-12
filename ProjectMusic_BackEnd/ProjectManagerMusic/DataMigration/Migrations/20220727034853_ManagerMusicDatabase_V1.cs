using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class ManagerMusicDatabase_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiverAccounts",
                columns: table => new
                {
                    IdAccountActiver = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAccountActiver = table.Column<string>(type: "Nvarchar(250)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiverAccounts", x => x.IdAccountActiver);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    IdCity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCity = table.Column<string>(type: "Nvarchar(300)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.IdCity);
                });

            migrationBuilder.CreateTable(
                name: "DeleteNotifications",
                columns: table => new
                {
                    IdDeleteNotification = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "Nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteNotifications", x => x.IdDeleteNotification);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    IdGender = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGender = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.IdGender);
                });

            migrationBuilder.CreateTable(
                name: "LeverUsers",
                columns: table => new
                {
                    IdLever = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DescriptionName = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeverUsers", x => x.IdLever);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    IdLogin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeSignout = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.IdLogin);
                });

            migrationBuilder.CreateTable(
                name: "Marriages",
                columns: table => new
                {
                    IdMarriage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMarriage = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marriages", x => x.IdMarriage);
                });

            migrationBuilder.CreateTable(
                name: "ReadUsers",
                columns: table => new
                {
                    IdRead = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadUsers", x => x.IdRead);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveRequests",
                columns: table => new
                {
                    IdReceiveRequest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveRequests", x => x.IdReceiveRequest);
                });

            migrationBuilder.CreateTable(
                name: "StaffOrUsers",
                columns: table => new
                {
                    IdStaffOrUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    symbol = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffOrUsers", x => x.IdStaffOrUser);
                });

            migrationBuilder.CreateTable(
                name: "StatusHappyBirthDayStaffs",
                columns: table => new
                {
                    IsStatusSent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusHappyBirthDayStaffs", x => x.IsStatusSent);
                });

            migrationBuilder.CreateTable(
                name: "StatusMusics",
                columns: table => new
                {
                    IdStatusMusic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatusMusic = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusMusics", x => x.IdStatusMusic);
                });

            migrationBuilder.CreateTable(
                name: "StatusRoles",
                columns: table => new
                {
                    IdStatusRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatus = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusRoles", x => x.IdStatusRole);
                });

            migrationBuilder.CreateTable(
                name: "StatusSaintes",
                columns: table => new
                {
                    IdIdStatusSaints = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatusSaints = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSaintes", x => x.IdIdStatusSaints);
                });

            migrationBuilder.CreateTable(
                name: "StatusSeasons",
                columns: table => new
                {
                    IdStatusSeason = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatus = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSeasons", x => x.IdStatusSeason);
                });

            migrationBuilder.CreateTable(
                name: "StatusStaffOffs",
                columns: table => new
                {
                    StatusStaffOff = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusStaffOffs", x => x.StatusStaffOff);
                });

            migrationBuilder.CreateTable(
                name: "TypeSentUsers",
                columns: table => new
                {
                    IdTypeSent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameType = table.Column<string>(type: "Nvarchar(250)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSentUsers", x => x.IdTypeSent);
                });

            migrationBuilder.CreateTable(
                name: "ViewNotifications",
                columns: table => new
                {
                    IdViewNotification = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewNotifications", x => x.IdViewNotification);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    IdDistrict = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCity = table.Column<int>(type: "int", nullable: false),
                    NameDistrict = table.Column<string>(type: "Nvarchar(300)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.IdDistrict);
                    table.ForeignKey(
                        name: "FK_Districts_Citys_IdCity",
                        column: x => x.IdCity,
                        principalTable: "Citys",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestPasswords",
                columns: table => new
                {
                    IdRequestPassword = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReceiveRequest = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NameUser = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    TitleRequest = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    ContentRequest = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    GmailRequest = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    ImageRequest = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateHandled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSuccess = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestPasswords", x => x.IdRequestPassword);
                    table.ForeignKey(
                        name: "FK_RequestPasswords_ReceiveRequests_IdReceiveRequest",
                        column: x => x.IdReceiveRequest,
                        principalTable: "ReceiveRequests",
                        principalColumn: "IdReceiveRequest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStatusRole = table.Column<int>(type: "int", nullable: false),
                    SymbolRole = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "Nvarchar(500)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "Nvarchar(250)", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                    table.ForeignKey(
                        name: "FK_Roles_StatusRoles_IdStatusRole",
                        column: x => x.IdStatusRole,
                        principalTable: "StatusRoles",
                        principalColumn: "IdStatusRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saintes",
                columns: table => new
                {
                    IdSaints = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSaints = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdStatusSaints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saintes", x => x.IdSaints);
                    table.ForeignKey(
                        name: "FK_Saintes_StatusSaintes_IdStatusSaints",
                        column: x => x.IdStatusSaints,
                        principalTable: "StatusSaintes",
                        principalColumn: "IdIdStatusSaints",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    IdSeason = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSeason = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdStatusSeason = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.IdSeason);
                    table.ForeignKey(
                        name: "FK_Seasons_StatusSeasons_IdStatusSeason",
                        column: x => x.IdStatusSeason,
                        principalTable: "StatusSeasons",
                        principalColumn: "IdStatusSeason",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStaff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAccountActiver = table.Column<int>(type: "int", nullable: false),
                    IdLever = table.Column<int>(type: "int", nullable: false),
                    IdStaffOrUser = table.Column<int>(type: "int", nullable: false),
                    StatusStaffOff = table.Column<int>(type: "int", nullable: false),
                    IdMarriage = table.Column<int>(type: "int", nullable: false),
                    IdGender = table.Column<int>(type: "int", nullable: false),
                    IdCity = table.Column<int>(type: "int", nullable: false),
                    IdDistrict = table.Column<int>(type: "int", nullable: false),
                    DateStaffOff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateAccountBlock = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ImageAvata = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressSatff = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneStaff = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    CancelHideStaff = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_ActiverAccounts_IdAccountActiver",
                        column: x => x.IdAccountActiver,
                        principalTable: "ActiverAccounts",
                        principalColumn: "IdAccountActiver",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Citys_IdCity",
                        column: x => x.IdCity,
                        principalTable: "Citys",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Districts_IdDistrict",
                        column: x => x.IdDistrict,
                        principalTable: "Districts",
                        principalColumn: "IdDistrict",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Users_Genders_IdGender",
                        column: x => x.IdGender,
                        principalTable: "Genders",
                        principalColumn: "IdGender",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_LeverUsers_IdLever",
                        column: x => x.IdLever,
                        principalTable: "LeverUsers",
                        principalColumn: "IdLever",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Marriages_IdMarriage",
                        column: x => x.IdMarriage,
                        principalTable: "Marriages",
                        principalColumn: "IdMarriage",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_StaffOrUsers_IdStaffOrUser",
                        column: x => x.IdStaffOrUser,
                        principalTable: "StaffOrUsers",
                        principalColumn: "IdStaffOrUser",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_StatusStaffOffs_StatusStaffOff",
                        column: x => x.StatusStaffOff,
                        principalTable: "StatusStaffOffs",
                        principalColumn: "StatusStaffOff",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswerGmailRequestPasswords",
                columns: table => new
                {
                    IdAnswerGmail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRequestPassword = table.Column<int>(type: "int", nullable: false),
                    IdStaff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NameUser = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    TitleAnswer = table.Column<string>(type: "Nvarchar(450)", maxLength: 450, nullable: false),
                    ContentAnswer = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateAnswer = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerGmailRequestPasswords", x => x.IdAnswerGmail);
                    table.ForeignKey(
                        name: "FK_AnswerGmailRequestPasswords_RequestPasswords_IdRequestPassword",
                        column: x => x.IdRequestPassword,
                        principalTable: "RequestPasswords",
                        principalColumn: "IdRequestPassword",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BirthdayUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleSent = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    ContentSent = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    BirthdayUser = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusSent = table.Column<bool>(type: "bit", nullable: false),
                    T_UsersIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthdayUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirthdayUsers_Users_T_UsersIdUser",
                        column: x => x.T_UsersIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HappyBirthdayStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStatusSent = table.Column<int>(type: "int", nullable: false),
                    TitleSent = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    ContentSent = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HappyBirthdayStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HappyBirthdayStaffs_StatusHappyBirthDayStaffs_IsStatusSent",
                        column: x => x.IsStatusSent,
                        principalTable: "StatusHappyBirthDayStaffs",
                        principalColumn: "IsStatusSent",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HappyBirthdayStaffs_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoMusic = table.Column<int>(type: "int", nullable: false),
                    NameMusic = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    AuthorMusic = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    IdSeason = table.Column<int>(type: "int", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdStatusMusic = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStaff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSaints = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.IdMusic);
                    table.ForeignKey(
                        name: "FK_Musics_Saintes_IdSaints",
                        column: x => x.IdSaints,
                        principalTable: "Saintes",
                        principalColumn: "IdSaints",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musics_Seasons_IdSeason",
                        column: x => x.IdSeason,
                        principalTable: "Seasons",
                        principalColumn: "IdSeason",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musics_StatusMusics_IdStatusMusic",
                        column: x => x.IdStatusMusic,
                        principalTable: "StatusMusics",
                        principalColumn: "IdStatusMusic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musics_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationUsers",
                columns: table => new
                {
                    IdNotification = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdViewNotification = table.Column<int>(type: "int", nullable: false),
                    IdDeleteNotification = table.Column<int>(type: "int", nullable: false),
                    TitleNotification = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorNotification = table.Column<string>(type: "Nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationUsers", x => x.IdNotification);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_DeleteNotifications_IdDeleteNotification",
                        column: x => x.IdDeleteNotification,
                        principalTable: "DeleteNotifications",
                        principalColumn: "IdDeleteNotification",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_ViewNotifications_IdViewNotification",
                        column: x => x.IdViewNotification,
                        principalTable: "ViewNotifications",
                        principalColumn: "IdViewNotification",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestUsers",
                columns: table => new
                {
                    IdRequest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleRequest = table.Column<string>(type: "Nvarchar(250)", maxLength: 250, nullable: false),
                    ContentRequest = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateHandled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSuccess = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdReceiveRequest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestUsers", x => x.IdRequest);
                    table.ForeignKey(
                        name: "FK_RequestUsers_ReceiveRequests_IdReceiveRequest",
                        column: x => x.IdReceiveRequest,
                        principalTable: "ReceiveRequests",
                        principalColumn: "IdReceiveRequest",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestUsers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDecentralization = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentMusics",
                columns: table => new
                {
                    IdComment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentComment = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentMusics", x => x.IdComment);
                    table.ForeignKey(
                        name: "FK_CommentMusics_Musics_IdMusic",
                        column: x => x.IdMusic,
                        principalTable: "Musics",
                        principalColumn: "IdMusic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentMusics_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DowloadMusics",
                columns: table => new
                {
                    IdDowload = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameUser = table.Column<string>(type: "Nvarchar(450)", maxLength: 450, nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DowloadMusics", x => x.IdDowload);
                    table.ForeignKey(
                        name: "FK_DowloadMusics_Musics_IdMusic",
                        column: x => x.IdMusic,
                        principalTable: "Musics",
                        principalColumn: "IdMusic",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileMusics",
                columns: table => new
                {
                    IdFile = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameFile = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    DataFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMusics", x => x.IdFile);
                    table.ForeignKey(
                        name: "FK_FileMusics_Musics_IdMusic",
                        column: x => x.IdMusic,
                        principalTable: "Musics",
                        principalColumn: "IdMusic",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageQRCores",
                columns: table => new
                {
                    IdQRcore = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleImage = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageQRCores", x => x.IdQRcore);
                    table.ForeignKey(
                        name: "FK_ImageQRCores_Musics_IdMusic",
                        column: x => x.IdMusic,
                        principalTable: "Musics",
                        principalColumn: "IdMusic",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeMusics",
                columns: table => new
                {
                    IdLike = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LikeStatus = table.Column<bool>(type: "bit", nullable: false),
                    DateLike = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeMusics", x => x.IdLike);
                    table.ForeignKey(
                        name: "FK_LikeMusics_Musics_IdMusic",
                        column: x => x.IdMusic,
                        principalTable: "Musics",
                        principalColumn: "IdMusic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikeMusics_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    IdRating = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusic = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.IdRating);
                    table.ForeignKey(
                        name: "FK_Ratings_Musics_IdMusic",
                        column: x => x.IdMusic,
                        principalTable: "Musics",
                        principalColumn: "IdMusic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AnswerRequests",
                columns: table => new
                {
                    IdAnswer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTypeSent = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRequest = table.Column<int>(type: "int", nullable: false),
                    IdStaff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRead = table.Column<int>(type: "int", nullable: false),
                    TitleSent = table.Column<string>(type: "Nvarchar(450)", maxLength: 450, nullable: false),
                    ContentSent = table.Column<string>(type: "Nvarchar(MAX)", nullable: false),
                    DateSent = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerRequests", x => x.IdAnswer);
                    table.ForeignKey(
                        name: "FK_AnswerRequests_ReadUsers_IdRead",
                        column: x => x.IdRead,
                        principalTable: "ReadUsers",
                        principalColumn: "IdRead",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerRequests_RequestUsers_IdRequest",
                        column: x => x.IdRequest,
                        principalTable: "RequestUsers",
                        principalColumn: "IdRequest",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerRequests_TypeSentUsers_IdTypeSent",
                        column: x => x.IdTypeSent,
                        principalTable: "TypeSentUsers",
                        principalColumn: "IdTypeSent",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerRequests_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AnswerComments",
                columns: table => new
                {
                    IdAnswer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdComment = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentAnswer = table.Column<string>(type: "Nvarchar(500)", maxLength: 500, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerComments", x => x.IdAnswer);
                    table.ForeignKey(
                        name: "FK_AnswerComments_CommentMusics_IdComment",
                        column: x => x.IdComment,
                        principalTable: "CommentMusics",
                        principalColumn: "IdComment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerComments_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "IdCity", "DateCreate", "NameCity" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6380), "Thành Phố Hồ Chí Mình" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6865), "Thủ Đô Hà Nội" },
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6873), "Thành Phố Huế" },
                    { 4, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6875), "Thành Phố Đã Nẵng" },
                    { 5, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6876), "Thành Phố Đà Lạt" },
                    { 6, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6877), "Thành Phố Vũng Tàu" },
                    { 7, new DateTime(2022, 7, 27, 10, 48, 52, 622, DateTimeKind.Utc).AddTicks(6878), "Thành Phố Nha Trang" }
                });

            migrationBuilder.InsertData(
                table: "DeleteNotifications",
                columns: new[] { "IdDeleteNotification", "DateCreate", "Description" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(4287), "Đã Xóa Thông Báo" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(4061), "Chưa Xóa Thông Báo" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "IdGender", "DateCreate", "NameGender" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(7301), "Nam" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(7636), "Nữ" },
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(7639), "Giới Tính Khác" }
                });

            migrationBuilder.InsertData(
                table: "LeverUsers",
                columns: new[] { "IdLever", "DateCreate", "DescriptionName", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(5619), "- Đây là cấp độ lớn nhất của hệ thống, với cấp độ này thì được phép dùng tất cả chức năng có trong hệ thống, quản lý toàn bộ các cấp độ khác nhỏ hơn, quản trị toàn bộ dữ liệu thông tin của hệ thống.", "Cấp Độ Vàng" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(5616), "- Đây là cấp độ ở mức trung bình không nhỏ cũng không lớn, đa số các tài khoản ở cấp độ này sẻ là các cộng tác viên được cấp độ vàng phân quyền cho, vì vậy với cấp độ bạc bạn sẻ bị hạn chế một vài chức năng của hệ thống mà bạn không được phép dùng.", "Cấp Độ Bạc" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(5384), "- Đây là cấp độ thấp nhất các tài khoản ở cấp độ này chỉ được phép dùng từ 1 đến 2 chức năng của hệ thống, đa số ở cấp độ này sẻ là người dùng là chủ yếu họ chỉ được thao tác các chức năng mà được cấp phép.", "Cấp Độ Đồng" }
                });

            migrationBuilder.InsertData(
                table: "Marriages",
                columns: new[] { "IdMarriage", "DateCreate", "NameMarriage" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(8445), "Độc Thân" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(8682), "Đã Kết Hôn" },
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(8685), "Đã Ly Hôn" }
                });

            migrationBuilder.InsertData(
                table: "ReadUsers",
                columns: new[] { "IdRead", "DateCreate", "ReadContent" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(559), "Đã Đọc" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(791), "Chưa Đọc" }
                });

            migrationBuilder.InsertData(
                table: "ReceiveRequests",
                columns: new[] { "IdReceiveRequest", "DateCreate", "Description" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(1772), "Đã Giải Quyết" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(1538), "Chưa Giải Quyết" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(1769), "Đang Giải Quyết" }
                });

            migrationBuilder.InsertData(
                table: "StaffOrUsers",
                columns: new[] { "IdStaffOrUser", "DateCreate", "Description", "Status", "symbol" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(7086), "Nhân Viên", true, "NV" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(6656), "Người Dùng", true, "ND" }
                });

            migrationBuilder.InsertData(
                table: "StatusHappyBirthDayStaffs",
                columns: new[] { "IsStatusSent", "DateCreate", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(2124), "Gửi Thành Công" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(2359), "Gửi Thất Bại" }
                });

            migrationBuilder.InsertData(
                table: "StatusMusics",
                columns: new[] { "IdStatusMusic", "DateCreate", "NameStatusMusic" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(9791), "Đã Xóa" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(9788), "Ngưng Hoạt Động" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(9540), "Đang Hoạt Động" }
                });

            migrationBuilder.InsertData(
                table: "StatusRoles",
                columns: new[] { "IdStatusRole", "DateCreate", "NameStatus" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(3849), "Ngưng Hoạt Động" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(3619), "Hoạt Động" }
                });

            migrationBuilder.InsertData(
                table: "StatusSaintes",
                columns: new[] { "IdIdStatusSaints", "DateCreate", "NameStatusSaints" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(7731), "Ngưng Hoạt Động" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(7500), "Hoạt Động" }
                });

            migrationBuilder.InsertData(
                table: "StatusSeasons",
                columns: new[] { "IdStatusSeason", "DateCreate", "NameStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9785), "Hoạt Động" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(10), "Ngưng Hoạt Động" }
                });

            migrationBuilder.InsertData(
                table: "StatusStaffOffs",
                columns: new[] { "StatusStaffOff", "DateCreate", "Description" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(3328), "Nghĩ Làm" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(3100), "Còn Làm" }
                });

            migrationBuilder.InsertData(
                table: "TypeSentUsers",
                columns: new[] { "IdTypeSent", "DateCreate", "NameType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(2628), "Gửi Qua Gmail" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(2870), "Gửi Qua Tin Nhắn Website" }
                });

            migrationBuilder.InsertData(
                table: "ViewNotifications",
                columns: new[] { "IdViewNotification", "DateCreate", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(7821), "Đã Xem" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(8049), "Chưa Xem" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "IdDistrict", "DateCreate", "IdCity", "NameDistrict" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6091), 1, "Quận 1" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6459), 2, "Quận Hoàn Kiếm" },
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6463), 3, "Phường An Cựu" },
                    { 4, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6464), 4, "Quận Hải Châu" },
                    { 5, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6465), 5, "Xã Xuân Thọ" },
                    { 6, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6466), 6, "Phường Thắng Tam" },
                    { 7, new DateTime(2022, 7, 27, 10, 48, 52, 623, DateTimeKind.Utc).AddTicks(6467), 7, "Phường Vĩnh Phước" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRole", "ConcurrencyStamp", "DateCreate", "Description", "Id", "IdStatusRole", "Name", "NormalizedName", "SymbolRole" },
                values: new object[,]
                {
                    { new Guid("99ef88a8-d94b-469e-bac0-39694b407976"), "420baa2d-f33d-499d-a92b-a7dfe6d28c4e", new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(6432), "Nhân Viên", new Guid("99ef88a8-d94b-469e-bac0-39694b407976"), 1, "Nhân Viên", null, "NV" },
                    { new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"), "c8f3fb8e-5031-4cb8-9c48-cda20319eaa7", new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(6696), "Người Dùng", new Guid("353f756f-ae8d-49b5-b922-9d54ca0b9c2d"), 1, "Người Dùng", null, "ND" },
                    { new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"), "9643abcb-71b7-475a-a586-dc495a8b7747", new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(6706), "Quản Lý", new Guid("4fd681b6-5dd2-4a5a-aa9e-b2806c61d4ca"), 1, "Quản Lý", null, "AD" }
                });

            migrationBuilder.InsertData(
                table: "Saintes",
                columns: new[] { "IdSaints", "DateCreate", "IdStatusSaints", "NameSaints" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9027), 1, "Lễ Chúa Thánh Thần" },
                    { 5, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9025), 1, "Lễ Thánh Nam" },
                    { 4, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9024), 1, "Lễ Thánh Nữ" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(8689), 1, "Lễ Đức Mẹ" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9020), 1, "Lễ Thánh GiuSe" },
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 624, DateTimeKind.Utc).AddTicks(9023), 1, "Lễ Các Thánh Tử Đạo " }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "IdSeason", "DateCreate", "IdStatusSeason", "NameSeason" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1234), 1, "Mùa Phục Sinh" },
                    { 1, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(945), 1, "Mùa Thường Niên" },
                    { 2, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1229), 1, "Mùa Vọng" },
                    { 3, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1233), 1, "Mùa Giáng Sinh" },
                    { 5, new DateTime(2022, 7, 27, 10, 48, 52, 625, DateTimeKind.Utc).AddTicks(1235), 1, "Mùa Chay" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerComments_IdComment",
                table: "AnswerComments",
                column: "IdComment");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerComments_IdUser",
                table: "AnswerComments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerGmailRequestPasswords_IdRequestPassword",
                table: "AnswerGmailRequestPasswords",
                column: "IdRequestPassword");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRequests_IdRead",
                table: "AnswerRequests",
                column: "IdRead");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRequests_IdRequest",
                table: "AnswerRequests",
                column: "IdRequest");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRequests_IdTypeSent",
                table: "AnswerRequests",
                column: "IdTypeSent");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRequests_IdUser",
                table: "AnswerRequests",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_BirthdayUsers_T_UsersIdUser",
                table: "BirthdayUsers",
                column: "T_UsersIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CommentMusics_IdMusic",
                table: "CommentMusics",
                column: "IdMusic");

            migrationBuilder.CreateIndex(
                name: "IX_CommentMusics_IdUser",
                table: "CommentMusics",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_IdCity",
                table: "Districts",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_DowloadMusics_IdMusic",
                table: "DowloadMusics",
                column: "IdMusic");

            migrationBuilder.CreateIndex(
                name: "IX_FileMusics_IdMusic",
                table: "FileMusics",
                column: "IdMusic");

            migrationBuilder.CreateIndex(
                name: "IX_HappyBirthdayStaffs_IdUser",
                table: "HappyBirthdayStaffs",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_HappyBirthdayStaffs_IsStatusSent",
                table: "HappyBirthdayStaffs",
                column: "IsStatusSent");

            migrationBuilder.CreateIndex(
                name: "IX_ImageQRCores_IdMusic",
                table: "ImageQRCores",
                column: "IdMusic");

            migrationBuilder.CreateIndex(
                name: "IX_LikeMusics_IdMusic",
                table: "LikeMusics",
                column: "IdMusic");

            migrationBuilder.CreateIndex(
                name: "IX_LikeMusics_IdUser",
                table: "LikeMusics",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_IdSaints",
                table: "Musics",
                column: "IdSaints");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_IdSeason",
                table: "Musics",
                column: "IdSeason");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_IdStatusMusic",
                table: "Musics",
                column: "IdStatusMusic");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_IdUser",
                table: "Musics",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_IdDeleteNotification",
                table: "NotificationUsers",
                column: "IdDeleteNotification");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_IdUser",
                table: "NotificationUsers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_IdViewNotification",
                table: "NotificationUsers",
                column: "IdViewNotification");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_IdMusic",
                table: "Ratings",
                column: "IdMusic");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_IdUser",
                table: "Ratings",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RequestPasswords_IdReceiveRequest",
                table: "RequestPasswords",
                column: "IdReceiveRequest");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUsers_IdReceiveRequest",
                table: "RequestUsers",
                column: "IdReceiveRequest");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUsers_IdUser",
                table: "RequestUsers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_IdStatusRole",
                table: "Roles",
                column: "IdStatusRole");

            migrationBuilder.CreateIndex(
                name: "IX_Saintes_IdStatusSaints",
                table: "Saintes",
                column: "IdStatusSaints");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_IdStatusSeason",
                table: "Seasons",
                column: "IdStatusSeason");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_IdRole",
                table: "UserRoles",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_IdUser",
                table: "UserRoles",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdAccountActiver",
                table: "Users",
                column: "IdAccountActiver");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdCity",
                table: "Users",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdDistrict",
                table: "Users",
                column: "IdDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdGender",
                table: "Users",
                column: "IdGender");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdLever",
                table: "Users",
                column: "IdLever");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdMarriage",
                table: "Users",
                column: "IdMarriage");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdStaffOrUser",
                table: "Users",
                column: "IdStaffOrUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusStaffOff",
                table: "Users",
                column: "StatusStaffOff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerComments");

            migrationBuilder.DropTable(
                name: "AnswerGmailRequestPasswords");

            migrationBuilder.DropTable(
                name: "AnswerRequests");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "BirthdayUsers");

            migrationBuilder.DropTable(
                name: "DowloadMusics");

            migrationBuilder.DropTable(
                name: "FileMusics");

            migrationBuilder.DropTable(
                name: "HappyBirthdayStaffs");

            migrationBuilder.DropTable(
                name: "ImageQRCores");

            migrationBuilder.DropTable(
                name: "LikeMusics");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "NotificationUsers");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "CommentMusics");

            migrationBuilder.DropTable(
                name: "RequestPasswords");

            migrationBuilder.DropTable(
                name: "ReadUsers");

            migrationBuilder.DropTable(
                name: "RequestUsers");

            migrationBuilder.DropTable(
                name: "TypeSentUsers");

            migrationBuilder.DropTable(
                name: "StatusHappyBirthDayStaffs");

            migrationBuilder.DropTable(
                name: "DeleteNotifications");

            migrationBuilder.DropTable(
                name: "ViewNotifications");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Musics");

            migrationBuilder.DropTable(
                name: "ReceiveRequests");

            migrationBuilder.DropTable(
                name: "StatusRoles");

            migrationBuilder.DropTable(
                name: "Saintes");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "StatusMusics");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "StatusSaintes");

            migrationBuilder.DropTable(
                name: "StatusSeasons");

            migrationBuilder.DropTable(
                name: "ActiverAccounts");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "LeverUsers");

            migrationBuilder.DropTable(
                name: "Marriages");

            migrationBuilder.DropTable(
                name: "StaffOrUsers");

            migrationBuilder.DropTable(
                name: "StatusStaffOffs");

            migrationBuilder.DropTable(
                name: "Citys");
        }
    }
}
