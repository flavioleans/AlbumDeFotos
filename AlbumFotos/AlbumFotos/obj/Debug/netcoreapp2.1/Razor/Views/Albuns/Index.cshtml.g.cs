#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5bf883d6ca6e9b2d052538b86b83ed83acd406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albuns_Index), @"mvc.1.0.view", @"/Views/Albuns/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albuns/Index.cshtml", typeof(AspNetCore.Views_Albuns_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f5bf883d6ca6e9b2d052538b86b83ed83acd406", @"/Views/Albuns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac944a79a00de3bd3cee4c30cb2ebd97da91e27", @"/Views/_ViewImports.cshtml")]
    public class Views_Albuns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlbumFotos.Models.Album>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn-small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small blue darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small orange darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
  
    ViewData["Title"] = "Albuns";

#line default
#line hidden
            BeginContext(89, 85, true);
            WriteLiteral("\r\n<div class=\"listaDestinos\">\r\n    <div class=\"container\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(174, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46773392391d4186b473db23227d2c7e", async() => {
                BeginContext(240, 10, true);
                WriteLiteral("Novo Album");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(254, 181, true);
            WriteLiteral("\r\n        </p>\r\n        <table class=\"table striped highlight hover responsive-table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(436, 43, false);
#line 16 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(479, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(559, 46, false);
#line 19 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(605, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(685, 39, false);
#line 22 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Fim));

#line default
#line hidden
            EndContext();
            BeginContext(724, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 28 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(915, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1000, 42, false);
#line 32 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1134, 45, false);
#line 35 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1271, 38, false);
#line 38 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Fim));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1400, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d37f8fce7672442c800b763437ecad56", async() => {
                BeginContext(1482, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                                                   WriteLiteral(item.AlbumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1495, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1527, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05b28e17fa144461bbbccec70441427c", async() => {
                BeginContext(1614, 5, true);
                WriteLiteral("Fotos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                                                      WriteLiteral(item.AlbumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 100, true);
            WriteLiteral(" |\r\n                            <a class=\"btn-small red darken-4 modal-trigger\" data-target=\"modal1\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1723, "\"", 1755, 3);
            WriteAttributeValue("", 1733, "Excluir(", 1733, 8, true);
#line 43 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
WriteAttributeValue("", 1741, item.AlbumId, 1741, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1754, ")", 1754, 1, true);
            EndWriteAttribute();
            BeginContext(1756, 72, true);
            WriteLiteral(">Excluir</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 46 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\AlbumDeFotos_0059\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1847, 930, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>



<!-- Modal Structure -->
<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar Exclusão</h4>
        <p>Deseja prosseguir com a exclusão?</p>
    </div>
    <div class=""modal-footer"">
        <a class=""modal-close waves-effect waves-green btn-flat btnConfirmar"">Sim</a>
        <a class=""modal-close waves-effect waves-green btn-flat"">Não</a>
    </div>
</div>

<script>
    function Excluir(AlbumId) {
        $("".modal"").modal();
        $("".btnConfirmar"").on('click', function () {
            $.ajax({
                url: '/Albuns/Delete',
                type: 'POST',
                data: { AlbumId: AlbumId },
                success: function () {
                    location.reload();
                    $("".modal"").modal('close');
                }
            })
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlbumFotos.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591