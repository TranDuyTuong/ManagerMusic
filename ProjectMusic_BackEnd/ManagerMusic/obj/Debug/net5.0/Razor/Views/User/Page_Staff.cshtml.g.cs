#pragma checksum "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487f4254695bd8bc7f5b0375f76666054583c81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Page_Staff), @"mvc.1.0.view", @"/Views/User/Page_Staff.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\_ViewImports.cshtml"
using ManagerMusic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487f4254695bd8bc7f5b0375f76666054583c81f", @"/Views/User/Page_Staff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Page_Staff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PageCreateSatff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
  
    ViewData["Title"] = languade.Getkey("ManagerSatff");
    Layout = "~/Views/Shared/Manager_Staff/ManagerStaff.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"az-content-body pd-lg-l-40 d-flex flex-column\">\r\n    <div class=\"az-content-breadcrumb\">\r\n        <span><a href=\"#\" style=\"color: #97a3b9;\">");
#nullable restore
#line 9 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                             Write(languade.Getkey("Home_page"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n        <span><a href=\"#\" style=\"color: #97a3b9;\">");
#nullable restore
#line 10 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                             Write(languade.Getkey("Admin_Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n        <span>");
#nullable restore
#line 11 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
         Write(languade.Getkey("ManagerSatff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n\r\n    <h2 class=\"az-content-title\">");
#nullable restore
#line 14 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                            Write(languade.Getkey("ManagerSatff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p style=\"text-align: left; font-family: inherit; color: red;\">\r\n       ");
#nullable restore
#line 16 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
  Write(languade.Getkey("BirthdayOf"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b style=\"color:red\" id=\"NumberBirthday\">( 4 )</b> ");
#nullable restore
#line 16 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                                    Write(languade.Getkey("send_congratulations"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""row g-3 align-items-center"" id=""SeachMusic-Admin"">
                <div class=""col-auto"" style=""background: #0000000d; border-radius: 5px;"">
                    <input style=""width: 300px; border-radius: 5px;"" type=""text"" onkeyup=""eventSeachMusic()"" id=""TxtInputMusic""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1188, "\"", 1240, 1);
#nullable restore
#line 22 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 1202, languade.Getkey("EnterNameOrIdSatff"), 1202, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 1371, "\"", 1413, 1);
#nullable restore
#line 23 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 1379, languade.Getkey("Advancedsearch"), 1379, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-search-plus\"></i></a>\r\n                    <a id=\"btn-closeSeachMusic\" style=\"border: none; color: red; float: right;\" tdata-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 1600, "\"", 1639, 1);
#nullable restore
#line 24 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 1608, languade.Getkey("Close_Seach"), 1608, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">X</a>
                </div>
                <hr />
            </div>

            <div id=""Modal-ShowSelectSumer"" style=""background: #0000001f; border-radius: 10px; display: block; height: 75px;"">
                <p style=""text-align: right; margin: 10px 10px;"">
                    <a id=""btn-closeModalSelect"" style=""border: none; color: red;"" data-bs-toggle=""tooltip"" data-bs-placement=""right""");
            BeginWriteAttribute("title", " title=\"", 2046, "\"", 2085, 1);
#nullable restore
#line 31 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 2054, languade.Getkey("Close_Seach"), 2054, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">X</a>
                </p>
                <select class=""form-control"" style=""border-radius: 5px;"" id=""SelectRole""></select>
            </div>

            <p style=""text-align:right;"">

                <a id=""btn-ShowModalCraeteMusic"" style=""border: none;"" class=""btn btn-outline-secondary"" data-bs-toggle=""tooltip"" data-bs-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 2436, "\"", 2481, 1);
#nullable restore
#line 38 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 2444, languade.Getkey("Employee_birthday"), 2444, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-birthday-cake\"></i></a>\r\n\r\n                <a id=\"btn-ShowModalCraeteMusic\" style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 2680, "\"", 2733, 1);
#nullable restore
#line 40 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 2688, languade.Getkey("Retrieveemployee_password"), 2688, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-key\"></i></a>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487f4254695bd8bc7f5b0375f76666054583c81f11803", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
AddHtmlAttributeValue("", 2951, languade.Getkey("Create_Staff"), 2951, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <a id=\"btn-ShowModalSelect\" style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 3175, "\"", 3222, 1);
#nullable restore
#line 44 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 3183, languade.Getkey("Selectemployee_role"), 3183, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-list-alt\"></i></a>\r\n\r\n                <a id=\"btn-ShowFormSeachMusic\" style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 3414, "\"", 3457, 1);
#nullable restore
#line 46 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 3422, languade.Getkey("Employee_Search"), 3422, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-search\"></i></a>\r\n\r\n                <a href=\"#\" style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 3628, "\"", 3674, 1);
#nullable restore
#line 48 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 3636, languade.Getkey("Employeeout_ofwork"), 3636, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-user-alt-slash\"></i></a>\r\n\r\n                <a href=\"#\" style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 3853, "\"", 3904, 1);
#nullable restore
#line 50 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 3861, languade.Getkey("ListSatffLocked_Account"), 3861, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-user-lock\"></i></a>\r\n\r\n                <a id=\"btn-showModalActiverFile\" style=\"border: none;\" class=\"btn btn-outline-secondary\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 4099, "\"", 4143, 1);
#nullable restore
#line 52 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 4107, languade.Getkey("Staff_Activation"), 4107, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-cog\"></i></a>\r\n\r\n                <a style=\"border: none;\" class=\"btn btn-outline-secondary\">");
#nullable restore
#line 54 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                      Write(languade.Getkey("TotalStaff"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <b id=""TxtTotalSatff""></b></a>

            </p>
            <p id=""TileNotification""></p>
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">
                            <input type=""checkbox"" id=""selectall"" />
                        </th>
                        <th scope=""col"">");
#nullable restore
#line 64 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("No"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-fw fa-sort\"></i></th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 65 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("NameStaff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 66 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("working_day"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 67 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("ImageStaff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 68 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("Role_App"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 69 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 70 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                   Write(languade.Getkey("Options"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"Body_Data\">\r\n                </tbody>\r\n            </table>\r\n            <p style=\"text-align:right;\">");
#nullable restore
#line 76 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                    Write(languade.Getkey("page"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" : <b id=""ItemInPage"" style=""color:red;""></b>/<b id=""TotalItem"" style=""color:black;""></b></p>
            <!-- Pagination -->
            <div class=""row"" style=""clear: both;"">
                <div id=""pagination"" class=""pagination""></div>
            </div>

        </div>
    </div>

    <div class=""az-footer mg-t-auto"">
        <div class=""container"">
            <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">");
#nullable restore
#line 87 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                                   Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Do <a href=\"#\" target=\"_blank\">");
#nullable restore
#line 88 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                                                                Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> từ duytuong0503@gmail.com</span>
        </div><!-- container -->
    </div><!-- az-footer -->
</div><!-- az-content-body -->
<!-- choose option activer funtion file -->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal-ShowChooseActiverFile"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><i class=""fas fa-toolbox""></i> ");
#nullable restore
#line 97 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                  Write(languade.Getkey("Statussettings_accounts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""btn-closeactiver"">X</button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p style=""text-align:center;"">
                            <button type=""button"" class=""btn btn-outline-secondary"">");
#nullable restore
#line 104 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                               Write(languade.Getkey("Active_account"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                        </p>
                    </div>
                    <div class=""col-md-6"">
                        <p style=""text-align:center;"">
                            <button type=""button"" class=""btn btn-outline-secondary"" id=""btn-Anactiver"">");
#nullable restore
#line 109 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
                                                                                                  Write(languade.Getkey("Deactivate_account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7413, "\"", 7445, 1);
#nullable restore
#line 117 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7421, languade.Getkey("head"), 7421, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"head\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7481, "\"", 7513, 1);
#nullable restore
#line 118 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7489, languade.Getkey("next"), 7489, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"next\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7549, "\"", 7581, 1);
#nullable restore
#line 119 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7557, languade.Getkey("last"), 7557, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"last\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7617, "\"", 7651, 1);
#nullable restore
#line 120 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7625, languade.Getkey("Before"), 7625, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Before\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7689, "\"", 7729, 1);
#nullable restore
#line 121 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7697, languade.Getkey("NotFindStaff"), 7697, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"NotFindStaff\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7772, "\"", 7810, 1);
#nullable restore
#line 122 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7780, languade.Getkey("Edit_staff"), 7780, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Edit_staff\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7851, "\"", 7895, 1);
#nullable restore
#line 123 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7859, languade.Getkey("Employee_Details"), 7859, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Employee_Details\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7942, "\"", 7984, 1);
#nullable restore
#line 124 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 7950, languade.Getkey("Role Selection"), 7950, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Role_Selection\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 8029, "\"", 8069, 1);
#nullable restore
#line 125 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 8037, languade.Getkey("select_field"), 8037, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"select_field\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 8112, "\"", 8158, 1);
#nullable restore
#line 126 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\User\Page_Staff.cshtml"
WriteAttributeValue("", 8120, languade.Getkey("Notification_Error"), 8120, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Notification_Error\"/>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LanguageService languade { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
