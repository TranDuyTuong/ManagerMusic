#pragma checksum "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d4a91173bd506d6e148808e151a53dbbc46671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_IndexRegiter), @"mvc.1.0.view", @"/Views/Account/IndexRegiter.cshtml")]
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
#line 1 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4a91173bd506d6e148808e151a53dbbc46671", @"/Views/Account/IndexRegiter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_IndexRegiter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
  
    ViewData["Title"] = languade.Getkey("Sign_Up");
    Layout = "~/Views/Shared/Page_Client/Page_Signup.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""az-signup-wrapper"">
    <div class=""az-column-signup-left"">
        <div>
            <i class=""fas fa-music"" style=""font-size: 50px; margin: 10px 10px;""></i>
            <h1 class=""az-logo"">Manager<span>-</span>Music</h1>
            <h5>");
#nullable restore
#line 13 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
           Write(languade.Getkey("Slogan"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 14 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
          Write(languade.Getkey("Study"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 15 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
          Write(languade.Getkey("Demand"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div><!-- az-column-signup-left -->\r\n    <div class=\"az-column-signup\">\r\n        <div class=\"az-signup-header\">\r\n            <h4>");
#nullable restore
#line 20 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
           Write(languade.Getkey("RegiterAccount_Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n            <div class=\"form-group\">\r\n                <label>");
#nullable restore
#line 23 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                  Write(languade.Getkey("FirstandLast_Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:green;\" id=\"checkOkName\"></span></label>\r\n                <input type=\"text\" id=\"Txt_Name\" class=\"form-control\" onkeyup=\"checkvalueName()\"");
            BeginWriteAttribute("placeholder", "\r\n                       placeholder=\"", 1024, "\"", 1095, 1);
#nullable restore
#line 25 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 1062, languade.Getkey("EnterFullName"), 1062, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius: 10px;\">\r\n                <span style=\"color:red; font-family: initial;\" id=\"ValidaName\"></span>\r\n            </div><!-- form-group -->\r\n            <div class=\"form-group\">\r\n                <label>");
#nullable restore
#line 29 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                  Write(languade.Getkey("Birthday"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span style=""color:green;"" id=""checkOkBirthday""></span></label>
                <input type=""date"" id=""Txt_Birthday"" class=""form-control"" onclick=""checkvalueBirthday()"" style=""border-radius: 10px;"">
                <span style=""color:red; font-family: initial;"" id=""ValidaBirthday""></span>
            </div><!-- form-group -->
            <div class=""form-group"">
                <label>Email <span style=""color:green;"" id=""checkOkGmail""></span></label>
                <input type=""email"" id=""Txt_Gmail"" class=""form-control"" onkeyup=""checkvalueGmail()""");
            BeginWriteAttribute("placeholder", "\r\n                       placeholder=\"", 1905, "\"", 1974, 1);
#nullable restore
#line 36 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 1943, languade.Getkey("Enter_Gmail"), 1943, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius: 10px;\">\r\n                <span style=\"color:red; font-family: initial;\" id=\"ValidaGmail\"></span>\r\n            </div><!-- form-group -->\r\n            <div class=\"form-group\">\r\n                <label>");
#nullable restore
#line 40 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                  Write(languade.Getkey("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:green;\" id=\"checkOkPassword\"></span></label>\r\n                <input type=\"password\" id=\"Txt_Password\" class=\"form-control\" onkeyup=\"checkvaluePassword()\"");
            BeginWriteAttribute("placeholder", "\r\n                       placeholder=\"", 2398, "\"", 2470, 1);
#nullable restore
#line 42 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 2436, languade.Getkey("Enter_Password"), 2436, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius: 10px;\">\r\n                <p style=\"margin-top: 10px; font-family: initial; text-align: right;\">\r\n                    <input type=\"checkbox\" onclick=\"myFunction()\">");
#nullable restore
#line 44 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                                                             Write(languade.Getkey("Show_Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>               \r\n                <span style=\"color:red; font-family: initial;\" id=\"ValidaPassword\"></span>\r\n            </div><!-- form-group -->\r\n            <div class=\"form-group\">\r\n                <label>");
#nullable restore
#line 49 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                  Write(languade.Getkey("ChooseGender"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span style=""color:green;"" id=""checkOkGender""></span></label>
                <div class=""row g-3 align-items-center"" style=""margin-left: 20px;"">
                      <div class=""col-auto"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""CheckGender"" value=""1"" id=""Checkman"" />
                            <label class=""form-check-label"" style=""color: black; font-weight: 600;"">
                                ");
#nullable restore
#line 55 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                           Write(languade.Getkey("gentleman"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                        </div>
                      </div>
                      <div class=""col-auto"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""CheckGender"" value=""2"" id=""Checkwoment"" />
                            <label class=""form-check-label"" style=""color: black; font-weight: 600;"">
                                ");
#nullable restore
#line 63 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                           Write(languade.Getkey("Ladies"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                        </div>
                      </div>
                </div>
                <span style=""color:red; font-family: initial;"" id=""ValidaGender""></span>
            </div><!-- form-group -->
            <div class=""form-group"">
                <label>");
#nullable restore
#line 71 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                  Write(languade.Getkey("ChooseAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:green;\" id=\"checkOkAddress\"></span></label>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <input type=\"hidden\" id=\"S_City\"");
            BeginWriteAttribute("value", " value=\"", 4511, "\"", 4549, 1);
#nullable restore
#line 74 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 4519, languade.Getkey("ChooseCity"), 4519, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <select class=\"form-control\" id=\"SelectCity\" style=\"border-radius: 10px;\"></select>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <input type=\"hidden\" id=\"S_District\"");
            BeginWriteAttribute("value", " value=\"", 4796, "\"", 4838, 1);
#nullable restore
#line 78 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 4804, languade.Getkey("ChooseDistrict"), 4804, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <select class=""form-control"" id=""SelectDistrict"" style=""border-radius: 10px;"" disabled></select>
                    </div>
                </div>
                <span style=""color:red; font-family: initial;"" id=""ValidaAddress""></span>
            </div><!-- form-group -->

            <button class=""btn btn-primary btn-block"" id=""btn_SignUp"" style=""border-radius: 10px;"">");
#nullable restore
#line 85 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                                                                                              Write(languade.Getkey("Regiter_page"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n        </div><!-- az-signup-header -->\r\n        <div class=\"az-signup-footer\">\r\n            <p>Đã có tài khoản? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d4a91173bd506d6e148808e151a53dbbc4667115233", async() => {
#nullable restore
#line 89 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
                                                                          Write(languade.Getkey("Login"));

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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        </div><!-- az-signin-footer -->\r\n    </div><!-- az-column-signup -->\r\n</div><!-- az-signup-wrapper -->\r\n<!--Message Translation-->\r\n<input type=\"hidden\" id=\"ErrorDistrict\"");
            BeginWriteAttribute("value", " value=\"", 5668, "\"", 5712, 1);
#nullable restore
#line 94 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 5676, languade.Getkey("NoFound_District"), 5676, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"NotificationError\"");
            BeginWriteAttribute("value", " value=\"", 5761, "\"", 5807, 1);
#nullable restore
#line 95 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 5769, languade.Getkey("Notification_Error"), 5769, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"NotificationSuccess\"");
            BeginWriteAttribute("value", " value=\"", 5859, "\"", 5907, 1);
#nullable restore
#line 96 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 5867, languade.Getkey("Nofitication_Success"), 5867, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"ErrorChooseCity\"");
            BeginWriteAttribute("value", " value=\"", 5955, "\"", 5993, 1);
#nullable restore
#line 97 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 5963, languade.Getkey("ChooseCity"), 5963, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"ErrorGender\"");
            BeginWriteAttribute("value", " value=\"", 6037, "\"", 6077, 1);
#nullable restore
#line 98 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6045, languade.Getkey("ChooseGender"), 6045, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"ErrorNulData\"");
            BeginWriteAttribute("value", " value=\"", 6122, "\"", 6162, 1);
#nullable restore
#line 99 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6130, languade.Getkey("NotNull_Data"), 6130, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"ErrorMaximunlength\"");
            BeginWriteAttribute("value", " value=\"", 6213, "\"", 6255, 1);
#nullable restore
#line 100 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6221, languade.Getkey("Maximun_length"), 6221, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"EmailAlreadyExists\"");
            BeginWriteAttribute("value", " value=\"", 6306, "\"", 6354, 1);
#nullable restore
#line 101 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6314, languade.Getkey("Email_already_exists"), 6314, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"EmailRegiterSuccess\"");
            BeginWriteAttribute("value", " value=\"", 6406, "\"", 6448, 1);
#nullable restore
#line 102 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6414, languade.Getkey("RegiterSuccess"), 6414, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"ErrorRegiterFail\"");
            BeginWriteAttribute("value", " value=\"", 6497, "\"", 6537, 1);
#nullable restore
#line 103 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6505, languade.Getkey("RegiterError"), 6505, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"ErrorEmailsyntax\"");
            BeginWriteAttribute("value", " value=\"", 6586, "\"", 6635, 1);
#nullable restore
#line 104 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6594, languade.Getkey("Emailsyntax_incorrect"), 6594, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n<input type=\"hidden\" id=\"Passwordcharacterandnumber\"");
            BeginWriteAttribute("value", " value=\"", 6694, "\"", 6749, 1);
#nullable restore
#line 105 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6702, languade.Getkey("Password_characterandnumber"), 6702, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n<input type=\"hidden\" id=\"PasswordUppercase\"");
            BeginWriteAttribute("value", " value=\"", 6797, "\"", 6843, 1);
#nullable restore
#line 106 "D:\Development_Project\Dev_ManagerMusic\ProjectMusic_BackEnd\ProjectManagerMusic\ManagerMusic\Views\Account\IndexRegiter.cshtml"
WriteAttributeValue("", 6805, languade.Getkey("Password_uppercase"), 6805, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n\r\n");
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