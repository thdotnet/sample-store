#pragma checksum "C:\Users\thiag\source\repos\WebApplication2\WebApplication2\Views\Carrinho\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "798d1e3d459b0fbedcdc2f18f003bc24a84df957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Lista), @"mvc.1.0.view", @"/Views/Carrinho/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinho/Lista.cshtml", typeof(AspNetCore.Views_Carrinho_Lista))]
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
#line 1 "C:\Users\thiag\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\thiag\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798d1e3d459b0fbedcdc2f18f003bc24a84df957", @"/Views/Carrinho/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Core.Models.Carrinho>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 50, true);
            WriteLiteral("\r\n<span>\r\n    <span class=\"col-md-3\">Total Items: ");
            EndContext();
            BeginContext(96, 32, false);
#line 4 "C:\Users\thiag\source\repos\WebApplication2\WebApplication2\Views\Carrinho\Lista.cshtml"
                                   Write(Model.Items.Sum(x=>x.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(128, 41, true);
            WriteLiteral(" </span>\r\n    <span class=\"col-md-9\">R$: ");
            EndContext();
            BeginContext(170, 51, false);
#line 5 "C:\Users\thiag\source\repos\WebApplication2\WebApplication2\Views\Carrinho\Lista.cshtml"
                          Write(Model.Items.Sum(x=> x.Produto.Preco * x.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(221, 17, true);
            WriteLiteral(" </span>\r\n</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Core.Models.Carrinho> Html { get; private set; }
    }
}
#pragma warning restore 1591
