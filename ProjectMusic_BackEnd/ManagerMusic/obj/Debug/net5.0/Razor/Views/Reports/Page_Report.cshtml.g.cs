#pragma checksum "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc8db76c6a86613331301e3b19bdd362b47ffae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Page_Report), @"mvc.1.0.view", @"/Views/Reports/Page_Report.cshtml")]
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
#line 1 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc8db76c6a86613331301e3b19bdd362b47ffae", @"/Views/Reports/Page_Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Page_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #97a3b9;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Page_FileReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Page_FileChartReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
  
    ViewData["Title"] = languade.Getkey("Report_Management");
    Layout = "~/Views/Shared/Manger_Report/ManagerReport.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"az-content-body pd-lg-l-40 d-flex flex-column\">\r\n    <div class=\"az-content-breadcrumb\">\r\n        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fc8db76c6a86613331301e3b19bdd362b47ffae5812", async() => {
#nullable restore
#line 9 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
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
#line 10 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
         Write(languade.Getkey("Admin_Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 11 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
         Write(languade.Getkey("File_management"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 12 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
         Write(languade.Getkey("Report_Management"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n\r\n    <h2 class=\"az-content-title\"><i class=\"fas fa-tasks-alt\"></i> ");
#nullable restore
#line 15 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
                                                             Write(languade.Getkey("Report_Management"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <div class=""row"">
        <div class=""col-md-5"" style=""margin: 10px 10px; background-color: #ff0000a8; width: 100%; height: 250px; border-radius: 20px;"">
            <label class=""form-label""
                   style=""color: black; font-size: 20px; font-family: initial; font-weight: 600; text-align: center;"">
                ");
#nullable restore
#line 20 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
           Write(languade.Getkey("StatisticalreportSong_file"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <p class=\"hover_File\" style=\"text-align: center; font-size: 100px; margin-top: 20px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fc8db76c6a86613331301e3b19bdd362b47ffae9549", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-file\"></i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </p>
        </div>
        <div class=""col-md-5"" style=""margin: 10px 10px; background-color: #008000a1; width: 100%; height: 250px; border-radius: 20px;"">
            <label class=""form-label"" style=""color: black; font-size: 20px; font-family: initial; font-weight: 600; text-align: center;"">
                ");
#nullable restore
#line 30 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
           Write(languade.Getkey("StatisticalreportEmployee"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </label>
            <p class=""hover_Staff"" style=""text-align: center; font-size: 100px; margin-top: 20px;"">
                <a href=""#"" style=""color: black;"">
                    <i class=""fas fa-user-cog""></i>
                </a>
            </p>
        </div>
        <div class=""col-md-5"" style=""margin: 10px 10px; background-color: #00f1ff82; width: 100%; height: 250px; border-radius: 20px;"">
            <label class=""form-label"" style=""color: black; font-size: 20px; font-family: initial; font-weight: 600; text-align: center;"">
                ");
#nullable restore
#line 40 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
           Write(languade.Getkey("StatisticalreportUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </label>
            <p class=""hover_User"" style=""text-align: center; font-size: 100px; margin-top: 20px;"">
                <a href=""#"" style=""color: black;"">
                    <i class=""fas fa-users""></i>
                </a>
            </p>
        </div>
        <div class=""col-md-5"" style=""margin: 10px 10px; background-color: #2a00ff82; width: 100%; height: 250px; border-radius: 20px;"">
            <label class=""form-label"" style=""color: black; font-size: 20px; font-family: initial; font-weight: 600; text-align: center;"">
                ");
#nullable restore
#line 50 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
           Write(languade.Getkey("Statisticalchart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <p class=\"hover_User\" style=\"text-align: center; font-size: 100px; margin-top: 20px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fc8db76c6a86613331301e3b19bdd362b47ffae13536", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-chart-bar\"></i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"az-footer mg-t-auto\">\r\n        <div class=\"container\">\r\n            <span class=\"text-muted d-block text-center text-sm-left d-sm-inline-block\">\r\n                ");
#nullable restore
#line 63 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
           Write(languade.Getkey("Design_In_2022"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\">\r\n                Do <a href=\"#\"\r\n                      target=\"_blank\">");
#nullable restore
#line 67 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Reports\Page_Report.cshtml"
                                 Write(languade.Getkey("Petros_Tuong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> from duytuong0503@gmail.com\r\n            </span>\r\n        </div><!-- container -->\r\n    </div><!-- az-footer -->\r\n</div><!-- az-content-body -->\r\n");
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
