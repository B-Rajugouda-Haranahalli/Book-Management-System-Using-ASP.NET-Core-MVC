#pragma checksum "D:\technovice\Projects\BookManagement-Using-ASP.NET-CORE-Web-App\BookManagement-Using-ASP.NET-CORE-Web-App\Views\Book\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "492826de5600e0ceba41b798ae5edf46a2240509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_About), @"mvc.1.0.view", @"/Views/Book/About.cshtml")]
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
#line 1 "D:\technovice\Projects\BookManagement-Using-ASP.NET-CORE-Web-App\BookManagement-Using-ASP.NET-CORE-Web-App\Views\_ViewImports.cshtml"
using BookManagement_Using_ASP.NET_CORE_Web_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\technovice\Projects\BookManagement-Using-ASP.NET-CORE-Web-App\BookManagement-Using-ASP.NET-CORE-Web-App\Views\_ViewImports.cshtml"
using BookManagement_Using_ASP.NET_CORE_Web_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"492826de5600e0ceba41b798ae5edf46a2240509", @"/Views/Book/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9c285266ccf4cc69a78fd85683d89109c9372c", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\technovice\Projects\BookManagement-Using-ASP.NET-CORE-Web-App\BookManagement-Using-ASP.NET-CORE-Web-App\Views\Book\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .text-shadow {
        text-shadow: 2px 2px 4px rgb(0 0 0 / 0.50);
    }
</style>

<div class=""container p-3"">

<h1 class=""mt-3 text-shadow"">About This Application</h1>
<br />

    <div class=""card border-info mb-3"" style=""max-width: 80%;"">
        <div class=""card-header text-warning"">
            <h3>
            This Web Application is made using &nbsp; <span> ASP.NET Core MVC</span>
            </h3>
        </div>
        <div class=""card-body"">
            <h5 class=""card-title text-info"">Some Key Features of This Application </h5>
            <p class=""card-text"">
                <ul class=""text-info"">
                    <li>Server &nbsp;and &nbsp;Client &nbsp;Validation</li>
                    <li>Responsive &nbsp;website &nbsp;which &nbsp;Makes &nbsp;Device &nbsp;Compatibility</li>
                    <li>Custom Routing</li>
                </ul>
            </p>
        </div>
    </div>

</div>

");
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