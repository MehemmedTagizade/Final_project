#pragma checksum "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\Shared\_ProductSearchPartialcshtml.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cbbdd5f6ce9b629a16a5f8c403ab04b9b8c907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSearchPartialcshtml), @"mvc.1.0.view", @"/Views/Shared/_ProductSearchPartialcshtml.cshtml")]
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
#line 1 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.Aboutt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.AcoountViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.Contacs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\_ViewImports.cshtml"
using FinalProject_DarkLook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cbbdd5f6ce9b629a16a5f8c403ab04b9b8c907", @"/Views/Shared/_ProductSearchPartialcshtml.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7836b6fccae1d5db19498750ff713f75019fcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSearchPartialcshtml : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WatchCard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\Shared\_ProductSearchPartialcshtml.cshtml"
 foreach (WatchCard product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"list-group-item\">");
#nullable restore
#line 4 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\Shared\_ProductSearchPartialcshtml.cshtml"
                           Write(product.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 5 "C:\Users\Mahammad Tagizada\Desktop\Final_project\FinalProject_DarkLook\Views\Shared\_ProductSearchPartialcshtml.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WatchCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
