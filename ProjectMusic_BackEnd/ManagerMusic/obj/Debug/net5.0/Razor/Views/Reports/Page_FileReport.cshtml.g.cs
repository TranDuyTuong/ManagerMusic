#pragma checksum "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181e8133106e684fd0fef8294d7fe5b20cdea56f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Page_FileReport), @"mvc.1.0.view", @"/Views/Reports/Page_FileReport.cshtml")]
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
#line 1 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\_ViewImports.cshtml"
using ManagerMusic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181e8133106e684fd0fef8294d7fe5b20cdea56f", @"/Views/Reports/Page_FileReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Page_FileReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #97a3b9;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Page_Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
  
    ViewData["Title"] = languade.Getkey("ReportSong_File");
    Layout = "~/Views/Shared/Manger_Report/ManagerReportFile.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"az-content-body pd-lg-l-40 d-flex flex-column\">\r\n    <div class=\"az-content-breadcrumb\">\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "181e8133106e684fd0fef8294d7fe5b20cdea56f5302", async() => {
#nullable restore
#line 10 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                                             Write(languade.Getkey("Home_page"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 11 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
         Write(languade.Getkey("Admin_Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "181e8133106e684fd0fef8294d7fe5b20cdea56f7376", async() => {
#nullable restore
#line 12 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                                                      Write(languade.Getkey("Report_Management"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 13 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
         Write(languade.Getkey("ReportSong_File"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n\r\n    <h2 class=\"az-content-title\"><i class=\"fas fa-music\"></i> ");
#nullable restore
#line 16 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                         Write(languade.Getkey("ReportSong_File"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <div class=""row"">
        <div class=""col-md-12"">
            <p style=""text-align:right;"">

                <a id=""DowLoadAllFile_Music"" style=""border: none;"" class=""btn btn-outline-secondary""
                   data-bs-toggle=""tooltip"" data-bs-placement=""top""");
            BeginWriteAttribute("title", "\r\n                   title=\"", 1076, "\"", 1141, 1);
#nullable restore
#line 23 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 1104, languade.Getkey("Download_fulllist"), 1104, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-file-export\"></i></a>\r\n\r\n                <a id=\"DowloadBuAuthor\" style=\"border: none;\" class=\"btn btn-outline-secondary\"\r\n                   data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", "\r\n                   title=\"", 1349, "\"", 1417, 1);
#nullable restore
#line 27 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 1377, languade.Getkey("Downloadsongs_author"), 1377, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-file-download\"></i></a>\r\n\r\n                <a id=\"btn_ShowModalSeason\" style=\"border: none;\" class=\"btn btn-outline-secondary\"\r\n                   data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", "\r\n                   title=\"", 1631, "\"", 1700, 1);
#nullable restore
#line 31 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 1659, languade.Getkey("Downloadseasonal_list"), 1659, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-download\"></i></a>\r\n\r\n                <a id=\"btn_ShowModalsaints\" style=\"border: none;\" class=\"btn btn-outline-secondary\"\r\n                   data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", "\r\n                   title=\"", 1909, "\"", 1976, 1);
#nullable restore
#line 35 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 1937, languade.Getkey("Downloadfull_saints"), 1937, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-cloud-download-alt\"></i></a>\r\n\r\n                <a id=\"btn_ShowModalDate\" style=\"border: none;\" class=\"btn btn-outline-secondary\"\r\n                   data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", "\r\n                   title=\"", 2193, "\"", 2263, 1);
#nullable restore
#line 39 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 2221, languade.Getkey("Downloadplaylists_date"), 2221, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-calendar\"></i></a>\r\n\r\n                <a id=\"BtnReset\" style=\"border: none;\" class=\"btn btn-outline-secondary\"\r\n                   data-bs-toggle=\"tooltip\" data-bs-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 2461, "\"", 2494, 1);
#nullable restore
#line 42 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 2469, languade.Getkey("reset"), 2469, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fas fa-spinner\"></i>\r\n                </a>\r\n\r\n                <a style=\"border: none; font-size: 15px; font-family: initial; font-weight: 600; color: black;\"\r\n                   class=\"btn btn-outline-secondary\">");
#nullable restore
#line 47 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                Write(languade.Getkey("Total_Song"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@": <b id=""TotalMusics""></b></a>

            </p>
            <p id=""TxtNotification"" style=""text-align: center; color: red; font-weight: 600; font-size: 13px; font-family: initial""></p>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <p style=""font-size: 20px; font-family: initial"">
                <i class=""fas fa-list""></i> ");
#nullable restore
#line 56 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                       Write(languade.Getkey("Filtered_List"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <table class=\"table table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 61 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("IdMusic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 62 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("namesong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 63 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("Authour_Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 64 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("datecreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 65 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("Seasons"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 66 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("Name_Saint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 67 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("IdStaff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"bodyDataMusic\">\r\n                </tbody>\r\n            </table>\r\n\r\n            <p style=\"text-align:right;\">");
#nullable restore
#line 74 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                    Write(languade.Getkey("page"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" : <b id=""TotalItem"" style=""color:red;""></b>/<b id=""ItemInPage"" style=""color:black;""></b></p>
            <!-- Pagination -->
            <div class=""row"" style=""clear: both;"">
                <div id=""pagination"" class=""pagination""></div>
            </div>

            <p style=""text-align: right;"">
                <a class=""btn btn-success"" id=""BtnDowLoadReport"" style=""border-radius: 10px;"">
                    <i class=""fas fa-file-excel""></i>
                    ");
#nullable restore
#line 83 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
               Write(languade.Getkey("Export_File"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </p>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"az-footer mg-t-auto\">\r\n        <div class=\"container\">\r\n            <span class=\"text-muted d-block text-center text-sm-left d-sm-inline-block\">\r\n                ");
#nullable restore
#line 93 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
           Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\">\r\n                Do <a href=\"#\"\r\n                      target=\"_blank\">");
#nullable restore
#line 97 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                 Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> từ duytuong0503@gmail.com
            </span>
        </div><!-- container -->
    </div><!-- az-footer -->
</div><!-- az-content-body -->
<!--lọc theo mùa-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""ModalSeasonView"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 107 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("FilterSongs_Season"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""btn_closeSeason"">X</button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"">
                    <label class=""form-label"" style=""color: black; margin: 10px 10px;"">");
#nullable restore
#line 112 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                                                  Write(languade.Getkey("Choose_the_Season_You_Need"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                    <select class=""form-control"" style=""border-radius: 10px;"" id=""SelectSeason"">                                              
                    </select>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""Btn_FindSeason"" class=""btn btn-primary"" style=""border-radius: 5px;"">
                    <i class=""fas fa-filter""></i> ");
#nullable restore
#line 119 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                             Write(languade.Getkey("Filter_data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
            </div>
        </div>
    </div>
</div>

<!--lọc theo ngày lễ-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""ModalsaintsView"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 131 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("FilterSongs_Saint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""btn_closesaints"">X</button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"">
                    <label class=""form-label"" style=""color: black; margin: 10px 10px;"">");
#nullable restore
#line 136 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                                                  Write(languade.Getkey("Select_saint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                    <select class=""form-control"" style=""border-radius: 10px;"" id=""SelectSaints"">                                             
                    </select>
                </div>
            </div>
            <div class=""modal-footer"">
                <button id=""BtnSeach_Saints"" type=""button"" class=""btn btn-primary"" style=""border-radius: 5px;"">
                    <i class=""fas fa-filter""></i> ");
#nullable restore
#line 143 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                             Write(languade.Getkey("Filter_data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
            </div>
        </div>
    </div>
</div>

<!--Modal Fuilter date request-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""Modal_ShowFuilterDate"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 155 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                   Write(languade.Getkey("SelectDate_filter"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""btn_CLoseFuilterDate"">X</button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"">
                    <label class=""form-label"" style=""font-size:15px;"" id=""TxtStartEnd"">
                        ");
#nullable restore
#line 161 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                   Write(languade.Getkey("Startdate_dateend"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n\r\n                    <input name=\"daterange\" class=\"form-control\" type=\"text\" id=\"rangeDate\"");
            BeginWriteAttribute("placeholder", "\r\n                           placeholder=\"", 8292, "\"", 8371, 1);
#nullable restore
#line 165 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 8334, languade.Getkey("select_timeperiod"), 8334, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-input>
                </div>
            </div>
            <div class=""modal-footer"">
                <button style=""border-radius: 5px;"" id=""btn_FuilterDate"" type=""button"" class=""btn btn-primary"">
                    <i class=""fas fa-filter""></i> ");
#nullable restore
#line 170 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                             Write(languade.Getkey("Filter_data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
            </div>
        </div>
    </div>
</div>

<!--Modal Seach Author-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""ModalSeachAuthor"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><i class=""fas fa-file-signature""></i> ");
#nullable restore
#line 182 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                                         Write(languade.Getkey("Entername_author"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""CloseAuthor"">X</button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"">
                    <input style=""border-radius: 10px;"" type=""text"" class=""form-control"" id=""TxtNameAuthor""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 9376, "\"", 9425, 1);
#nullable restore
#line 187 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 9390, languade.Getkey("EnterNameAuthor"), 9390, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button style=\"border-radius: 10px;\" type=\"button\" class=\"btn btn-primary\" id=\"BtnSeach_Author\"><i class=\"fas fa-search\"></i> ");
#nullable restore
#line 191 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
                                                                                                                                         Write(languade.Getkey("Seach"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 9769, "\"", 9801, 1);
#nullable restore
#line 197 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 9777, languade.Getkey("head"), 9777, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"head\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 9837, "\"", 9869, 1);
#nullable restore
#line 198 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 9845, languade.Getkey("next"), 9845, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"next\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 9905, "\"", 9937, 1);
#nullable restore
#line 199 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 9913, languade.Getkey("last"), 9913, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"last\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 9973, "\"", 10007, 1);
#nullable restore
#line 200 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 9981, languade.Getkey("Before"), 9981, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Before\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10045, "\"", 10099, 1);
#nullable restore
#line 201 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10053, languade.Getkey("Choose_the_Season_You_Need"), 10053, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Choose_the_Season_You_Need\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10156, "\"", 10209, 1);
#nullable restore
#line 202 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10164, languade.Getkey("choosingdownload_seasonal"), 10164, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"choosingdownload_seasonal\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10265, "\"", 10305, 1);
#nullable restore
#line 203 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10273, languade.Getkey("Select_saint"), 10273, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Select_saint\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10348, "\"", 10399, 1);
#nullable restore
#line 204 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10356, languade.Getkey("choosingdownload_saints"), 10356, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"choosingdownload_saints\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10453, "\"", 10502, 1);
#nullable restore
#line 205 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10461, languade.Getkey("choosingdownload_date"), 10461, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"choosingdownload_date\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10554, "\"", 10602, 1);
#nullable restore
#line 206 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10562, languade.Getkey("choosingdownload_All"), 10562, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"choosingdownload_All\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10653, "\"", 10699, 1);
#nullable restore
#line 207 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10661, languade.Getkey("Notification_Error"), 10661, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Notification_Error\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10748, "\"", 10791, 1);
#nullable restore
#line 208 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10756, languade.Getkey("EnterNameAuthor"), 10756, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"EnterNameAuthor\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10837, "\"", 10888, 1);
#nullable restore
#line 209 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10845, languade.Getkey("choosingdownload_Author"), 10845, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"choosingdownload_Author\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10942, "\"", 10975, 1);
#nullable restore
#line 210 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 10950, languade.Getkey("Apply"), 10950, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Apply\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11011, "\"", 11045, 1);
#nullable restore
#line 211 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Reports\Page_FileReport.cshtml"
WriteAttributeValue("", 11019, languade.Getkey("cancel"), 11019, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"cancel\"/>\r\n");
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