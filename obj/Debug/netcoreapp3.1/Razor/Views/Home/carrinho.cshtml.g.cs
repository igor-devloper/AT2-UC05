#pragma checksum "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\Home\carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7339b8d3cb0407d79a6df1ac185c875bd9b218d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_carrinho), @"mvc.1.0.view", @"/Views/Home/carrinho.cshtml")]
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
#line 1 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\_ViewImports.cshtml"
using AT2_UC05;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\_ViewImports.cshtml"
using AT2_UC05.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7339b8d3cb0407d79a6df1ac185c875bd9b218d9", @"/Views/Home/carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60447f0390e05abaa242c0c3ec816836b3e5b1d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemPedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n  <h3>Itens do seu Carrinho</h3>\r\n  <table class=\"table\">\r\n\r\n    <tr>  \r\n      <th>Produto</th>\r\n      <th>Valor</th>\r\n      <th>Quantidade</th>\r\n    </tr>\r\n      \r\n  </table>\r\n");
#nullable restore
#line 13 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\Home\carrinho.cshtml"
   foreach (var itens in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 15 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\Home\carrinho.cshtml"
      Write(itens.descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 16 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\Home\carrinho.cshtml"
      Write(itens.quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\Home\carrinho.cshtml"
      Write(itens.valor_unitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\Cleoberto\Desktop\Projetos\AT2-UC05\Views\Home\carrinho.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
