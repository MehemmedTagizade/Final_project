#pragma checksum "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b163190b358865477571a93bfa22a88a9e42e25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_News_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/News/Detail.cshtml")]
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
#line 2 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b163190b358865477571a93bfa22a88a9e42e25", @"/Areas/Manage/Views/News/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4100eb47010da5aef12b8b986fe8580b53374d", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_News_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <ul class=\"list-group list-group-flush\">\r\n        <li class=\"list-group-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b163190b358865477571a93bfa22a88a9e42e254983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 290, "~/images/blog/", 290, 14, true);
#nullable restore
#line 11 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
AddHtmlAttributeValue("", 304, Model.Image, 304, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item\">Id: ");
#nullable restore
#line 13 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Title: ");
#nullable restore
#line 14 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Description: ");
#nullable restore
#line 15 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                            Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Day: ");
#nullable restore
#line 16 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                    Write(Model.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Month: ");
#nullable restore
#line 17 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                      Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Desc2: ");
#nullable restore
#line 18 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                      Write(Model.SingleDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">RedInfo: ");
#nullable restore
#line 19 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                        Write(Model.RedInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Info: ");
#nullable restore
#line 20 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\News\Detail.cshtml"
                                     Write(Model.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b163190b358865477571a93bfa22a88a9e42e259374", async() => {
                WriteLiteral("Go List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
