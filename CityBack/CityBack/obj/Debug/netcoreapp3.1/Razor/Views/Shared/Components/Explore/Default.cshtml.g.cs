#pragma checksum "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Shared\Components\Explore\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c53bfd8dae0337b524a33283177af1d89f7ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Explore_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Explore/Default.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\_ViewImports.cshtml"
using CityBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\_ViewImports.cshtml"
using CityBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c53bfd8dae0337b524a33283177af1d89f7ae1", @"/Views/Shared/Components/Explore/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03726fc993f660a72688bd5b67a28bb722955cbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Explore_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Explore>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-12 col-md-12 col-sm-12 col-12\">\r\n    <div class=\"title text-center mt-5\">\r\n        <span>");
#nullable restore
#line 5 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Shared\Components\Explore\Default.cshtml"
         Write(Model.HeadTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <h1>");
#nullable restore
#line 6 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Shared\Components\Explore\Default.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Explore> Html { get; private set; }
    }
}
#pragma warning restore 1591