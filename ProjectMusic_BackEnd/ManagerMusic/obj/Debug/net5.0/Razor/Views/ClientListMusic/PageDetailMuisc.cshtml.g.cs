#pragma checksum "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2841da8961f6719ea2f6aae5baee25f52e3712a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientListMusic_PageDetailMuisc), @"mvc.1.0.view", @"/Views/ClientListMusic/PageDetailMuisc.cshtml")]
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
#line 1 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2841da8961f6719ea2f6aae5baee25f52e3712a4", @"/Views/ClientListMusic/PageDetailMuisc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_ClientListMusic_PageDetailMuisc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexListMusic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ClientListMusic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
  
    ViewData["Title"] = languade.Getkey("DetailSong");
    Layout = "~/Views/Shared/Page_Client/DetailMusic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""az-content az-content-dashboard"">
    <div class=""container"">
        <div class=""az-content-body"">
            <div class=""az-dashboard-one-title"">
                <div>
                    <h3 class=""az-dashboard-title"" id=""Txt_TitleMusic""></h3>
                </div>
                <div class=""az-content-header-right"">

                    <div class=""media"">
                        <div class=""media-body"">
                            <button onclick=""Btn_DowloadFilePDF()"" type=""button"" style=""border-radius: 10px;"" class=""btn btn-primary"" data-bs-toggle=""tooltip"" data-bs-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 810, "\"", 850, 1);
#nullable restore
#line 19 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 818, languade.Getkey("Dowload_Song"), 818, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-download""></i></button>
                        </div><!-- media-body -->
                    </div><!-- media -->

                    <div class=""media"">
                        <div class=""media-body"">
                            <button id=""btn_Comment"" type=""button"" style=""border-radius: 10px;"" class=""btn btn-success"" data-bs-toggle=""tooltip"" data-bs-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 1248, "\"", 1289, 1);
#nullable restore
#line 25 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 1256, languade.Getkey("Song_Comments"), 1256, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-comment""></i></button>
                        </div><!-- media-body -->
                    </div><!-- media -->

                    <div class=""media"">
                        <div class=""media-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2841da8961f6719ea2f6aae5baee25f52e3712a47723", async() => {
                WriteLiteral("<i class=\"fas fa-chevron-left\"></i>");
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
#line 31 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
AddHtmlAttributeValue("", 1721, languade.Getkey("List_music"), 1721, 30, false);

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
            WriteLiteral(@"
                        </div><!-- media-body -->
                    </div><!-- media -->

                </div><!-- media -->
            </div>
        </div><!-- az-dashboard-one-title -->
    </div><!-- row -->
</div><!-- row -->

<div class=""container"">
    <div class=""row"">    
        <div class=""col-md-8"" style=""border:1px solid black;"">
            <p style=""text-align: center; font-size:20px; font-family: inherit;"">");
#nullable restore
#line 44 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                                                            Write(languade.Getkey("Contentsong_file"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div>
                <button style=""border-radius: 10px;"" class=""btn btn-primary"" type=""button"" onclick=""zoomin()""><i class=""fas fa-plus""></i></button>
                <button style=""border-radius: 10px;"" class=""btn btn-primary"" type=""button"" onclick=""zoomout()""><i class=""fas fa-minus""></i></button>
                <button style=""border-radius: 10px;"" class=""btn btn-primary"" type=""button"" onclick=""FullCreen()""><i class=""fas fa-expand-arrows-alt""></i></button>
                <button style=""border-radius: 10px;"" class=""btn btn-primary"" type=""button"" onclick=""ViewPDFfile()""><i class=""fas fa-file-pdf""></i></button>
            </div>
            <div class=""main dragscroll"">
            </div>
        </div>
        <div class=""col-md-4"">
            <p style=""text-align: center; font-size:20px; font-family: inherit;"">");
#nullable restore
#line 55 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                                                            Write(languade.Getkey("Attached_info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 58 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("IdMusic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtIdMuiscs\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 63 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("Authour_Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtAuthor\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 68 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("DateCreate_Song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtDateCreate\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 73 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("NameFile_Song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtFileName\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 78 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("Seasons"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtNameSeason\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 83 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("Name_Saint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtNameSaint\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 88 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("Totalnumber_song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtTotalLike\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 93 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("Downloads"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input style=\"border-radius: 10px;\" type=\"text\" class=\"form-control\" id=\"TxtTotalDowload\" disabled>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label class=\"form-label\">");
#nullable restore
#line 98 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                     Write(languade.Getkey("Comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                <input style=""border-radius: 10px;"" type=""text"" class=""form-control"" id=""TxtTotalComment"" disabled>
            </div>

        </div>

    </div>
</div>

<!-- </div> az-content-body -->
<!--</div>-->
<!-- </div>az-content -->

<div class=""az-footer ht-40"">
    <div class=""container ht-100p pd-t-0-f"">
        <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">");
#nullable restore
#line 113 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                                                               Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Do <a href=\"#\" target=\"_blank\">");
#nullable restore
#line 114 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                                                                                            Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> from duytuong0503@gmail.com</span>
    </div><!-- container -->
</div><!-- az-footer -->
<!--comment-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal_Comment"">
    <div class=""modal-dialog"" style=""max-width: 70%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><i class=""fas fa-comments""></i> ");
#nullable restore
#line 122 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                                                   Write(languade.Getkey("Total_Com"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" (<b id=""TotalComment""></b>)</h5>
                <button type=""button"" class=""btn-close"" id=""colse_Comment"">X</button>
            </div>
            <div class=""modal-body"">
                <div class=""row"" id=""DisplayComment"">
                    <div class=""col-md-6"">
                        <input id=""TxtCommentMusic"" style=""border-radius: 5px;"" type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6712, "\"", 6765, 2);
#nullable restore
#line 128 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 6726, languade.Getkey("Comment_content"), 6726, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6761, "...", 6762, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <button id=\"Btn_SentComment\" style=\"border-radius: 5px;\" type=\"button\" class=\"btn btn-primary\">");
#nullable restore
#line 131 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                                                                                                  Write(languade.Getkey("sent"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                    </div>
                </div>
                <div class=""row"" style=""height: 450px; overflow: scroll;"">
                    <div class=""col-md-12"">
                        <hr />
                        <ul class=""list-group list-group-flush"" id=""BodyComment"">
                        </ul>
                    </div>
                </div>


            </div>
        </div>
    </div>
</div>

");
            WriteLiteral("<div class=\"modal showmodal-seachNamemusic\" tabindex=\"-1\" id=\"modalFull_Screen\">\r\n    <div class=\"modal-dialog\" style=\"max-width: 90%;\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">");
#nullable restore
#line 153 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
                                   Write(languade.Getkey("the_song"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""CloseScreen"">X</button>
            </div>
            <div class=""modal-body"" style=""overflow: scroll; height: 650px;"" id=""BodayImage"">
                
            </div>
        </div>
    </div>
</div>
<input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 8034, "\"", 8058, 1);
#nullable restore
#line 162 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 8042, ViewBag.IdMuisc, 8042, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdMusic_D\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 8098, "\"", 8139, 1);
#nullable restore
#line 163 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 8106, languade.Getkey("first_comment"), 8106, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"first_comment\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 8183, "\"", 8229, 1);
#nullable restore
#line 164 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 8191, languade.Getkey("Notification_Error"), 8191, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Notification_Error\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 8278, "\"", 8323, 1);
#nullable restore
#line 165 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ClientListMusic\PageDetailMuisc.cshtml"
WriteAttributeValue("", 8286, languade.Getkey("entercomment_text"), 8286, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"entercomment_text\"/>\r\n");
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
