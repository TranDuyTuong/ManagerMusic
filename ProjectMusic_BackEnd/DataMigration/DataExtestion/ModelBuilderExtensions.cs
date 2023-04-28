using DataTable.Table.Account;
using DataTable.Table.Address;
using DataTable.Table.Gender;
using DataTable.Table.Marriage;
using DataTable.Table.Music;
using DataTable.Table.RequestUser;
using DataTable.Table.Role;
using DataTable.Table.Saints;
using DataTable.Table.Season;
using DataTable.Table.Staff;
using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataMigration.DataExtestion
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_City>().HasData(
                new T_City() { IdCity = 1, NameCity = "Thành Phố Hồ Chí Mình", DateCreate = DateTime.UtcNow.AddHours(7), Symbol="SG", AreaCode=28, Status = true},
                new T_City() { IdCity = 2, NameCity = "Thủ Đô Hà Nội", DateCreate = DateTime.UtcNow.AddHours(7), Symbol="HN", AreaCode=24, Status = true }
                );
            modelBuilder.Entity<T_District>().HasData(
                new T_District() {IdDistrict = 1, NameDistrict= "Quận 1", DateCreate = DateTime.UtcNow.AddHours(7), IdCity = 1, Status = true }
                );

            modelBuilder.Entity<T_Gender>().HasData(
                new T_Gender() { IdGender = 1, NameGender = "Nam", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Gender() { IdGender = 2, NameGender = "Nữ", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Gender() { IdGender = 3, NameGender = "Giới Tính Khác", DateCreate = DateTime.UtcNow.AddHours(7)}
                );

            modelBuilder.Entity<T_Marriage>().HasData(
                new T_Marriage() { IdMarriage = 1, NameMarriage = "Độc Thân", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Marriage() { IdMarriage = 2, NameMarriage = "Đã Kết Hôn", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Marriage() { IdMarriage = 3, NameMarriage = "Đã Ly Hôn", DateCreate = DateTime.UtcNow.AddHours(7)}
                );

            modelBuilder.Entity<T_StatusMusic>().HasData(
                new T_StatusMusic() { IdStatusMusic = 1, NameStatusMusic = "Đang Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_StatusMusic() { IdStatusMusic = 2, NameStatusMusic = "Ngưng Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_StatusMusic() { IdStatusMusic = 3, NameStatusMusic = "Đã Xóa", DateCreate = DateTime.UtcNow.AddHours(7)}
                );

            modelBuilder.Entity<T_ReadUser>().HasData(
                new T_ReadUser() { IdRead = 1, ReadContent = "Đã Đọc", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_ReadUser() { IdRead = 2, ReadContent = "Chưa Đọc", DateCreate = DateTime.UtcNow.AddHours(7)}
                );

            modelBuilder.Entity<T_ReceiveRequest>().HasData(
                new T_ReceiveRequest() { IdReceiveRequest = 1, Description = "Chưa Giải Quyết", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_ReceiveRequest() { IdReceiveRequest = 2, Description = "Đang Giải Quyết", DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_ReceiveRequest() { IdReceiveRequest = 3, Description = "Đã Giải Quyết", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_TypeSentUser>().HasData(
                new T_TypeSentUser() { IdTypeSent = 1, NameType = "Gửi Qua Gmail", DateCreate = DateTime.UtcNow.AddHours(7), Status = true },
                new T_TypeSentUser() { IdTypeSent = 2, NameType = "Gửi Qua Tin Nhắn Website", DateCreate = DateTime.UtcNow.AddHours(7), Status = true }
                );

            modelBuilder.Entity<T_StatusRole>().HasData(
                new T_StatusRole() { IdStatusRole = 1, NameStatus = "Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_StatusRole() { IdStatusRole = 2, NameStatus = "Ngưng Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_Role>().HasData(
                new T_Role() 
                { 
                    Id = new Guid("99EF88A8-D94B-469E-BAC0-39694B407976"), 
                    IdRole = new Guid("99EF88A8-D94B-469E-BAC0-39694B407976"), 
                    IdStatusRole = 1, 
                    SymbolRole = "NV",
                    Name = "Nhân Viên",
                    Description = "Nhân Viên", 
                    DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Role()
                {
                    Id = new Guid("353F756F-AE8D-49B5-B922-9D54CA0B9C2D"),
                    IdRole = new Guid("353F756F-AE8D-49B5-B922-9D54CA0B9C2D"),
                    IdStatusRole = 1,
                    SymbolRole = "ND",
                    Name = "Người Dùng",
                    Description = "Người Dùng",
                    DateCreate = DateTime.UtcNow.AddHours(7)
                },
                new T_Role()
                {
                    Id = new Guid("4FD681B6-5DD2-4A5A-AA9E-B2806C61D4CA"),
                    IdRole = new Guid("4FD681B6-5DD2-4A5A-AA9E-B2806C61D4CA"),
                    IdStatusRole = 1,
                    SymbolRole = "AD",
                    Name = "Quản Lý",
                    Description = "Quản Lý",
                    DateCreate = DateTime.UtcNow.AddHours(7)
                }
                );

            modelBuilder.Entity<T_StatusSaints>().HasData(
                new T_StatusSaints() { IdIdStatusSaints = 1, NameStatusSaints = "Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_StatusSaints() { IdIdStatusSaints = 2, NameStatusSaints = "Ngưng Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_Saints>().HasData(
                new T_Saints() { IdSaints = 1, NameSaints = "Lễ Đức Mẹ", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Saints() { IdSaints = 2, NameSaints = "Lễ Thánh GiuSe", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Saints() { IdSaints = 3, NameSaints = "Lễ Các Thánh Tử Đạo ", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Saints() { IdSaints = 4, NameSaints = "Lễ Thánh Nữ", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Saints() { IdSaints = 5, NameSaints = "Lễ Thánh Nam", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Saints() { IdSaints = 6, NameSaints = "Lễ Chúa Thánh Thần", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Saints() { IdSaints = 7, NameSaints = "Lễ Về Ơn Gọi", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Saints() { IdSaints = 8, NameSaints = "Không thuộc lễ ngoại lịch", IdStatusSaints = 1, DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_StatusSeason>().HasData(
                new T_StatusSeason() { IdStatusSeason = 1, NameStatus = "Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_StatusSeason() { IdStatusSeason = 2, NameStatus = "Ngưng Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_Season>().HasData(
                new T_Season() { IdSeason = 1, NameSeason = "Mùa Thường Niên", IdStatusSeason = 1, DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_Season() { IdSeason = 2, NameSeason = "Mùa Vọng", IdStatusSeason = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Season() { IdSeason = 3, NameSeason = "Mùa Giáng Sinh", IdStatusSeason = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Season() { IdSeason = 4, NameSeason = "Mùa Phục Sinh", IdStatusSeason = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Season() { IdSeason = 5, NameSeason = "Mùa Chay", IdStatusSeason = 1, DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_Season() { IdSeason = 6, NameSeason = "Ngoại Lịch", IdStatusSeason = 1, DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_StatusHappyBirthDayStaff>().HasData(
                new T_StatusHappyBirthDayStaff() { IsStatusSent = 1, Description = "Gửi Thành Công", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_StatusHappyBirthDayStaff() { IsStatusSent = 2, Description = "Gửi Thất Bại", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_StatusStaffOff>().HasData(
                new T_StatusStaffOff() { StatusStaffOff = 1, Description = "Còn Làm", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_StatusStaffOff() { StatusStaffOff = 2, Description = "Nghĩ Làm", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_DeleteNotification>().HasData(
                new T_DeleteNotification() { IdDeleteNotification = 1, Description = "Chưa Xóa Thông Báo", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_DeleteNotification() { IdDeleteNotification = 2, Description = "Đã Xóa Thông Báo", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_LeverUser>().HasData(
                new T_LeverUser() 
                    { 
                        IdLever = 1, 
                        Name = "Cấp Độ Đồng", 
                        DescriptionName = "- Đây là cấp độ thấp nhất các tài khoản ở cấp độ này chỉ được phép dùng từ 1 đến 2 chức năng của hệ thống, đa số ở cấp độ này sẻ là người dùng là chủ yếu họ chỉ được thao tác các chức năng mà được cấp phép.", 
                        DateCreate = DateTime.UtcNow.AddHours(7)
                    },
                new T_LeverUser() 
                    { 
                        IdLever = 2, 
                        Name = "Cấp Độ Bạc", 
                        DescriptionName = "- Đây là cấp độ ở mức trung bình không nhỏ cũng không lớn, đa số các tài khoản ở cấp độ này sẻ là các cộng tác viên được cấp độ vàng phân quyền cho, vì vậy với cấp độ bạc bạn sẻ bị hạn chế một vài chức năng của hệ thống mà bạn không được phép dùng.", 
                        DateCreate = DateTime.UtcNow.AddHours(7) 
                    },
                new T_LeverUser() 
                    { 
                        IdLever = 3, 
                        Name = "Cấp Độ Vàng", 
                        DescriptionName = "- Đây là cấp độ lớn nhất của hệ thống, với cấp độ này thì được phép dùng tất cả chức năng có trong hệ thống, quản lý toàn bộ các cấp độ khác nhỏ hơn, quản trị toàn bộ dữ liệu thông tin của hệ thống.", 
                        DateCreate = DateTime.UtcNow.AddHours(7) 
                    }
                );

            modelBuilder.Entity<T_StaffOrUser>().HasData(
                new T_StaffOrUser() { IdStaffOrUser = 1, symbol = "ND", Description = "Người Dùng", DateCreate = DateTime.UtcNow.AddHours(7), Status = true },
                new T_StaffOrUser() { IdStaffOrUser = 2, symbol = "NV", Description = "Nhân Viên", DateCreate = DateTime.UtcNow.AddHours(7), Status = true }
                );

            modelBuilder.Entity<T_ViewNotification>().HasData(
                new T_ViewNotification() { IdViewNotification = 1, Description = "Đã Xem", DateCreate = DateTime.UtcNow.AddHours(7) },
                new T_ViewNotification() { IdViewNotification = 2, Description = "Chưa Xem", DateCreate = DateTime.UtcNow.AddHours(7) }
                );

            modelBuilder.Entity<T_ActiverAccount>().HasData(
                new T_ActiverAccount() { IdAccountActiver = 1, NameAccountActiver = "Hoạt Động", DateCreate = DateTime.UtcNow.AddHours(7)},
                new T_ActiverAccount() { IdAccountActiver = 2, NameAccountActiver = "Đang Bị Khóa", DateCreate = DateTime.UtcNow.AddHours(7)}
                );

            modelBuilder.Entity<T_StatusPlan>().HasData(
                new T_StatusPlan() { IdStatusPlan = 1, NameStauts = "Hoàn Thành" },
                new T_StatusPlan() { IdStatusPlan = 2, NameStauts = "Hủy Bỏ" },
                new T_StatusPlan() { IdStatusPlan = 3, NameStauts = "Chưa Hoàn Thành" },
                new T_StatusPlan() { IdStatusPlan = 4, NameStauts = "Đang Thực Hiện" },
                new T_StatusPlan() { IdStatusPlan = 5, NameStauts = "Chưa Thực Hiện" }
            );

        }
    }
}
