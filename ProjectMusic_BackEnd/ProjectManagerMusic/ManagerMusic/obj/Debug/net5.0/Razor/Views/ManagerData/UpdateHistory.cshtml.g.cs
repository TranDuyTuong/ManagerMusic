#pragma checksum "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adfe58a58f94d59aa2fd335d58dec708f920e0b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerData_UpdateHistory), @"mvc.1.0.view", @"/Views/ManagerData/UpdateHistory.cshtml")]
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
#line 1 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adfe58a58f94d59aa2fd335d58dec708f920e0b3", @"/Views/ManagerData/UpdateHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagerData_UpdateHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
  
    ViewData["Title"] = @languade.Getkey("Update_history");
    Layout = "~/Views/Shared/Manager_Data/Page_DetailFileMusic.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
   
    Guid Id_Music = ViewBag.IdMusic;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"az-content-body pd-lg-l-40 d-flex flex-column\">\r\n    <div class=\"az-content-breadcrumb\">\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adfe58a58f94d59aa2fd335d58dec708f920e0b36072", async() => {
#nullable restore
#line 13 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
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
#line 14 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
         Write(languade.Getkey("Admin_Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adfe58a58f94d59aa2fd335d58dec708f920e0b38150", async() => {
#nullable restore
#line 15 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 694, "\"", 768, 1);
#nullable restore
#line 16 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 701, Url.Action("DetailMusic","ManagerData", new {IdMusic =  Id_Music}), 701, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #97a3b9;\">");
#nullable restore
#line 16 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                                                                                               Write(languade.Getkey("DetailSong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n        <span>");
#nullable restore
#line 17 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
         Write(languade.Getkey("Update_history"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adfe58a58f94d59aa2fd335d58dec708f920e0b311166", async() => {
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
#line 20 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                            Write(languade.Getkey("Update_history"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <p style=\"color:black; font-size:15px; text-align:right;\">");
#nullable restore
#line 23 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                                                 Write(languade.Getkey("Total_Update"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": <b style=\"color:red\" id=\"TotalHistory\"></b></p>\r\n            <table class=\"table table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 27 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 28 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("Editor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 29 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("the_song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 30 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("File_Content"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 31 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("Music_composer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 32 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("Current_Season"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 33 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("Current_Outings"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 34 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                   Write(languade.Getkey("Update"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"bodyHistory\">\r\n                </tbody>\r\n            </table>\r\n            <p style=\"text-align:right;\">");
#nullable restore
#line 40 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                    Write(languade.Getkey("page"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" : <b id=""ItemInPageHistory"" style=""color:red;""></b>/<b id=""TotalItemHistory"" style=""color:black;""></b></p>
            <!-- Pagination -->
            <div class=""row"" style=""clear: both;"">
                <div id=""paginationHitory"" class=""pagination""></div>
            </div>

        </div>
    </div>

    <div class=""az-footer mg-t-auto"">
        <div class=""container"">
            <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">");
#nullable restore
#line 51 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                                                                   Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Do <a href=\"#\" target=\"_blank\">");
#nullable restore
#line 52 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
                                                                                                                Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> from duytuong0503@gmail.com</span>\r\n        </div><!-- container -->\r\n    </div><!-- az-footer -->\r\n</div><!-- az-content-body -->\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3003, "\"", 3027, 1);
#nullable restore
#line 57 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3011, ViewBag.IdMusic, 3011, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdMusic\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3066, "\"", 3098, 1);
#nullable restore
#line 58 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3074, languade.Getkey("head"), 3074, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"head\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3134, "\"", 3166, 1);
#nullable restore
#line 59 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3142, languade.Getkey("next"), 3142, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"next\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3202, "\"", 3234, 1);
#nullable restore
#line 60 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3210, languade.Getkey("last"), 3210, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"last\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3270, "\"", 3304, 1);
#nullable restore
#line 61 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3278, languade.Getkey("Before"), 3278, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Before\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3342, "\"", 3382, 1);
#nullable restore
#line 62 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3350, languade.Getkey("OldSong_Name"), 3350, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"OldSong_Name\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3425, "\"", 3465, 1);
#nullable restore
#line 63 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3433, languade.Getkey("NewSong_Name"), 3433, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"NewSong_Name\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3508, "\"", 3547, 1);
#nullable restore
#line 64 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3516, languade.Getkey("Old_Content"), 3516, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Old_Content\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3589, "\"", 3628, 1);
#nullable restore
#line 65 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3597, languade.Getkey("New_Content"), 3597, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"New_Content\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3670, "\"", 3708, 1);
#nullable restore
#line 66 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3678, languade.Getkey("Old_Author"), 3678, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Old_Author\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3749, "\"", 3787, 1);
#nullable restore
#line 67 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\ManagerData\UpdateHistory.cshtml"
WriteAttributeValue("", 3757, languade.Getkey("New_Author"), 3757, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"New_Author\"/>\r\n\r\n");
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
