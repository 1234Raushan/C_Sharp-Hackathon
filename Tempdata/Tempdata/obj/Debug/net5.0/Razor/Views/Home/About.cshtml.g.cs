#pragma checksum "C:\Users\rmanjhi\Documents\GitHub\C_Sharp-Hackathon\Tempdata\Tempdata\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175e80fc7ba9c38ee87380e0824113d133ee6d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\rmanjhi\Documents\GitHub\C_Sharp-Hackathon\Tempdata\Tempdata\Views\_ViewImports.cshtml"
using Tempdata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rmanjhi\Documents\GitHub\C_Sharp-Hackathon\Tempdata\Tempdata\Views\_ViewImports.cshtml"
using Tempdata.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"175e80fc7ba9c38ee87380e0824113d133ee6d7d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2057ea4265efa3757246932c33138cf746047100", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rmanjhi\Documents\GitHub\C_Sharp-Hackathon\Tempdata\Tempdata\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-left\">\r\n    <b>Name:</b> ");
#nullable restore
#line 6 "C:\Users\rmanjhi\Documents\GitHub\C_Sharp-Hackathon\Tempdata\Tempdata\Views\Home\About.cshtml"
            Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <b>Age:</b> ");
#nullable restore
#line 8 "C:\Users\rmanjhi\Documents\GitHub\C_Sharp-Hackathon\Tempdata\Tempdata\Views\Home\About.cshtml"
           Write(TempData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
