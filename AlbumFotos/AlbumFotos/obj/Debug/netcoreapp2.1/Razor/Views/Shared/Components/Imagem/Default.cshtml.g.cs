#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Shared\Components\Imagem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1592ed91b9e0439ffbaa13888e8f51ba80e1f7ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Imagem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Imagem/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Imagem/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Imagem_Default))]
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
#line 1 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\_ViewImports.cshtml"
using AlbumFotos;

#line default
#line hidden
#line 2 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\_ViewImports.cshtml"
using AlbumFotos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1592ed91b9e0439ffbaa13888e8f51ba80e1f7ad", @"/Views/Shared/Components/Imagem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac944a79a00de3bd3cee4c30cb2ebd97da91e27", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Imagem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlbumFotos.Models.Imagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 4 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Shared\Components\Imagem\Default.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
            BeginContext(105, 38, true);
            WriteLiteral("    <div class=\"col s3\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 143, "\"", 172, 1);
#line 7 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Shared\Components\Imagem\Default.cshtml"
WriteAttributeValue("", 149, Url.Content(item.Link), 149, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(173, 63, true);
            WriteLiteral(" width=\"350\" height=\"350\" alt=\"Alternate Text\" />\r\n    </div>\r\n");
            EndContext();
#line 9 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Shared\Components\Imagem\Default.cshtml"
	}

#line default
#line hidden
            BeginContext(240, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlbumFotos.Models.Imagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
