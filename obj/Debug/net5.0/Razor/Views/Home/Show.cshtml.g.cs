#pragma checksum "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd46193f446799c290d36df54c78eb32b4908622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
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
#line 1 "C:\Users\Xerxes\source\repos\Adresbook\Views\_ViewImports.cshtml"
using Adresbook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xerxes\source\repos\Adresbook\Views\_ViewImports.cshtml"
using Adresbook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd46193f446799c290d36df54c78eb32b4908622", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1156f8c90e7b345d4d2cdf4aa5b1481adf3978", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show</h1>\r\n");
#nullable restore
#line 6 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
 using (Html.BeginForm("Show", "Home", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <input name=\"search\" type=\"text\"><input id=\"Button1\" type=\"submit\" value=\"Найти по ФИО\">\r\n\r\n    </p>\r\n");
#nullable restore
#line 12 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table bborder=\"1\" cellpadding=\"1\" cellspacing=\"1\" style=\"width: 900px\">\r\n    <tr>\r\n        <td> ФИО </td>\r\n        <td> Эл-почта </td>\r\n        <td> Телефон </td>\r\n        <td> Дата рождения </td>\r\n        <td></td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> ");
#nullable restore
#line 24 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
            Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 25 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
            Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 26 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
            Write(user.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 27 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
            Write(user.Birhday);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Xerxes\source\repos\Adresbook\Views\Home\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n        </html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591