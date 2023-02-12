using DataMigration.DataEF;
using DataService.ServiceUser.NotificatonUser;
using DataTable.Table.Role;
using DataTable.Table.Staff;
using DataTable.Table.User;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using DataViewModel.ViewModelAdmin.Role_Vm;
using DataViewModel.ViewModelAdmin.User_Vm;
using DataViewModel.ViewModelAdmin.Users_Vm;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.Notification_Vm;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.User
{
    public class Users : IUser
    {
        private readonly ContextDB context;
        private readonly UserManager<T_User> userManager;
        private readonly INotificationUser notificationUser;
        private readonly IConfiguration _config;
        public Users(ContextDB _context, UserManager<T_User> _userManager, INotificationUser _notificationUser, IConfiguration config)
        {
            context = _context;
            userManager = _userManager;
            notificationUser = _notificationUser;
            _config = config;
        }

        //cretae chat like staff
        public async Task<GetAllChatBy_Staff> CreateChatIconMessage(CreateChatStaff_V request)
        {
            var result = new GetAllChatBy_Staff();
            result = await CreateChatStaff(request);
            return result;
        }

        //create chat staff
        public async Task<GetAllChatBy_Staff> CreateChatStaff(CreateChatStaff_V request)
        {
            var QueryAllUser = await context.T_Users.ToListAsync();
            var QueryUser = QueryAllUser.FirstOrDefault(x => x.IdUser == request.IdUser);
            var result = new GetAllChatBy_Staff();
            if (QueryUser == null)
            {
                result.Status = false;
            }
            else
            {
                var data_C = new T_ChatStaff()
                {
                    IdUser = request.IdUser,
                    FullName = request.FullName,
                    DateCreate = request.DateCreate,
                    Message = request.Message
                };
                await context.AddAsync(data_C);
                await context.SaveChangesAsync();

                //add notification for all user
                var GetUser = QueryAllUser.Where(x => x.IdUser != request.IdUser && x.IdStaff != null).ToList();
                foreach (var item in GetUser)
                {
                    item.TotalChat = item.TotalChat + 1;
                    item.WasView = true;
                    context.T_Users.Update(item);
                }
                await context.SaveChangesAsync();

                result.L_Chat = L_ChatStaff();
                result.IdUser = request.IdUser;
                result.Status = true;
            }
            return result;
        }

        private List<CreateChatStaff_V> L_ChatStaff()
        {
            var Query = context.T_ChatStaffs.ToList();
            var Query_Img = context.T_Users.ToList();
            var Query_ListImg = context.T_ChatImageStaffs.ToList();

            List<CreateChatStaff_V> L_Chat = new List<CreateChatStaff_V>();
            foreach (var item in Query)
            {
                var CheckData = Query_Img.FirstOrDefault(x => x.IdUser == item.IdUser);
                var GetListImg = Query_ListImg.Where(x => x.IdChat == item.Id).ToList();
                var Chirl = new CreateChatStaff_V()
                {
                    Id = item.Id,
                    IdUser = item.IdUser,
                    FullName = item.FullName,
                    DateCreate = item.DateCreate,
                    DateCreate_C = item.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = item.DateCreate.ToShortTimeString(),
                    ImageAvata = CheckData.ImageAvata,
                    Message = item.Message
                };

                if (GetListImg.Count() != 0)
                {
                    List<GetAllChatImages_V> result_L = new List<GetAllChatImages_V>();
                    foreach (var itemChirl in GetListImg)
                    {
                        var GetData = new GetAllChatImages_V()
                        {
                            Id = itemChirl.Id,
                            NameImage = itemChirl.NameImage,
                            TypeImage = itemChirl.TypeImage,
                            ContentImage_Doc = itemChirl.FileImage,
                            DateCreate = itemChirl.DateCreate,
                            MimeType = itemChirl.MimeType,
                            IdChat = itemChirl.IdChat,
                            //ImgBase64 = itemChirl.ImageBase64
                        };
                        result_L.Add(GetData);
                    }
                    Chirl.L_Images = result_L;
                }

                L_Chat.Add(Chirl);
            }
            return L_Chat;
        }

        //create staff
        public async Task<NotificationRegiter_V> CreateSatff(CreateSatff_V request)
        {
            var NotificationUser = new NotificationRegiter_V();
            var QueryRole = context.T_Roles.FirstOrDefault(x => x.IdRole == request.IdRole);
            var DataEmail = await userManager.FindByEmailAsync(request.Email);
            if (DataEmail != null)
            {
                NotificationUser.Status = false;
                NotificationUser.Notification = "Email already exists, please change Email!";
                NotificationUser.IsStatus = 1;
                return NotificationUser;
            }
            var IdGuild = new Guid();
            var Regiter = new T_User()
            {
                IdUser = IdGuild,
                IdStaff = request.IdStaff,
                IdAccountActiver = request.IdAccountActiver,
                StatusStaffOff = request.StatusStaffOff,
                IdStaffOrUser = request.IdStaffOrUser,
                IdLever = request.IdLever,
                IdGender = request.IdGender,
                IdCity = request.IdCity,
                IdDistrict = request.IdDistrict,
                FullName = request.FullName,
                UserName = request.Email,
                Birthday = request.Birthday,
                Date = request.Birthday.Day,
                Month = request.Birthday.Month,
                Year = request.Birthday.Year,
                Email = request.Email,
                IdMarriage = request.IdMarriage,
                AddressSatff = request.AddressSatff,
                PhoneStaff = request.PhoneStaff,
                DateCreate = request.DateCreate,
                Age = request.Age,
                PhoneNumber = request.PhoneStaff,
                ImageAvata = request.ImageAvataConver,
                TokenData = request.TokenData,
                TypeImage = request.TypeImage,
                NameFile = request.NameImage,
                CancelHideStaff = 1 //hide staff
            };
            var Result = await userManager.CreateAsync(Regiter, request.Password);
            if (Result.Succeeded == true)
            {
                var AddIdUser = context.T_Users.FirstOrDefault(x => x.IdUser == Regiter.IdUser);
                AddIdUser.Id = Regiter.IdUser;
                context.T_Users.Update(AddIdUser);

                var RoleUser = new T_UserRole()
                {
                    IdRole = QueryRole.IdRole,
                    IdUser = Regiter.IdUser
                };
                context.T_UserRoles.Add(RoleUser);
                //add notification
                var L_AllUser = GetAllUser();
                if (L_AllUser.Count() != 0)
                {
                    foreach (var item in L_AllUser)
                    {
                        var Result_N = new CreateNotification_v()
                        {
                            IdUser = item.IdUser,
                            IdViewNotification = 2,
                            IdDeleteNotification = 1,
                            TitleNotification = "Có một nhân viên đã đăng ký tài khoản là: " + AddIdUser.FullName,
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = AddIdUser.FullName,
                        };
                        notificationUser.CreateNotification(Result_N);
                    }
                }
                context.SaveChanges();

                NotificationUser.Status = true;
                NotificationUser.Notification = "Regiter account success, you can go to login";
                NotificationUser.IsStatus = 2;
                return NotificationUser;
            }
            NotificationUser.Status = false;
            NotificationUser.Notification = "Regiter error, please try again!";
            NotificationUser.IsStatus = 4;
            return NotificationUser;
        }

        //get all gender
        public List<GetAllGender_V> GetAllGender()
        {
            var Query = from g in context.T_Genders
                        select new { g };
            var result = Query.OrderBy(x => x.g.NameGender).Select(x => new GetAllGender_V
            {
                Id = x.g.IdGender,
                Name = x.g.NameGender
            }).ToList();
            return result;
        }

        //get all marriage
        public List<GetAllMarriage_V> GetAllMarriage()
        {
            var Query = from m in context.T_Marriages
                        select new { m };
            var result = Query.OrderBy(x => x.m.NameMarriage).Select(x => new GetAllMarriage_V
            {
                Id = x.m.IdMarriage,
                Name = x.m.NameMarriage
            }).ToList();
            return result;
        }

        //get all staff
        public List<GetAllUser_v> GetAllStaff()
        {
            var Query = from U in context.T_Users
                        join R in context.T_UserRoles on U.IdUser equals R.IdUser
                        join N in context.T_Roles on R.IdRole equals N.IdRole
                        join A in context.T_ActiverAccounts on U.IdAccountActiver equals A.IdAccountActiver
                        where U.CancelHideStaff != 2 && U.StatusStaffOff == 1
                        && U.IdStaff != null && U.IdStaffOrUser == 2 && U.IdAccountActiver == A.IdAccountActiver
                        select new { U, R, N, A };
            var result = Query.OrderBy(x => x.U.FullName).Select(x => new GetAllUser_v()
            {
                IdUser = x.U.IdUser,
                FullName = x.U.FullName,
                DateCreate = x.U.DateCreate.ToString("dd/MM/yyyy"),
                ImageStaff = x.U.ImageAvata,
                IdRole = x.R.IdRole,
                NameRole = x.N.Name,
                Birthday_TypeDate = x.U.Birthday,
                IdStaff = x.U.IdStaff,
                TotalChat = x.U.TotalChat,
                WasWiew = x.U.WasView,
                TypeImage = x.U.TypeImage,
                NameFile = x.U.NameFile,
                IdAccountActiver = x.U.IdAccountActiver,
                AccountActiver = x.A.NameAccountActiver
            }).ToList();
            return result;
        }

        //get all status Account
        public List<GetAllStatusAccount_V> GetAllStatusAccount()
        {
            var Query = from s in context.T_ActiverAccounts
                        select new { s };
            var result = Query.OrderBy(x => x.s.NameAccountActiver).Select(x => new GetAllStatusAccount_V
            {
                Id = x.s.IdAccountActiver,
                Name = x.s.NameAccountActiver
            }).ToList();
            return result;
        }

        //get all uer
        public List<GetAllUser_v> GetAllUser()
        {
            var Query = from U in context.T_Users
                        join
Sex in context.T_Genders on U.IdGender equals Sex.IdGender
                        join
AActiver in context.T_ActiverAccounts on U.IdAccountActiver equals AActiver.IdAccountActiver
                        join
Lever in context.T_LeverUsers on U.IdLever equals Lever.IdLever
                        join
City in context.T_Cities on U.IdCity equals City.IdCity
                        join
District in context.T_Districts on U.IdDistrict equals District.IdDistrict
                        select new { U, Sex, AActiver, Lever, City, District };
            var result = Query.OrderBy(x => x.U.FullName).Select(x => new GetAllUser_v()
            {
                IdUser = x.U.IdUser,
                AccountActiver = x.AActiver.NameAccountActiver,
                Lever = x.Lever.Name,
                IdStaffOrUser = x.U.IdAccountActiver,
                Gender = x.Sex.NameGender,
                City = x.City.NameCity,
                District = x.District.NameDistrict,
                Birthday = x.U.Birthday.ToString("dd/MM/yyyy"),
                FullName = x.U.FullName,
                Date = x.U.Birthday.Day,
                Month = x.U.Month,
                Year = x.U.Year,
                DateCreate = x.U.DateCreate.ToString("dd/MM/yyyy"),
                Age = x.U.Age,
                Email = x.U.Email
            }).ToList();
            return result;
        }

        //get lever by id role
        public GetAllLever_V GetLeverByIdRole(Guid idRole)
        {
            var Query_Role = context.T_Roles.FirstOrDefault(x => x.IdRole == idRole);
            var Query_Lever = context.T_LeverUsers.ToList();
            var result = new GetAllLever_V();

            switch (Query_Role.SymbolRole)
            {
                case "ND":
                    var data_ND = Query_Lever.FirstOrDefault(x => x.IdLever == 1);
                    result.Id = data_ND.IdLever;
                    result.NameLever = data_ND.Name;
                    result.Description = data_ND.DescriptionName;
                    break;
                case "NV":
                    var data_NV = Query_Lever.FirstOrDefault(x => x.IdLever == 2);
                    result.Id = data_NV.IdLever;
                    result.NameLever = data_NV.Name;
                    result.Description = data_NV.DescriptionName;
                    break;
                case "AD":
                    var data_AD = Query_Lever.FirstOrDefault(x => x.IdLever == 3);
                    result.Id = data_AD.IdLever;
                    result.NameLever = data_AD.Name;
                    result.Description = data_AD.DescriptionName;
                    break;
                default:
                    return result;
            }
            return result;
        }

        //loading chat message
        public async Task<GetAllChatBy_Staff> LoadingMessage()
        {
            var result = new GetAllChatBy_Staff();
            result.L_Chat = L_ChatStaff();
            result.Status = true;
            return result;
        }

        //get info user by id chat
        public async Task<GetInfoChatUser_V> InfoUserChat(int IdChat)
        {
            var QueryChat = await context.T_ChatStaffs.ToListAsync();
            var result = new GetInfoChatUser_V();
            var Query = QueryChat.FirstOrDefault(x => x.Id == IdChat);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == Query.IdUser);
            var QueryRoleUser = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == QueryUser.IdUser);
            var QueryRole = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == QueryRoleUser.IdRole);

            result.IdChat = Query.Id;
            result.IdUser = QueryUser.IdUser;
            result.NameUser = QueryUser.FullName;
            result.IdRole = QueryRole.IdRole;
            result.NameRole = QueryRole.Name;
            result.TotalChat = QueryChat.Where(x => x.IdUser == QueryUser.IdUser).Count();
            result.Avata = QueryUser.ImageAvata;

            List<CreateChatStaff_V> L_Chat = new List<CreateChatStaff_V>();
            foreach (var item in QueryChat.Where(x => x.IdUser == QueryUser.IdUser).ToList())
            {
                var results = new CreateChatStaff_V()
                {
                    Id = item.Id,
                    IdUser = item.IdUser,
                    FullName = item.FullName,
                    DateCreate_C = item.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = item.DateCreate.ToShortTimeString(),
                    ImageAvata = result.Avata,
                    Message = item.Message
                };
                L_Chat.Add(results);
            }
            result.L_Chat = L_Chat;

            return result;
        }

        //sent images chat staff
        public async Task<GetAllChatBy_Staff> CreateImagesChat(CreateChatStaff_V request)
        {
            var QueryAllUser = await context.T_Users.ToListAsync();
            var Query_User = QueryAllUser.FirstOrDefault(x => x.IdUser == request.IdUser);
            var result = new GetAllChatBy_Staff();
            if (Query_User == null)
            {
                result.Status = false;
            }
            else
            {
                var data_C = new T_ChatStaff()
                {
                    IdUser = request.IdUser,
                    FullName = request.FullName,
                    DateCreate = request.DateCreate,
                    Message = request.Message
                };
                await context.T_ChatStaffs.AddAsync(data_C);
                await context.SaveChangesAsync();

                //save list image
                foreach (var item in request.L_Images)
                {
                    var setData = new T_ChatImageStaff()
                    {
                        NameImage = item.NameImage,
                        TypeImage = item.TypeImage,
                        FileImage = item.ContentImage_Doc,
                        DateCreate = item.DateCreate,
                        MimeType = item.MimeType,
                        //ImageBase64 = item.ImgBase64,
                        IdChat = data_C.Id
                    };
                    await context.T_ChatImageStaffs.AddAsync(setData);
                }

                //add notification for all user
                var GetUser = QueryAllUser.Where(x => x.IdUser != request.IdUser && x.IdStaff != null).ToList();
                foreach (var item in GetUser)
                {
                    item.TotalChat = item.TotalChat + 1;
                    item.WasView = true;
                    context.T_Users.Update(item);
                }

                await context.SaveChangesAsync();
                result.L_Chat = L_ChatStaff();
                result.IdUser = request.IdUser;
                result.Status = true;
            }
            return result;
        }

        //get image by id 
        public async Task<GetAllChatImages_V> GetImageBy_Id(int Id_File)
        {
            var Query = await context.T_ChatImageStaffs.FirstOrDefaultAsync(x => x.Id == Id_File);
            var result = new GetAllChatImages_V();
            if (Query == null)
            {
                result.Id = 0;
            }
            else
            {
                result.Id = Query.Id;
                result.NameImage = Query.NameImage;
                result.TypeImage = Query.TypeImage;
                result.ContentImage_Doc = Query.FileImage;
                result.DateCreate = Query.DateCreate;
                result.MimeType = Query.MimeType;
                //result.ImgBase64 = Query.ImageBase64;
            }
            return result;
        }

        //dowload file in messahe by id image
        public async Task<GetAllChatImages_V> DowloadFile_ById(int Id_File)
        {
            var Query = await context.T_ChatImageStaffs.FirstOrDefaultAsync(x => x.Id == Id_File);
            var result = new GetAllChatImages_V();
            if (Query == null)
            {
                result.Id = 0;
            }
            else
            {
                if (Query.MimeType == null)
                {
                    result.Id = 0;
                }
                else
                {
                    result.Id = Query.Id;
                    result.MimeType = Query.MimeType;
                    result.ContentImage_Doc = Query.FileImage;
                }
            }
            return result;
        }

        //get all images show slider in message
        public List<GetAllChatImages_V> ShowImagesSliderMessage()
        {
            var Query = from Img in context.T_ChatImageStaffs
                        where Img.MimeType == null
                        select new { Img };
            var result = Query.OrderByDescending(x => x.Img.Id).Select(x => new GetAllChatImages_V()
            {
                Id = x.Img.Id,
                NameImage = x.Img.NameImage,
                TypeImage = x.Img.TypeImage,
                ContentImage_Doc = x.Img.FileImage,
                DateCreate = x.Img.DateCreate,
                MimeType = x.Img.MimeType,
                //ImgBase64 = x.Img.ImageBase64,
                IdChat = x.Img.IdChat,
                DateCreateStr = x.Img.DateCreate.ToString("dd/MM/yyyy")
            }).ToList();
            return result;
        }

        //get all file in message
        public List<GetAllFileMessage_V> GetAllFileInMessage()
        {
            var Result = context.T_ChatStaffs.Where(x => x.Message == "Images").ToList();
            var Query_File = context.T_ChatImageStaffs.Where(x => x.MimeType != null).ToList();
            List<GetAllFileMessage_V> L_FileChat = new List<GetAllFileMessage_V>();
            foreach (var item in Result)
            {
                var CheckData = Query_File.Where(x => x.IdChat == item.Id);
                if (CheckData.Count() != 0)
                {
                    var setkey = new GetAllFileMessage_V();
                    setkey.Key_Date = item.DateCreate;
                    setkey.Date_String = item.DateCreate.ToString("dd/MM/yyyy");

                    if (L_FileChat.FirstOrDefault(x => x.Date_String == item.DateCreate.ToString("dd/MM/yyyy")) != null)
                    {
                        var Seach_Item = L_FileChat.FirstOrDefault(x => x.Date_String == item.DateCreate.ToString("dd/MM/yyyy"));
                        foreach (var items in CheckData)
                        {
                            var Data_Item = new GetAllChatImages_V()
                            {
                                Id = items.Id,
                                NameImage = items.NameImage,
                                TypeImage = items.TypeImage,
                                ContentImage_Doc = items.FileImage,
                                DateCreate = items.DateCreate,
                                DateCreateStr = items.DateCreate.ToString("dd/MM/yyyy"),
                                TimeCreate = items.DateCreate.ToShortTimeString(),
                                MimeType = items.MimeType,
                                IdChat = items.IdChat,
                                NameUser = item.FullName
                            };
                            Seach_Item.LFile_Message.Add(Data_Item);
                        }
                    }
                    else
                    {
                        foreach (var items in CheckData)
                        {
                            var Data_Item = new GetAllChatImages_V()
                            {
                                Id = items.Id,
                                NameImage = items.NameImage,
                                TypeImage = items.TypeImage,
                                ContentImage_Doc = items.FileImage,
                                DateCreate = items.DateCreate,
                                DateCreateStr = items.DateCreate.ToString("dd/MM/yyyy"),
                                TimeCreate = items.DateCreate.ToShortTimeString(),
                                MimeType = items.MimeType,
                                IdChat = items.IdChat,
                                NameUser = item.FullName
                            };
                            setkey.LFile_Message.Add(Data_Item);
                        }
                        L_FileChat.Add(setkey);
                    }
                }
            }
            return L_FileChat.OrderByDescending(x => x.Key_Date).ToList();
        }

        //get total chat by id user
        public async Task<GetAllUser_v> GetTotalByIdUser(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            var result = new GetAllUser_v();
            if (QueryUser != null)
            {
                result.TotalChat = QueryUser.TotalChat;
                result.IdUser = QueryUser.IdUser;
                result.FullName = QueryUser.FullName;
                result.IdStaff = QueryUser.IdStaff;
            }
            else
            {
                result.TotalChat = 0;
            }
            return result;
        }

        //was view message by id user
        public async Task<bool> WasViewMessageByIdUser(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            if (QueryUser != null)
            {
                QueryUser.TotalChat = 0;
                QueryUser.WasView = false;
                context.T_Users.Update(QueryUser);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        // get update staff
        public async Task<UpdateStaff_V> Get_UpdateStaff(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            var QueryMarriage = await context.T_Marriages.ToListAsync();
            var result = new UpdateStaff_V();
            if (QueryUser != null)
            {
                List<GetAllMarriage_V> L_Marriage = new List<GetAllMarriage_V>();
                result.IdUser = QueryUser.IdUser;
                result.IdStaff = QueryUser.IdStaff;
                result.FullName = QueryUser.FullName;
                result.IdMarriage = Convert.ToInt32(QueryUser.IdMarriage);
                result.NameMarrige = QueryMarriage.FirstOrDefault(x => x.IdMarriage == result.IdMarriage).NameMarriage;
                result.AddressUser = QueryUser.AddressSatff;
                result.Gmail = QueryUser.Email;
                result.PhoneNumber = QueryUser.PhoneNumber;
                result.AvataUser = QueryUser.ImageAvata;
                foreach (var item in QueryMarriage.Where(x => x.IdMarriage != result.IdMarriage).ToList())
                {
                    var SetData = new GetAllMarriage_V()
                    {
                        Id = item.IdMarriage,
                        Name = item.NameMarriage
                    };
                    L_Marriage.Add(SetData);
                }
                result.L_Marriage = L_Marriage;
            }
            else
            {
                result.IdStaff = "0";
            }
            return result;
        }

        // post update staff
        public async Task<NotificationUser_V> Post_UpdateStaff(UpdateStaff_V request)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == request.IdUser
                                                                        && x.IdStaff == request.IdStaff);
            var result = new NotificationUser_V();
            if (QueryUser != null)
            {
                if (request.TypeImage != null)
                {
                    QueryUser.IdMarriage = request.IdMarriage;
                    QueryUser.AddressSatff = request.AddressUser;
                    QueryUser.Email = request.Gmail;
                    QueryUser.PhoneNumber = request.PhoneNumber;
                    QueryUser.ImageAvata = request.AvataUser;
                    QueryUser.TypeImage = request.TypeImage;
                    QueryUser.NameFile = request.NameImage;
                    QueryUser.DateUpdate = DateTime.UtcNow.AddHours(7);
                }
                else
                {
                    QueryUser.IdMarriage = request.IdMarriage;
                    QueryUser.AddressSatff = request.AddressUser;
                    QueryUser.Email = request.Gmail;
                    QueryUser.PhoneNumber = request.PhoneNumber;
                    QueryUser.DateUpdate = DateTime.UtcNow.AddHours(7);
                }
                context.T_Users.Update(QueryUser);
                await context.SaveChangesAsync();
                result.IdNotification = 3; //update success
                result.Status = true;
            }
            else
            {
                result.IdNotification = 2; // not find id user
                result.Status = false;
            }
            return result;
        }

        //detail staff
        public async Task<DetailStaff_V> DetailStaff(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            var result = new DetailStaff_V();
            if (QueryUser != null)
            {
                var QueryActiver = await context.T_ActiverAccounts
                                    .FirstOrDefaultAsync(x => x.IdAccountActiver == QueryUser.IdAccountActiver);
                var QueryLever = await context.T_LeverUsers.FirstOrDefaultAsync(x => x.IdLever == QueryUser.IdLever);
                var QueryMarriage = await context.T_Marriages
                                    .FirstOrDefaultAsync(x => x.IdMarriage == QueryUser.IdMarriage);
                var QueryGender = await context.T_Genders.FirstOrDefaultAsync(x => x.IdGender == QueryUser.IdGender);
                var QueryCity = await context.T_Cities.FirstOrDefaultAsync(x => x.IdCity == QueryUser.IdCity);
                var QueryDistrict = await context.T_Districts
                                    .FirstOrDefaultAsync(x => x.IdDistrict == QueryUser.IdDistrict);
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == QueryUser.IdUser);
                var QueryRole = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == QueryUserRole.IdRole);

                result.IdUser = QueryUser.IdUser;
                result.IdStaff = QueryUser.IdStaff;
                result.FullName = QueryUser.FullName;
                result.IdActiver = QueryActiver.IdAccountActiver;
                result.NameActiver = QueryActiver.NameAccountActiver;
                result.IdLever = QueryLever.IdLever;
                result.NameLever = QueryLever.Name;
                result.Birthday = QueryUser.Birthday.ToString("dd/MM/yyyy");
                result.Gmail = QueryUser.Email;
                result.Address = QueryUser.AddressSatff;
                result.Phone = QueryUser.PhoneStaff;
                result.idMariage = QueryMarriage.IdMarriage;
                result.NameMariage = QueryMarriage.NameMarriage;
                result.IdGender = QueryGender.IdGender;
                result.Gender = QueryGender.NameGender;
                result.AvataImage = QueryUser.ImageAvata;
                result.TypeImage = QueryUser.TypeImage;
                result.IdCity = QueryCity.IdCity;
                result.City = QueryCity.NameCity;
                result.IdDistrict = QueryDistrict.IdDistrict;
                result.District = QueryDistrict.NameDistrict;
                result.IdRole = QueryUserRole.IdRole;
                result.NameRole = QueryRole.Name;
                result.HideStaff = Convert.ToInt32(QueryUser.CancelHideStaff);
                if (result.HideStaff == 1)
                {
                    result.NameHideStaff = "Đang Thuê Nhân Viên";
                }
                else
                {
                    result.NameHideStaff = "Đã Hủy Thuê Nhân Viên";
                }
            }
            else
            {
                result.IdStaff = "0";
            }
            return result;
        }

        //block account staff
        public async Task<NotificationUser_V> BockAccount(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            var result = new NotificationUser_V();
            if (QueryUser != null)
            {
                QueryUser.IdAccountActiver = 2;
                QueryUser.DateAccountBlock = DateTime.UtcNow.AddHours(7);
                context.Update(QueryUser);
                await context.SaveChangesAsync();
                result.Status = true;
                result.IdNotification = 1; //Bolck Success
            }
            else
            {
                result.Status = false;
                result.IdNotification = 0; //not find User have this IdUser
            }
            return result;
        }

        //opent lock
        public async Task<NotificationUser_V> OpenLockAccount(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            var result = new NotificationUser_V();
            if (QueryUser != null)
            {
                QueryUser.IdAccountActiver = 1;
                QueryUser.DateAccountBlock = null;
                context.Update(QueryUser);
                await context.SaveChangesAsync();
                result.Status = true;
                result.IdNotification = 1; //open lock Success
            }
            else
            {
                result.Status = false;
                result.IdNotification = 0; //not find User have this IdUser
            }
            return result;
        }

        //cancel hide staff
        public async Task<NotificationUser_V> CancelHideStaff(Guid IdUser)
        {
            var Query_User = await context.T_Users
                                .FirstOrDefaultAsync(x => x.IdUser == IdUser
                                                        && x.IdStaff != null
                                                        && x.CancelHideStaff != 2);
            var result = new NotificationUser_V();
            if (Query_User != null)
            {
                Query_User.IdAccountActiver = 2;
                Query_User.CancelHideStaff = 2;
                context.T_Users.Update(Query_User);
                await context.SaveChangesAsync();
                //add notification
                var L_AllUser = GetAllUser();
                if (L_AllUser.Count() != 0)
                {
                    foreach (var item in L_AllUser)
                    {
                        var Result_N = new CreateNotification_v()
                        {
                            IdUser = item.IdUser,
                            IdViewNotification = 2,
                            IdDeleteNotification = 1,
                            TitleNotification = "Nhân viên " + Query_User.FullName
                                                + "đã hủy hợp đồng với hệ thống Manager Music",
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = Query_User.FullName,
                        };
                        notificationUser.CreateNotification(Result_N);
                    }
                }
                context.SaveChanges();
                result.IdNotification = 1;
                result.Status = true;
            }
            else
            {
                result.IdNotification = 0;
                result.Status = false;
            }
            return result;
        }

        // decentralization role for staff
        public async Task<RoleStaff_V> DecenRoleStaff(Guid IdUser)
        {
            var QueryAllUser = await context.T_Users.Where(x => x.IdStaff != null).ToListAsync();
            var QueryUser = QueryAllUser
                                .FirstOrDefault(x => x.IdUser == IdUser
                                                        && x.IdStaff != null
                                                        && x.CancelHideStaff == 1
                                                        && x.IdAccountActiver == 1);
            var result = new RoleStaff_V();
            if (QueryUser != null)
            {
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == QueryUser.IdUser);
                var QueryRole = await context.T_Roles.ToListAsync();
                var QueryHistoryRole = await context.T_HistoryRoles.Where(x => x.IdUser == QueryUser.IdUser)
                                                                    .OrderByDescending(x => x.Id).ToListAsync();

                result.IdUser = QueryUser.IdUser;
                result.FullName = QueryUser.FullName;
                result.IdRoleCurrent = QueryRole.FirstOrDefault(x => x.IdRole == QueryUserRole.IdRole).IdRole;
                result.NameRoleCurrent = QueryRole.FirstOrDefault(x => x.IdRole == QueryUserRole.IdRole).Name;

                var ListNew_Role = QueryRole.Where(x => x.IdRole != result.IdRoleCurrent && x.SymbolRole != "ND").ToList();
                foreach (var item in ListNew_Role)
                {
                    var SetItem = new GetAllRole_V()
                    {
                        IdRole = item.IdRole,
                        RoleName = item.Name
                    };
                    result.L_Role.Add(SetItem);
                }

                foreach (var item in QueryHistoryRole)
                {
                    var checkRole = QueryRole.FirstOrDefault(x => x.IdRole == item.IdRole);
                    var checkUser = QueryAllUser.FirstOrDefault(x => x.IdUser == item.IdUserDecenRole);
                    var SetItem = new RoleHistoryStaff_V()
                    {
                        Id = item.Id,
                        IdRole = item.IdRole,
                        NameRole = checkRole.Name,
                        StartDate = item.StartDate,
                        TimeSart = item.StartDate.ToShortTimeString(),
                        StartDate_Str = item.StartDate.ToString("dd/MM/yyyy"),
                        //EndDate = (item.EndDate != null) ? Convert.ToDateTime(item.EndDate) : ,
                        TimeEnd = (item.EndDate != null) ? Convert.ToDateTime(item.EndDate).ToShortTimeString() : " ------ ",
                        EndDate_Str = (item.EndDate != null) ? Convert.ToDateTime(item.EndDate).ToString("dd/MM/yyyy") : " ------ ",
                        NameStaff_DecenRole = checkUser.FullName
                    };
                    result.L_HistoryRole.Add(SetItem);
                }

            }
            else
            {
                result.FullName = "NotFindUser";
            }
            return result;
        }

        //change role staff
        public async Task<NotificationUser_V> ChangeRoleStaff(Guid IdUser, Guid IdRole, Guid IdUserDecenRole, Guid IdRoleCurrent)
        {
            var result = new NotificationUser_V();
            var QueryAllUser = await context.T_Users.Where(x => x.IdStaff != null).ToListAsync();
            var QueryUser = QueryAllUser.FirstOrDefault(x => x.IdUser == IdUser);
            if (QueryUser != null)
            {
                var QueryAllRole = await context.T_Roles.Where(x => x.IdStatusRole == 1).ToListAsync();
                var QueryRole = QueryAllRole.FirstOrDefault(x => x.IdRole == IdRole);
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == QueryUser.IdUser);
                var QueryRoleCurent = QueryAllRole.FirstOrDefault(x => x.IdRole == IdRoleCurrent);
                var QueryHistoryRole = await context.T_HistoryRoles.OrderByDescending(x => x.Id)
                                        .FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdRole == IdRoleCurrent && x.EndDate == null);
                string IdStaff_success;
                if (QueryRoleCurent != null)
                {
                    if (QueryRole != null)
                    {
                        switch (QueryRole.SymbolRole)
                        {
                            case "NV":
                                //random Id Staff
                                IdStaff_success = await RandomIdStaff(QueryRole.SymbolRole);
                                //user
                                QueryUser.IdStaff = IdStaff_success;
                                QueryUser.DateUpdate = DateTime.UtcNow.AddHours(7);
                                context.T_Users.Update(QueryUser);
                                //user role
                                QueryUserRole.IdRole = QueryRole.IdRole;
                                QueryUserRole.DateDecentralization = DateTime.UtcNow.AddHours(7);
                                context.T_UserRoles.Update(QueryUserRole);
                                //add history role
                                if (QueryHistoryRole != null)
                                {
                                    QueryHistoryRole.EndDate = DateTime.UtcNow.AddHours(7);
                                    context.T_HistoryRoles.Update(QueryHistoryRole);
                                    var FormRole = new T_HistoryRole()
                                    {
                                        IdRole = QueryUserRole.IdRole,
                                        IdUser = QueryUser.IdUser,
                                        StartDate = DateTime.UtcNow.AddHours(7),
                                        IdUserDecenRole = IdUserDecenRole
                                    };
                                    await context.T_HistoryRoles.AddAsync(FormRole);
                                }
                                else
                                {
                                    var FormRole = new T_HistoryRole()
                                    {
                                        IdRole = QueryUserRole.IdRole,
                                        IdUser = QueryUser.IdUser,
                                        StartDate = DateTime.UtcNow.AddHours(7),
                                        IdUserDecenRole = IdUserDecenRole
                                    };
                                    await context.T_HistoryRoles.AddAsync(FormRole);
                                }
                                break;
                            case "AD":
                                //random Id Staff
                                IdStaff_success = await RandomIdStaff(QueryRole.SymbolRole);
                                //user
                                QueryUser.IdStaff = IdStaff_success;
                                QueryUser.DateUpdate = DateTime.UtcNow.AddHours(7);
                                context.T_Users.Update(QueryUser);
                                //user role
                                QueryUserRole.IdRole = QueryRole.IdRole;
                                QueryUserRole.DateDecentralization = DateTime.UtcNow.AddHours(7);
                                context.T_UserRoles.Update(QueryUserRole);
                                //add history role
                                if (QueryHistoryRole != null)
                                {
                                    QueryHistoryRole.EndDate = DateTime.UtcNow.AddHours(7);
                                    context.T_HistoryRoles.Update(QueryHistoryRole);
                                    var FormRole = new T_HistoryRole()
                                    {
                                        IdRole = QueryUserRole.IdRole,
                                        IdUser = QueryUser.IdUser,
                                        StartDate = DateTime.UtcNow.AddHours(7),
                                        IdUserDecenRole = IdUserDecenRole
                                    };
                                    await context.T_HistoryRoles.AddAsync(FormRole);
                                }
                                else
                                {
                                    var FormRole = new T_HistoryRole()
                                    {
                                        IdRole = QueryUserRole.IdRole,
                                        IdUser = QueryUser.IdUser,
                                        StartDate = DateTime.UtcNow.AddHours(7),
                                        IdUserDecenRole = IdUserDecenRole
                                    };
                                    await context.T_HistoryRoles.AddAsync(FormRole);
                                }
                                break;
                        }
                        await context.SaveChangesAsync();
                        result.IdNotification = 3; //change role success;
                        result.Status = true;
                    }
                    else
                    {
                        result.IdNotification = 1; //not find role
                        result.Status = false;
                    }
                }
                else
                {
                    result.IdNotification = 2; //not current role staff;
                    result.Status = false;
                }

            }
            else
            {
                result.IdNotification = 0; //not find staff
                result.Status = false;
            }
            return result;
        }

        //check gmail staff
        public async Task<NotificationUser_V> CheckGmailSatff(string Gmail)
        {
            var result = new NotificationUser_V();
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.Email == Gmail && x.IdStaff != null);
            if (QueryUser != null)
            {
                result.IdNotification = 1; // find gmail user
                result.Status = true;
                result.FullName = QueryUser.FullName;
                result.IdStaff = QueryUser.IdStaff;
            }
            else
            {
                result.IdNotification = 0; // not find gmail
                result.Status = false;
            }
            return result;
        }

        //change password staff
        public async Task<NotificationUser_V> ChangePasswordStaff(string Gmail, string Password)
        {
            var QueryUser = await userManager.FindByEmailAsync(Gmail);
            var result = new NotificationUser_V();
            if (QueryUser != null)
            {
                var token = await userManager.GeneratePasswordResetTokenAsync(QueryUser);
                var UpdatePassword = await userManager.ResetPasswordAsync(QueryUser, token, Password);
                if (UpdatePassword.Succeeded == true)
                {
                    result.IdNotification = 2; //update password success
                    result.Status = true;
                    QueryUser.DateUpdate = DateTime.UtcNow.AddHours(7);
                    context.T_Users.Update(QueryUser);
                    await context.SaveChangesAsync();
                }
                else
                {
                    result.IdNotification = 3; //update password error
                    result.Status = false;
                }
            }
            else
            {
                result.IdNotification = 1; //not find id staff
                result.Status = false;
            }
            return result;
        }

        //create plan of staff
        public async Task<NotificationUser_V> CreatePlanStaff(CreatePlan_V request)
        {
            var result = new NotificationUser_V();
            var QueryAllUser = await context.T_Users.Where(x => x.IdStaff != null).ToListAsync();
            var QueryUser = QueryAllUser.FirstOrDefault(x => x.IdUser == request.IdUserPlan);
            var QueryUserRequest = QueryAllUser.FirstOrDefault(x => x.IdUser == request.IdUserRequest);
            if (QueryUser != null && QueryUserRequest != null)
            {
                var C_Data = new T_PlanStaff()
                {
                    NamePlan = request.NamePlan,
                    ContentPlan = request.ContentPlan,
                    DateCreate = DateTime.UtcNow.AddHours(7),
                    IdUserPlan = request.IdUserPlan,
                    IdUserRequest = request.IdUserRequest,
                    DateComplete = request.DateTimeComplete,
                    TimeComplete = request.TimeComplete,
                    TimeUp = false,
                };
                await context.T_PlanStaffs.AddAsync(C_Data);
                await context.SaveChangesAsync();
                if (request.L_FilePlan.Count > 0)
                {
                    foreach (var item in request.L_FilePlan)
                    {
                        var FilePlan = new T_FilePlan()
                        {
                            NameFile = item.NameFile,
                            IdPlan = C_Data.IdPlan,
                            TypeFile = item.TypeFile,
                            MimeType = item.MimeType,
                            ContentFile = item.ContentFile,
                            DateCreate = C_Data.DateCreate
                        };
                        await context.T_FilePlans.AddAsync(FilePlan);
                    }
                }
                await context.SaveChangesAsync();
                result.IdNotification = 1; // Create Plan staff success
                result.Status = true;
            }
            else
            {
                result.IdNotification = 0; // not find id user and id user request
                result.Status = false;
            }
            return result;
        }

        //Random Id Staff------------------------------------------------------------------------
        private async Task<string> RandomIdStaff(string SymbolRole)
        {
            var QueryAllUser = await context.T_Users.Where(x => x.IdStaff != null).ToListAsync();
            string IdStaff_success = SymbolRole + DateTime.Now.Second + DateTime.Now.Year;
            var CheckIdStaff = QueryAllUser.FirstOrDefault(x => x.IdStaff == IdStaff_success);
            if (CheckIdStaff != null)
            {
                await RandomIdStaff(SymbolRole);
            }
            return IdStaff_success;
        }




        //---------------------------------------------------------------------------------------------
        //-----------------------------------------USER-----------------------------------
        //get all users
        public async Task<List<GetAllUsers_V>> GetAllUsers()
        {
            var QueryUser = from ItemUser in context.T_Users
                            join ItemStatus in context.T_ActiverAccounts
                            on ItemUser.IdAccountActiver equals ItemStatus.IdAccountActiver
                            where ItemUser.IdStaff == null && ItemUser.IdAccountActiver == 1
                            select new { ItemUser, ItemStatus };
            var result = await QueryUser.OrderByDescending(x => x.ItemUser.FullName).Select(x => new GetAllUsers_V()
            {
                IdUser = x.ItemUser.IdUser,
                NameUsers = x.ItemUser.FullName,
                Birthday = x.ItemUser.Birthday,
                DateCreate = x.ItemUser.DateCreate,
                Age = x.ItemUser.Age,
                IdStatus = x.ItemUser.IdAccountActiver,
                NameStatus = x.ItemStatus.NameAccountActiver,
                Str_Birthday = x.ItemUser.Birthday.ToString("dd/MM/yyyy"),
                Str_DateCreate = x.ItemUser.DateCreate.ToString("dd/MM/yyyy"),
            }).ToListAsync();
            return result;
        }

        //get all birthday user
        public async Task<List<GetAllUsers_V>> GetAllBirthdayUsers()
        {
            DateTime CurrentDate = DateTime.UtcNow.AddHours(7);
            var QueryUsers = await context.T_Users.Where(x => x.IdStaff == null
                                            && x.IdAccountActiver == 1
                                            && x.Birthday.Day == CurrentDate.Day
                                            && x.Birthday.Month == CurrentDate.Month).ToListAsync();

            var QueryBirthday = await context.T_BirthdayUsers.OrderByDescending(x => x.Id)
                                                                .Where(x => x.BirthdayUser.Day == CurrentDate.Day
                                                                    && x.BirthdayUser.Month == CurrentDate.Month).ToListAsync();
            List<GetAllUsers_V> L_UserBirthday = new List<GetAllUsers_V>();
            foreach (var item in QueryUsers)
            {
                var CheckUser = QueryBirthday.FirstOrDefault(x => x.IdUser == item.IdUser);
                var SetData = new GetAllUsers_V();
                if (CheckUser != null)
                {
                    SetData.IdUser = item.IdUser;
                    SetData.NameUsers = item.FullName;
                    SetData.Birthday = item.Birthday;
                    SetData.Age = item.Age;
                    SetData.Str_Birthday = item.Birthday.ToString("dd/MM/yyyy");
                    SetData.WasSentBirthday = 1;
                }
                else
                {
                    SetData.IdUser = item.IdUser;
                    SetData.NameUsers = item.FullName;
                    SetData.Birthday = item.Birthday;
                    SetData.Age = item.Age;
                    SetData.Str_Birthday = item.Birthday.ToString("dd/MM/yyyy");
                    SetData.WasSentBirthday = 0;
                }
                L_UserBirthday.Add(SetData);
            }
            return L_UserBirthday;
        }

        //get User info birthday
        public async Task<GetInfoUserBirthday_V> GetInfoUserBirthday(Guid IdUser)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
            var result = new GetInfoUserBirthday_V()
            {
                IdUser = QueryUser.IdUser,
                FullName = QueryUser.FullName,
                Gmail = QueryUser.Email
            };
            return result;
        }

        //sent gmail birthday user
        public async Task<NotificationUser_V> SentMessageBirthdayUser(GetInfoUserBirthday_V request)
        {
            var result = new NotificationUser_V();
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == request.IdUser 
                                                                                && x.IdStaff == null 
                                                                                    && x.IdAccountActiver == 1);

            var Email = new MimeMessage();
            Email.Sender = MailboxAddress.Parse(_config["GmailAdmin"]);
            Email.To.Add(MailboxAddress.Parse(request.Gmail));
            Email.Subject = request.Title;
            var Buirder = new BodyBuilder();
            if (request.Attachments != null)
            {
                byte[] fileBytes;
                using (var ms = new MemoryStream())
                {
                    request.Attachments.CopyTo(ms);
                    fileBytes = ms.ToArray();
                }
                Buirder.Attachments.Add(request.Attachments.FileName, fileBytes, ContentType.Parse(request.Attachments.ContentType));

            }
            Buirder.HtmlBody = "<p style='font-weight:600'>" + "Xin chào " + 
                                request.FullName + "</p>" + " " + "<br/>" + 
                                    request.Content + "<br/> <p style='text-align: right; font-weight:600; color: blue'>Manager Music Xin Chào</p>";
            Email.Body = Buirder.ToMessageBody();
            int port = Convert.ToInt32(_config["Port"]);
            var UserName = _config["GmailAdmin"];
            var Password = _config["PasswordAdmin"];
            using var smtp = new SmtpClient();
            try
            {
                await smtp.ConnectAsync(_config["Host"], 587, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(UserName, Password);
                await smtp.SendAsync(Email);

                result.IdNotification = 1; //sent email success
                result.Status = true;

                var SaveSentBirthday = new T_BirthdayUser()
                {
                    IdUser = request.IdUser,
                    TitleSent = request.Title,
                    ContentSent = request.Content,
                    BirthdayUser = QueryUser.Birthday,
                    DateSent = DateTime.UtcNow.AddHours(7),
                    StatusSent = true
                };
                await context.T_BirthdayUsers.AddAsync(SaveSentBirthday);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                result.IdNotification = 2; //sent email error
                result.Status = false;
            }
            await smtp.DisconnectAsync(true);

            return result;
        }

        //get all sent message birthday user
        public async Task<List<GetAllSentBirthdayUser_V>> GetAllSentBirthdayMessage()
        {
            var QueryUser = await context.T_Users.Where(x => x.IdStaff == null).ToListAsync();
            var QueryMessage = await context.T_BirthdayUsers.OrderByDescending(x=>x.Id).ToListAsync();
            List<GetAllSentBirthdayUser_V> L_Message = new List<GetAllSentBirthdayUser_V>();       
            foreach(var item in QueryMessage)
            {
                var checkData = QueryUser.FirstOrDefault(x => x.IdUser == item.IdUser);
                if (checkData != null)
                {
                    var result = new GetAllSentBirthdayUser_V()
                    {
                        Id = item.Id,
                        Iduser = item.IdUser,
                        NameUser = checkData.FullName,
                        Birthday = item.BirthdayUser,
                        DateSent = item.DateSent,
                        TitleSent = item.TitleSent,
                        ContentSent = item.ContentSent,
                        StatusSent = item.StatusSent,
                        Str_DateSent = item.DateSent.ToString("dd/MM/yyyy"),
                        Str_Birthday = item.BirthdayUser.ToString("dd/MM/yyyy")
                    };
                    L_Message.Add(result);
                }
            }
            return L_Message;
        }

        //Detail User
        public async Task<DetailUser_V> DetailUser(Guid Iduser)
        {
            var resutl = new DetailUser_V();
            var QueryUser = await context.T_Users
                                    .FirstOrDefaultAsync(x => x.IdUser == Iduser && x.IdStaff == null);
            if(QueryUser == null)
            {
                return resutl;
            }
            else
            {
                var QueryActiver = await context.T_ActiverAccounts
                                   .FirstOrDefaultAsync(x => x.IdAccountActiver == QueryUser.IdAccountActiver);
                var QueryLever = await context.T_LeverUsers
                                        .FirstOrDefaultAsync(x => x.IdLever == QueryUser.IdLever);
                var QueryGender = await context.T_Genders
                                        .FirstOrDefaultAsync(x => x.IdGender == QueryUser.IdGender);
                var QueryCity = await context.T_Cities
                                        .FirstOrDefaultAsync(x => x.IdCity == QueryUser.IdCity);
                var QueryDistrict = await context.T_Districts
                                        .FirstOrDefaultAsync(x => x.IdDistrict == QueryUser.IdDistrict);
                resutl.IdUser = QueryUser.IdUser;
                resutl.IdAccountActiver = QueryUser.IdAccountActiver;
                resutl.IdLever = QueryUser.IdLever;
                resutl.IdGender = QueryUser.IdGender;
                resutl.IdCity = QueryUser.IdCity;
                resutl.IdDistrict = QueryUser.IdDistrict;
                resutl.Birthday = QueryUser.Birthday;
                resutl.FullName = QueryUser.FullName;
                resutl.Date = QueryUser.Date;
                resutl.Month = QueryUser.Month;
                resutl.Year = QueryUser.Year;
                resutl.DateCreate = QueryUser.DateCreate;
                resutl.Age = QueryUser.Age;
                resutl.Email = QueryUser.Email;
                resutl.NameGender = QueryGender.NameGender;
                resutl.NameLever = QueryLever.Name;
                resutl.NameCity = QueryCity.NameCity;
                resutl.NameDistrict = QueryDistrict.NameDistrict;
                resutl.Str_Birthday = QueryUser.Birthday.ToString("dd/MM/yyyy");
                resutl.Str_DateCreate = QueryUser.DateCreate.ToString("dd/MM/yyyy");
                if (resutl.IdAccountActiver == 1)
                {
                    DateTime TimeCurrent = DateTime.UtcNow.AddHours(7);
                    DateTime DateCreate = QueryUser.DateCreate;
                    TimeSpan Time = TimeCurrent - DateCreate;
                    resutl.TimeOnline = Time.Days;
                }
                else
                {
                    TimeSpan TimeCurrent = QueryUser.DateAccountBlock.Value.TimeOfDay;
                    TimeSpan DateCreate = QueryUser.DateCreate.TimeOfDay;
                    TimeSpan Time = TimeCurrent - DateCreate;
                    resutl.TimeOnline = Time.Days;
                }
                resutl.Str_DateUpdate = QueryUser.DateUpdate.ToString();
                return resutl;
            }        
        }

        //Get All Time Working User
        public async Task<List<GetAllTimeWorking_V>> GetAllTimeWork(Guid IdUser)
        {
            var QueryUsers = await context.T_Logins.OrderByDescending(x=>x.DateLogin)
                                            .Where(x => x.IdUser == IdUser).ToListAsync();
            var Result = new List<GetAllTimeWorking_V>();
            foreach(var item in QueryUsers)
            {
                string Total = "0";
                if(item.TimeSignout != new DateTime(0001, 01, 01))
                {
                    TimeSpan TimeCurrent = item.TimeSignout.TimeOfDay;
                    TimeSpan DateCreate = item.TimeLogin.TimeOfDay;
                    TimeSpan Time = TimeCurrent - DateCreate;
                    Total = Time.ToString();
                }

                var SaveData = new GetAllTimeWorking_V()
                {
                    Iduser = item.IdUser,
                    DateLogin = item.DateLogin.ToString("dd/MM/yyyy"),
                    TimeLogin = item.TimeLogin,
                    TimeLogOut = item.TimeSignout,
                    Str_TimeLogin = item.TimeLogin.TimeOfDay.ToString(),
                    Str_TimeOut = (item.TimeSignout != new DateTime(0001, 01, 01)) ? item.TimeSignout.TimeOfDay.ToString() : "-----",
                    TotalWork = Total
                };
                Result.Add(SaveData);
            }
            return Result;
        }

        //get all rating by id user
        public async Task<List<GetAllRatingByIdUser>> GetAllRatingByIdUser(Guid IdUser)
        {
            var QueryMuisc = await context.T_Musics.ToListAsync();
            var QueryRating = await context.T_Ratings.Where(x => x.IdUser == IdUser).OrderByDescending(x => x.DateCreate).ToListAsync();
            List<GetAllRatingByIdUser> L_Rating = new List<GetAllRatingByIdUser>();
            foreach(var item in QueryRating)
            {
                var FindMuisc = QueryMuisc.FirstOrDefault(x => x.IdMusic == item.IdMusic);
                var SetData = new GetAllRatingByIdUser()
                {
                    Id = item.IdRating,
                    IdMuisc = FindMuisc.IdMusic,
                    NameMuisc = FindMuisc.NameMusic,
                    DateCreate = item.DateCreate,
                    Str_DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    TotalRating = item.Rating
                };
                L_Rating.Add(SetData);
            }
            return L_Rating;
        }

        //get all comment by id user
        public async Task<List<GetAllCommentByIdUser_V>> GetAllCommentByIdUser(Guid IdUser)
        {
            var QueryMuisc = await context.T_Musics.ToListAsync();
            var QueryComment = await context.T_CommentMusic.Where(x => x.IdUser == IdUser).ToListAsync();
            List<GetAllCommentByIdUser_V> L_Comment = new List<GetAllCommentByIdUser_V>();
            foreach(var item in QueryComment)
            {
                var FindMuisc = QueryMuisc.FirstOrDefault(x => x.IdMusic == item.IdMusic);
                var SetData = new GetAllCommentByIdUser_V()
                {
                    Id = item.IdComment,
                    IdMuisc = FindMuisc.IdMusic,
                    NameMuisc = FindMuisc.NameMusic,
                    DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    Comment = item.ContentComment
                };
                L_Comment.Add(SetData);
            }
            return L_Comment;
        }

        //Get All dowload by id user
        public async Task<List<GetAllDowloadByIdUser_V>> GetAllDowloadByIdUser(Guid IdUser)
        {
            var QueryMuisc = await context.T_Musics.ToListAsync();
            var QueryDowload = await context.T_DowloadMusics.Where(x => x.IdUser == IdUser).ToListAsync();
            List<GetAllDowloadByIdUser_V> L_Dowload = new List<GetAllDowloadByIdUser_V>();
            foreach(var item in QueryDowload)
            {
                var Findmuisc = QueryMuisc.FirstOrDefault(x => x.IdMusic == item.IdMusic);
                var setdata = new GetAllDowloadByIdUser_V()
                {
                    Id = item.IdDowload,
                    IdMuisc = Findmuisc.IdMusic,
                    NameMuisc = Findmuisc.NameMusic,
                    DateDowload = item.DateCreate.ToString("dd/MM/yyyy")
                };
                L_Dowload.Add(setdata);
            }
            return L_Dowload;
        }

        //get all request by id user
        public async Task<List<GetAllRequestByIdUser>> GetAllRequestByIdUser(Guid IdUser)
        {
            var Query = await context.T_RequestUsers.Where(x => x.IdUser == IdUser).ToListAsync();
            var QueryRecuse = await context.T_ReceiveRequests.ToListAsync();
            List<GetAllRequestByIdUser> L_Request = new List<GetAllRequestByIdUser>();
            foreach(var item in Query)
            {
                var Datas = new GetAllRequestByIdUser();
                switch (item.IdReceiveRequest)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                L_Request.Add(Datas);
            }
            return L_Request;
        }

    }
}
