#pragma checksum "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0920fe2367c6dfaba38765cc9bed23437044b787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerData_UpdateMusic), @"mvc.1.0.view", @"/Views/ManagerData/UpdateMusic.cshtml")]
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
#line 1 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0920fe2367c6dfaba38765cc9bed23437044b787", @"/Views/ManagerData/UpdateMusic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagerData_UpdateMusic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #97a3b9;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ManagerData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/ManagerData/MenuManagerFile.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
  
    ViewData["Title"] = @languade.Getkey("Update_Song");
    Layout = "~/Views/Shared/Manager_Data/Page_EditFileMusic.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
  
    Guid Id = ViewBag.IdMuiscUpdate;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"az-content-body pd-lg-l-40 d-flex flex-column\">\r\n    <div class=\"az-content-breadcrumb\">\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0920fe2367c6dfaba38765cc9bed23437044b7875855", async() => {
#nullable restore
#line 12 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
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
#line 13 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
         Write(languade.Getkey("Admin_Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0920fe2367c6dfaba38765cc9bed23437044b7877865", async() => {
#nullable restore
#line 14 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                        Write(languade.Getkey("File_management"));

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
            WriteLiteral("</span>\r\n        <span><a");
            BeginWriteAttribute("href", " href=\"", 686, "\"", 753, 1);
#nullable restore
#line 15 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 693, Url.Action("DetailMusic","ManagerData", new {IdMusic = Id}), 693, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #97a3b9;\">");
#nullable restore
#line 15 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                                        Write(languade.Getkey("DetailSong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n        <span>");
#nullable restore
#line 16 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
         Write(languade.Getkey("Update_Song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0920fe2367c6dfaba38765cc9bed23437044b78710728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h2 class=\"az-content-title\">");
#nullable restore
#line 19 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                            Write(languade.Getkey("Update_Song"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""col-md-4"">

                    <div class=""mb-3"">
                        <p style=""text-align: center; font-family: inherit; font-weight: 600;""><i class=""fas fa-file-word""></i> Phần File</p>
                        <label class=""form-label"">");
#nullable restore
#line 27 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                             Write(languade.Getkey("UpdateFile_Muisc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input type=""file"" class=""form-control"" style=""border-radius: 10px;"" id=""FileExport"">
                        <span style=""color:red; font-family: initial;"" id=""ValidaFileNameMusic""></span>
                        <div class=""form-text"">
                            ");
#nullable restore
#line 31 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("NoteFormat_file"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            ");
#nullable restore
#line 32 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("songname_currentdatemonthyear"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            ");
#nullable restore
#line 33 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("example"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            ");
#nullable restore
#line 34 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("inputFile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <p style=\"text-align:right; color:red;\" id=\"TxtNameFile\"></p>\r\n                    </div>\r\n\r\n                    <div class=\"mb-3\">\r\n                        <label class=\"form-label\">");
#nullable restore
#line 40 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                             Write(languade.Getkey("UpdateImage_Muisc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input type=""file"" class=""form-control"" style=""border-radius: 10px;"" id=""FileImageExport"">
                        <span style=""color:red; font-family: initial;"" id=""ValidaFileIamgeMusic""></span>
                        <div class=""form-text"">
                            ");
#nullable restore
#line 44 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("NoteFormat_Image"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            ");
#nullable restore
#line 45 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("songname_currentdatemonthyear"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            ");
#nullable restore
#line 46 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("example"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        </div>\r\n                        <button style=\"margin-left: 190px; border: none; font-size: 15px; background: none; color: blue; font-weight: 600; \" id=\"ViewImage\" type=\"button\">");
#nullable restore
#line 48 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                                                                                                     Write(languade.Getkey("ReadFile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <hr />\r\n                        <p>\r\n                            ");
#nullable restore
#line 51 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("Filecurrently_use"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@": <a id=""CurrentFile""></a>
                        </p>

                    </div>

                </div>
                <div class=""col-md-8"">

                    <div class=""mb-3"">
                        <p style=""text-align: center; font-family: inherit; font-weight: 600;""><i class=""fas fa-file""></i> ");
#nullable restore
#line 60 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                                                      Write(languade.Getkey("Generalinformation_section"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <label class=\"form-label\">\r\n                            <span style=\"color:green;\" id=\"checkOkNameMusic\"></span>\r\n                            ");
#nullable restore
#line 63 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("namesong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <a id=\"btn_EditNameMusic\" style=\"font-size: 20px; margin: 3px 3px; color: blue;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 3853, "\"", 3895, 1);
#nullable restore
#line 65 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 3861, languade.Getkey("Editsong_title"), 3861, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n\r\n                            <a id=\"btn_SaveNameMusic\" style=\"font-size: 20px; margin: 3px 3px; color: black;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 4092, "\"", 4134, 1);
#nullable restore
#line 67 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 4100, languade.Getkey("Savesong_title"), 4100, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-save\"></i></a>\r\n\r\n                            <a id=\"btn_RemoveNameMusic\" style=\"font-size: 20px; margin: 3px 3px; color: red;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 4331, "\"", 4375, 1);
#nullable restore
#line 69 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 4339, languade.Getkey("Canceledit_title"), 4339, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-window-close""></i></a>

                        </label>
                        <input id=""Txt_EnterNameMusic"" onkeyup=""CheckValueNameMusic()"" style=""border-radius: 5px;"" type=""text"" class=""form-control"" disabled>
                        <span style=""color:red; font-family: initial;"" id=""ValidaNameMusic""></span>
                    </div>

                    <div class=""mb-3"">
                        <label class=""form-label"">
                            <span style=""color:green;"" id=""checkOkNameAuthor""></span>
                            ");
#nullable restore
#line 79 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("Authour_Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <a id=\"btn_EditNameAuthor\" style=\"font-size: 20px; margin: 3px 3px; color: blue;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 5147, "\"", 5185, 1);
#nullable restore
#line 81 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 5155, languade.Getkey("Editauthor"), 5155, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n\r\n                            <a id=\"btn_SaveNameAuthor\" style=\"font-size: 20px; margin: 3px 3px; color: black;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 5383, "\"", 5421, 1);
#nullable restore
#line 83 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 5391, languade.Getkey("Saveauthor"), 5391, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-save\"></i></a>\r\n\r\n                            <a id=\"btn_RemoveNameAuthor\" style=\"font-size: 20px; margin: 3px 3px; color: red;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 5619, "\"", 5664, 1);
#nullable restore
#line 85 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 5627, languade.Getkey("Canceledit_author"), 5627, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-window-close""></i></a>

                        </label>
                        <input id=""Txt_EnterNameAuthor"" onkeyup=""CheckValueNameAuthor()"" style=""border-radius: 5px;"" type=""text"" class=""form-control"" disabled>
                        <span style=""color:red; font-family: initial;"" id=""ValidaNameAuthor""></span>
                    </div>

                    <div class=""mb-3"">
                        <label class=""form-label"">
                            ");
#nullable restore
#line 94 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("Choose_the_Season_You_Need"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <a id=\"btn_EditSeason\" style=\"font-size: 20px; margin: 3px 3px; color: blue;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 6362, "\"", 6410, 1);
#nullable restore
#line 96 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 6370, languade.Getkey("Choose_anotherseason"), 6370, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n\r\n                            <a id=\"btn_SaveSeason\" style=\"font-size: 20px; margin: 3px 3px; color: black;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 6604, "\"", 6643, 1);
#nullable restore
#line 98 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 6612, languade.Getkey("Save_season"), 6612, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-save""></i></a>

                        </label>
                        <select style=""border-radius: 5px;"" class=""form-control"" id=""SelectSeason"" disabled>
                        </select>
                    </div>

                    <div class=""mb-3"">
                        <label class=""form-label"">
                            ");
#nullable restore
#line 107 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                       Write(languade.Getkey("special holidays"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <a id=\"btn_EditSainst\" style=\"font-size: 20px; margin: 3px 3px; color: blue;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 7205, "\"", 7253, 1);
#nullable restore
#line 109 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 7213, languade.Getkey("Chooseanother_saints"), 7213, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n\r\n                            <a id=\"btn_SaveSainst\" style=\"font-size: 20px; margin: 3px 3px; color: black;\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 7447, "\"", 7485, 1);
#nullable restore
#line 111 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 7455, languade.Getkey("Save_saint"), 7455, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-save""></i></a>

                        </label>
                        <select style=""border-radius: 5px;"" class=""form-control"" id=""SelectSainst"" disabled>
                        </select>
                    </div>

                    <p style=""text-align: right;"">
                        <button id=""btn_confimEdit"" style=""border-radius: 5px;"" type=""button"" class=""btn btn-outline-secondary""><i class=""fas fa-edit""></i> ");
#nullable restore
#line 119 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                                                                                       Write(languade.Getkey("ConfirmEdit_Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                    </p>

                </div>
            </div>
        </div>
    </div>

    <div class=""az-footer mg-t-auto"">
        <div class=""container"">
            <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">");
#nullable restore
#line 129 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                   Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Do <a href=\"#\" target=\"_blank\">");
#nullable restore
#line 130 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                                                                                                Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> from duytuong0503@gmail.com</span>
        </div><!-- container -->
    </div><!-- az-footer -->
</div><!-- az-content-body -->
<!-- Modal loading create Music -->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal_LoadingCreateMusic"">
    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""background:none; border:none;"">
            <div class=""modal-body"">
                <div class=""row"" style=""margin-top:200px;"">
                    <div class=""col-md-4""></div>
                    <div class=""col-md-4"">
                        <div class=""spinner-grow text-primary"" role=""status"">
                            <span class=""visually-hidden""></span>
                        </div>
                        <div class=""spinner-grow text-secondary"" role=""status"">
                            <span class=""visually-hidden""></span>
                        </div>
                        <div class=""spinner-grow text-success"" role=""status"">
                       ");
            WriteLiteral(@"     <span class=""visually-hidden""></span>
                        </div>
                    </div>
                    <div class=""col-md-4""></div>
                </div>
            </div>
        </div>
    </div>
</div>

<!--modal read content in file .doc-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal-ShowContentFileDox"">
    <div class=""modal-dialog"" style=""max-width: 90%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 164 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                   Write(languade.Getkey("File_Contents"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fas fa-file-image""></i></h5>
                <button type=""button"" class=""btn-close"" id=""btn_closecontentfile"">X</button>
            </div>
            <div class=""modal-body"" id=""ImageMusic_Data"" style=""height: 600px; overflow: scroll;"">
            </div>
        </div>
    </div>
</div>

<!--modal read content in file .doc update-->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal_ShowContentFileUpdate"">
    <div class=""modal-dialog"" style=""max-width: 90%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 178 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
                                   Write(languade.Getkey("File_Contents"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fas fa-file-image""></i></h5>
                <button type=""button"" class=""btn-close"" id=""btn_closecontentfileImage"">X</button>
            </div>
            <div class=""modal-body"" id=""ImageMusic_DataUpdate"" style=""height: 600px; overflow: scroll;"">
                <img id=""img_NewAvata"" style=""width: auto; height: auto"" />
            </div>
        </div>
    </div>
</div>

<input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 11114, "\"", 11144, 1);
#nullable restore
#line 188 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11122, ViewBag.IdMuiscUpdate, 11122, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdMuisc\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11183, "\"", 11229, 1);
#nullable restore
#line 189 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11191, languade.Getkey("Notification_Error"), 11191, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Notification_Error\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11279, "\"", 11327, 1);
#nullable restore
#line 190 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11287, languade.Getkey("Nofitication_Success"), 11287, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Nofitication_Success\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11379, "\"", 11418, 1);
#nullable restore
#line 191 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11387, languade.Getkey("NotFindSong"), 11387, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"NotFindSong\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11461, "\"", 11501, 1);
#nullable restore
#line 192 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11469, languade.Getkey("IdMmusicNull"), 11469, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdMmusicNull\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11545, "\"", 11593, 1);
#nullable restore
#line 193 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11553, languade.Getkey("Younot_selectedimage"), 11553, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Younot_selectedimage\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11644, "\"", 11685, 1);
#nullable restore
#line 194 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11652, languade.Getkey("SystemRequest"), 11652, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"SystemRequest\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11729, "\"", 11770, 1);
#nullable restore
#line 195 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11737, languade.Getkey("ImageNot_Null"), 11737, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"ImageNot_Null\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11814, "\"", 11862, 1);
#nullable restore
#line 196 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11822, languade.Getkey("NotFindIdUser_Create"), 11822, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"NotFindIdUser_Create\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11914, "\"", 11961, 1);
#nullable restore
#line 197 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 11922, languade.Getkey("UpdateMusic_Success"), 11922, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"UpdateMusic_Success\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 12011, "\"", 12056, 1);
#nullable restore
#line 198 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\ManagerData\UpdateMusic.cshtml"
WriteAttributeValue("", 12019, languade.Getkey("UpdateMusic_Erorr"), 12019, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"UpdateMusic_Erorr\"/>");
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
