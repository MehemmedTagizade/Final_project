#pragma checksum "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47327795313283bb6d9ce9c8f04a2560e8b8ac71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_OurTeam_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/OurTeam/Detail.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.AcoountViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47327795313283bb6d9ce9c8f04a2560e8b8ac71", @"/Areas/Manage/Views/OurTeam/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb8b4c7200985778243497b5ad00419e3dc4ae6", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_OurTeam_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OurTeam>
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
#line 2 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <ul class=\"list-group list-group-flush\">\r\n        <li class=\"list-group-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47327795313283bb6d9ce9c8f04a2560e8b8ac715248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 291, "~/images/", 291, 9, true);
#nullable restore
#line 10 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
AddHtmlAttributeValue("", 300, Model.Image, 300, 12, false);

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
#line 12 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Name: ");
#nullable restore
#line 13 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Profession: ");
#nullable restore
#line 14 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                           Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Desc: ");
#nullable restore
#line 15 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                     Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">FaceBookUrl: ");
#nullable restore
#line 16 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                            Write(Model.FaceBookUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Twtter: ");
#nullable restore
#line 17 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                       Write(Model.TwitterUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Be: ");
#nullable restore
#line 18 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                   Write(Model.BeUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Url: ");
#nullable restore
#line 19 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                    Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Pinterests: ");
#nullable restore
#line 20 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Areas\Manage\Views\OurTeam\Detail.cshtml"
                                           Write(Model.PinterestUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n    </ul>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47327795313283bb6d9ce9c8f04a2560e8b8ac7110027", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OurTeam> Html { get; private set; }
    }
}
#pragma warning restore 1591
