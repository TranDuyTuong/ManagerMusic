#pragma checksum "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be754669cbe42f95ed977ff09577f0aed5d6f70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_PageNotificationUer), @"mvc.1.0.view", @"/Views/Notification/PageNotificationUer.cshtml")]
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
#line 1 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
using ManagerMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be754669cbe42f95ed977ff09577f0aed5d6f70d", @"/Views/Notification/PageNotificationUer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51664b79307bd63df294b5f5a17da78d6e89f010", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_PageNotificationUer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PageNotificationUer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Notification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
  
    ViewData["Title"] = languade.Getkey("User_Notice");
    Layout = "~/Views/Shared/Page_Client/ViewAllNotifications.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""az-content az-content-dashboard"">
    <div class=""container"">
        <div class=""az-content-body"">
            <div class=""az-dashboard-one-title"">
                <div>
                    <h3 class=""az-dashboard-title""><i class=""fas fa-bell""></i> ");
#nullable restore
#line 13 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                                                          Write(languade.Getkey("All_Notification"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""az-content-header-right"">

                    <div class=""media"">
                        <div class=""media-body"">
                            <button id=""btn_remove"" type=""button"" style=""border-radius: 10px;"" class=""btn btn-primary"" data-bs-toggle=""tooltip"" data-bs-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 849, "\"", 886, 1);
#nullable restore
#line 19 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 857, languade.Getkey("RemoveAll"), 857, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                        </div><!-- media-body -->\r\n                    </div><!-- media -->\r\n\r\n                    <div class=\"media\">\r\n                        <div class=\"media-body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be754669cbe42f95ed977ff09577f0aed5d6f70d7250", async() => {
                WriteLiteral("<i class=\"fas fa-spinner\"></i>");
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
#line 25 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
AddHtmlAttributeValue("", 1315, languade.Getkey("reset"), 1315, 25, false);

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

                    <div class=""media"">
                        <div class=""media-body"">
                            <button type=""button"" style=""border-radius: 10px;"" class=""btn btn-secondary"">
                                ");
#nullable restore
#line 32 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                           Write(languade.Getkey("you_have"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b style=\"color: red;\" id=\"NumberNotification\"></b> ");
#nullable restore
#line 32 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                                                                                            Write(languade.Getkey("Notifiction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </button>
                        </div><!-- media-body -->
                    </div><!-- media -->

                </div><!-- media -->
            </div>
        </div><!-- az-dashboard-one-title -->
    </div><!-- row -->
</div><!-- row -->

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">

            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">
                            <input type=""checkbox"" id=""selectall"" />
                        </th>
                        <th scope=""col"">");
#nullable restore
#line 53 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 54 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("NotificationContent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 55 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("People_notice"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 56 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("time"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 57 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("datecreate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 58 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 59 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                   Write(languade.Getkey("Options"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"T_bodyNotification\">\r\n                </tbody>\r\n            </table>\r\n            <p style=\"text-align:right;\">");
#nullable restore
#line 65 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
                                    Write(languade.Getkey("page"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" : <b id=""TotalItem"" style=""color:red;""></b>/<b id=""ItemInPage"" style=""color:black;""></b></p>
            <!-- Pagination -->
            <div class=""row"" style=""clear: both;"">
                <div id=""pagination"" class=""pagination""></div>
            </div>

        </div>
    </div>
</div>

<!-- Modal loading create Music -->
<div class=""modal showmodal-seachNamemusic"" tabindex=""-1"" id=""modal_Loading"">
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
                            <span class=""visu");
            WriteLiteral(@"ally-hidden""></span>
                        </div>
                        <div class=""spinner-grow text-success"" role=""status"">
                            <span class=""visually-hidden""></span>
                        </div>
                    </div>
                    <div class=""col-md-4""></div>
                </div>
            </div>
        </div>
    </div>
</div>
<input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 4605, "\"", 4655, 1);
#nullable restore
#line 99 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 4613, languade.Getkey("RemovethisNotificaiton"), 4613, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"btn_ReomveData\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4701, "\"", 4733, 1);
#nullable restore
#line 100 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 4709, languade.Getkey("head"), 4709, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"head\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4769, "\"", 4801, 1);
#nullable restore
#line 101 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 4777, languade.Getkey("next"), 4777, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"next\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4837, "\"", 4869, 1);
#nullable restore
#line 102 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 4845, languade.Getkey("last"), 4845, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"last\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4905, "\"", 4939, 1);
#nullable restore
#line 103 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 4913, languade.Getkey("Before"), 4913, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Before\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4977, "\"", 5012, 1);
#nullable restore
#line 104 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 4985, languade.Getkey("watched"), 4985, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"watched\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5050, "\"", 5086, 1);
#nullable restore
#line 105 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 5058, languade.Getkey("not_seen"), 5058, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"not_seen\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5125, "\"", 5172, 1);
#nullable restore
#line 106 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 5133, languade.Getkey("Delete_Notification"), 5133, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"ChooseRow\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5212, "\"", 5258, 1);
#nullable restore
#line 107 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 5220, languade.Getkey("Notification_Error"), 5220, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Notification_Error\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5307, "\"", 5346, 1);
#nullable restore
#line 108 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 5315, languade.Getkey("RemoveError"), 5315, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"RemoveError\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5388, "\"", 5436, 1);
#nullable restore
#line 109 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 5396, languade.Getkey("Nofitication_Success"), 5396, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Nofitication_Success\"/>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5487, "\"", 5528, 1);
#nullable restore
#line 110 "D:\Project\v_3\ManagerMusic\ProjectMusic_BackEnd\ManagerMusic\Views\Notification\PageNotificationUer.cshtml"
WriteAttributeValue("", 5495, languade.Getkey("RemoveSuccess"), 5495, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"RemoveSuccess\"/>");
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
