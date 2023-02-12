using DataMigration.DataEF;
using DataTable.Table.RequestUser;
using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.RequestUser
{
    public class Sevice_RequestUser : Isevice_RequestUser
    {
        private readonly ContextDB context;
        private readonly IConfiguration _config;
        public Sevice_RequestUser(ContextDB _context, IConfiguration config)
        {
            context = _context;
            _config = config;
        }

        //get all receive
        public async Task<List<GetAllReceive_Vm>> GetAllReceiveUser()
        {
            var QueryData = from Item in context.T_ReceiveRequests
                            select new { Item };
            var Result = await QueryData.OrderBy(x => x.Item.Description).Select(x => new GetAllReceive_Vm()
            {
                Id = x.Item.IdReceiveRequest,
                Name = x.Item.Description
            }).ToListAsync();
            return Result;
        }

        //get all request user Not resolved
        public async Task<List<GetAllRequestUser_Vm>> GetAllRequestUser_Notresolved(int Selecter)
        {
            var QueryRequest = from Item_Request in context.T_RequestUsers
                               join Item_User in context.T_Users on Item_Request.IdUser equals Item_User.IdUser
                               join Item_Recevice in context.T_ReceiveRequests on Item_Request.IdReceiveRequest equals Item_Recevice.IdReceiveRequest
                               where Item_Request.IdReceiveRequest == Selecter
                               select new { Item_Request, Item_User, Item_Recevice };
            var Result = await QueryRequest.OrderByDescending(x => x.Item_Request.DateRequest).Select(x => new GetAllRequestUser_Vm()
            {
                Id = x.Item_Request.IdRequest,
                IdUser = x.Item_User.IdUser,
                NameUser = x.Item_User.FullName,
                Title = x.Item_Request.TitleRequest,
                Str_DateRequest = x.Item_Request.DateRequest.ToString("dd/MM/yyyy"),
                DateRequest = x.Item_Request.DateRequest,
                IdReceive = x.Item_Recevice.IdReceiveRequest,
                NameReceive = x.Item_Recevice.Description
            }).ToListAsync();
            return Result;
        }

        //get all status request
        public async Task<List<GetAllStatusRequest_Vm>> GetAllStatusRequest()
        {
            var QueryStatus = from Item in context.T_TypeSentUsers
                              where Item.Status == true
                              select new { Item };
            var result = await QueryStatus.OrderBy(x => x.Item.NameType).Select(x => new GetAllStatusRequest_Vm()
            {
                IdStatus = x.Item.IdTypeSent,
                NameStatus = x.Item.NameType
            }).ToListAsync();
            return result;
        }

        //detail request user by id request
        public async Task<DetailRequestUser_Vm> DetailRequestUser(int IdRequest)
        {
            var QueryRequest = await context.T_RequestUsers.FirstOrDefaultAsync(x => x.IdRequest == IdRequest);
            var result = new DetailRequestUser_Vm();
            if (QueryRequest == null)
            {
                result.StatusFindData = false;
            }
            else
            {
                var QueryRevice = await context.T_ReceiveRequests
                .FirstOrDefaultAsync(x => x.IdReceiveRequest == QueryRequest.IdReceiveRequest);
                var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == QueryRequest.IdUser);
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == QueryRequest.IdUser);
                var QueryRole = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == QueryUserRole.IdRole);
                var QueryTypeSent = await context.T_TypeSentUsers.ToListAsync();

                result.IdRequest = QueryRequest.IdRequest;
                result.IdUser = QueryUser.IdUser;
                result.IdRole = QueryRole.IdRole;
                result.NameRole = QueryRole.SymbolRole;
                result.NameUser = QueryUser.FullName;
                result.Gmail = QueryUser.Email;
                result.STR_DateRequest = QueryRequest.DateRequest.ToString("dd/MM/yyyy");
                result.DateRequest = QueryRequest.DateRequest;
                result.TitleRequest = QueryRequest.TitleRequest;
                result.ContentRequest = QueryRequest.ContentRequest;
                result.StatusFindData = true;
                result.IdRecende = QueryRequest.IdReceiveRequest;
                result.NameRecende = QueryRevice.Description;
                if(result.IdRecende == 2)
                {
                    DateTime DateHandled = Convert.ToDateTime(QueryRequest.DateHandled);
                    result.Str_DateHandled = DateHandled.ToString("dd/MM/yyyy");
                    result.IdTypeSent = Convert.ToInt32(QueryRequest.IdTypeSent);
                    result.NameTypeSent = QueryTypeSent.FirstOrDefault(x => x.IdTypeSent == result.IdTypeSent).NameType;
                }
                if(result.IdRecende == 3)
                {
                    DateTime DateHandled = Convert.ToDateTime(QueryRequest.DateHandled);
                    result.Str_DateHandled = DateHandled.ToString("dd/MM/yyyy");
                    DateTime DateSuccess = Convert.ToDateTime(QueryRequest.DateSuccess);
                    result.Str_DateSuccess = DateSuccess.ToString("dd/MM/yyyy");
                    result.IdTypeSent = Convert.ToInt32(QueryRequest.IdTypeSent);
                    result.NameTypeSent = QueryTypeSent.FirstOrDefault(x => x.IdTypeSent == result.IdTypeSent).NameType;
                }
            }
            return result;
        }

        //accept request user
        public async Task<NotificationRequestUser> CacceptRequestUser(int IdRequest, Guid IdUser, int TypeSent)
        {
            var QueryData = await context.T_RequestUsers.FirstOrDefaultAsync(x => x.IdRequest == IdRequest 
                                                                                && x.IdUser == IdUser 
                                                                                    && x.DateHandled == null);
            var QueryTypeSent = await context.T_TypeSentUsers.FirstOrDefaultAsync(x => x.IdTypeSent == TypeSent);
            var result = new NotificationRequestUser();
            if(QueryData == null)
            {
                result.Id_Notifi = 1; //not find request user
                result.Status_Notifi = false;
            }
            else
            {
                if(QueryTypeSent == null)
                {
                    result.Id_Notifi = 3; // not find type sent request
                    result.Status_Notifi = false;
                }
                else
                {
                    QueryData.DateHandled = DateTime.UtcNow.AddHours(7);
                    QueryData.IdReceiveRequest = 2;
                    QueryData.IdTypeSent = QueryTypeSent.IdTypeSent;
                    context.T_RequestUsers.Update(QueryData);
                    await context.SaveChangesAsync();

                    result.Id_Notifi = 2; //accept request user successfully
                    result.Status_Notifi = true;
                }
            }
            return result;
        }

        //check Type Sent Request User
        public async Task<NotificationTypeSent_Vm> CheckTypeSentRequestUser(int IdTypeSent)
        {
            var QueryData = await context.T_TypeSentUsers.FirstOrDefaultAsync(x => x.IdTypeSent == IdTypeSent);
            var result = new NotificationTypeSent_Vm();
            if(QueryData == null)
            {
                result.IdTypeSent = 1; //not find type sent by this id
                result.StatusTypeSent = false;
            }
            else
            {
                if(QueryData.Status == false)
                {
                    result.IdTypeSent = 2; //Type sent this not activer 
                    result.StatusTypeSent = false;
                }
                else
                {
                    result.IdTypeSent = 3; //Check TypeSent Successfully
                    result.StatusTypeSent = true;
                }
            }
            return result;
        }

        //sent request user
        public async Task<NotificationRequestUser> SentEmailRequestUser(ContentAnswerSentRequestUser request)
        {
            var result = new NotificationRequestUser();
            var QueryRequestUser = await context.T_RequestUsers.FirstOrDefaultAsync(x => x.IdRequest == request.IdRequest);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.Email == request.Email);
            if(QueryRequestUser == null)
            {
                result.Id_Notifi = 1; //not find id request user
                result.Status_Notifi = false;
            }
            else
            {
                if(QueryUser == null)
                {
                    result.Id_Notifi = 2; //Not find email user request
                    result.Status_Notifi = false;
                }
                else
                {
                    var Email = new MimeMessage();
                    Email.Sender = MailboxAddress.Parse(_config["GmailAdmin"]);
                    Email.To.Add(MailboxAddress.Parse(request.Email));
                    Email.Subject = request.TitleSent;
                    var Buirder = new BodyBuilder();
                    if (request.L_Files.Count() != 0)
                    {
                        foreach (var item in request.L_Files)
                        {
                            byte[] fileBytes;
                            using (var ms = new MemoryStream())
                            {
                                item.CopyTo(ms);
                                fileBytes = ms.ToArray();
                            }
                            Buirder.Attachments.Add(item.FileName, fileBytes, ContentType.Parse(item.ContentType));
                        }
                    }
                    Buirder.HtmlBody = "<p style='font-weight:600'>" + "Xin chào " +
                                        QueryUser.FullName + "</p>" + " " + "<br/>" +
                                            request.ContentSent + "<br/> <p style='text-align: right; font-weight:600; color: blue'>Manager Music Xin Chào</p>";
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

                        //save in database
                        //add answer request user
                        var SaveData = new T_AnswerRequest()
                        {
                            IdTypeSent = request.IdTypeSent,
                            IdUser = request.IdUser,
                            IdRequest = request.IdRequest,
                            IdStaff = request.IdStaff,
                            IdRead = request.IdRead,
                            TitleSent = request.TitleSent,
                            ContentSent = request.ContentSent,
                            DateSent = request.DateSent
                        };

                        //update request user
                        QueryRequestUser.IdReceiveRequest = 3;
                        QueryRequestUser.DateSuccess = DateTime.UtcNow.AddHours(7);

                        context.T_RequestUsers.Update(QueryRequestUser);
                        await context.T_AnswerRequests.AddAsync(SaveData);
                        await context.SaveChangesAsync();

                        result.Id_Notifi = 3; //sent email request user success
                        result.Status_Notifi = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        result.Id_Notifi = 4; //sent email error
                        result.Status_Notifi = false;
                    }
                    await smtp.DisconnectAsync(true);
                }
            }
            return result;
        }

        //total request user
        public int TotalRequestUser()
        {
            var Query = context.T_RequestUsers.Where(x => x.IdReceiveRequest == 1).ToList();
            return Query.Count();
        }

        //get all progress request user
        public async Task<List<GetAllRequestUserProgress>> GetAllProgressRequestUser()
        {
            var Query = await context.T_RequestUsers.ToListAsync();
            var QueryUser = await context.T_Users.Where(x => x.IdStaff == null).ToListAsync();

            List<GetAllRequestUserProgress> L_Progress = new List<GetAllRequestUserProgress>();
            foreach(var item in Query)
            {
                var Datas = new GetAllRequestUserProgress()
                {
                    Id = item.IdRequest,
                    IdRecener = item.IdReceiveRequest,
                    IdUser = QueryUser.FirstOrDefault(x => x.IdUser == item.IdUser).IdUser,
                    FullName = QueryUser.FirstOrDefault(x=>x.IdUser == item.IdUser).FullName,
                    TitleRequest = item.TitleRequest,
                    DateRequest = item.DateRequest,
                    Str_DateRequest = item.DateRequest.ToString("dd/MM/yyyy")
                };
                if(item.DateHandled != null)
                {
                    DateTime DateHandled = Convert.ToDateTime(item.DateHandled);
                    Datas.Str_DateHandled = DateHandled.ToString("dd/MM/yyyy");
                    Datas.DateHandled = DateHandled;
                }
                if(item.DateSuccess != null)
                {
                    DateTime DateSuccess = Convert.ToDateTime(item.DateSuccess);
                    Datas.Str_DateSuccessFull = DateSuccess.ToString("dd/MM/yyyy");
                    Datas.DateSuccessFull = DateSuccess;
                }
                L_Progress.Add(Datas);
            }
            return L_Progress;
        }

    }
}
