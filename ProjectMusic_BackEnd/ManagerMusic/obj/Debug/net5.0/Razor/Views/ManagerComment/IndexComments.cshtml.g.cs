#pragma checksum "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ece2e9bfbe595c10ae2f472ec74db0ac31a5f37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerComment_IndexComments), @"mvc.1.0.view", @"/Views/ManagerComment/IndexComments.cshtml")]
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
#line 1 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece2e9bfbe595c10ae2f472ec74db0ac31a5f37a", @"/Views/ManagerComment/IndexComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagerComment_IndexComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/SidebarMenu/Index.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #97a3b9;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ManagerData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/ManagerData/MenuManagerFile.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
  
    ViewData["Title"] = @languade.Getkey("Song_Comments");
    Layout = "~/Views/Shared/Manager_Data/Page_ManagerCommentMusic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"az-content pd-y-20 pd-lg-y-30 pd-xl-y-40\">\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ece2e9bfbe595c10ae2f472ec74db0ac31a5f37a6107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"az-content-body pd-lg-l-40 d-flex flex-column\">\r\n            <div class=\"az-content-breadcrumb\">\r\n                <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ece2e9bfbe595c10ae2f472ec74db0ac31a5f37a7375", async() => {
#nullable restore
#line 14 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                                     Write(languade.Getkey("Home_page"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                <span>");
#nullable restore
#line 15 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                 Write(languade.Getkey("Admin_Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ece2e9bfbe595c10ae2f472ec74db0ac31a5f37a9491", async() => {
#nullable restore
#line 16 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                                                Write(languade.Getkey("File_management"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                <span>");
#nullable restore
#line 17 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                 Write(languade.Getkey("Song_Comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ece2e9bfbe595c10ae2f472ec74db0ac31a5f37a11632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <h2 class=\"az-content-title\">");
#nullable restore
#line 21 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                    Write(languade.Getkey("Song_Comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <div class=""row"">
                <div class=""col-md-12"">

                    <div class=""row g-3 align-items-center"">
                        <div class=""col-auto"">
                            <input onchange=""evertSeachComment()"" style=""width: 170%; border-radius: 5px;"" type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=", 1388, "", 1441, 1);
#nullable restore
#line 27 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
WriteAttributeValue("", 1401, languade.Getkey("Entersongid_reviewer"), 1401, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>

                    <p style=""text-align:right;"">
                        <a style=""border: none;"" id=""btn-ActiverRemoveComment"" class=""btn btn-outline-secondary"" data-bs-toggle=""tooltip"" data-bs-placement=""right""");
            BeginWriteAttribute("title", " title=\"", 1720, "\"", 1766, 1);
#nullable restore
#line 32 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
WriteAttributeValue("", 1728, languade.Getkey("Delete_allcomments"), 1728, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></a>\r\n                        <a style=\"border: none;\" class=\"btn btn-outline-secondary\">");
#nullable restore
#line 33 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                              Write(languade.Getkey("Comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@": <b>23</b></a>
                    </p>
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">
                                    <input type=""checkbox"" id=""selectall"" />
                                </th>
                                <th scope=""col"">");
#nullable restore
#line 41 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 42 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("namesong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 43 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("Reviewer_name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 44 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("Comment_content"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 45 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("DateCreate_Song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 46 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("Answer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 47 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                           Write(languade.Getkey("Options"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope=""row"">
                                    <input type=""checkbox"" class=""case"" name=""case"" value=""1"" />
                                </th>
                                <td>1</td>
                                <td>tt</td>
                                <td>Otto</td>
                                <td>mdo</td>
                                <td>mdo</td>
                                <td>
                                    <p style=""font-family: inherit; color: green;"">
                                        <i class=""fas fa-plus-circle""></i>
                                        Hoạt Động
                                    </p>
                                </td>
                                <td>
                                    <a style=""border: none;"" id=""btn-ShowChooseOption"" class=""btn");
            WriteLiteral(@" btn-outline-secondary"" ata-bs-toggle=""tooltip"" data-bs-placement=""top"" title=""Lựa Chọn Chức Năng""><i class=""fas fa-ellipsis-v""></i></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>

                </div>
            </div>

            <div class=""az-footer mg-t-auto"">
                <div class=""container"">
                    <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">");
#nullable restore
#line 78 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                                           Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Do <a href=\"#\" target=\"_blank\">");
#nullable restore
#line 79 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                                                                        Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> từ duytuong0503@gmail.com</span>
                </div><!-- container -->
            </div><!-- az-footer -->
        </div><!-- az-content-body -->
    </div><!-- container -->
</div><!-- az-content -->

<!-- choose option activer funtion file -->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal-ShowChooseActiverFile"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><i class=""fas fa-toolbox""></i> ");
#nullable restore
#line 91 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                  Write(languade.Getkey("Aredelete_selectedcomments"));

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
#line 98 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                               Write(languade.Getkey("agree"));

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
#line 103 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                                                                                  Write(languade.Getkey("cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!--Modal show list answer comment -->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal-ShowAnswerComment"">
    <div class=""modal-dialog"" style=""max-width: 90%;"">
        <div class=""modal-content"" style=""height: 600px; overflow: scroll;"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">");
#nullable restore
#line 117 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                   Write(languade.Getkey("Theresponses_reviewcomment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""btn-close"" id=""btn-closemodalAnswerComment"">X</button>
            </div>
            <div class=""modal-body"">
                <table class=""table table-striped table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">");
#nullable restore
#line 124 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                       Write(languade.Getkey("No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 125 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                       Write(languade.Getkey("Respondent_name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 126 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                       Write(languade.Getkey("Reply_content"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 127 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerComment\IndexComments.cshtml"
                                       Write(languade.Getkey("datecreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">1</th>
                            <td>Mark</td>
                            <td>Otto</td>
                            <td>mdo</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

");
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