#pragma checksum "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56390d053d6a261c5f055b1e4c2bffe3cdc9ec24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Rafae\source\repos\App2\App2\Views\_ViewImports.cshtml"
using App2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafae\source\repos\App2\App2\Views\_ViewImports.cshtml"
using App2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56390d053d6a261c5f055b1e4c2bffe3cdc9ec24", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9a78a3c7bb84ed8c286d732f5953ebe1861c2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Amigo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var listaOrdenada = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Gerenciador de Aniversário</h1>\r\n</div>\r\n\r\n<h3>Aniversariante do dia ");
#nullable restore
#line 14 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
                     Write(DateTime.Today);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nome</th>\r\n            <th scope=\"col\">E-mail</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
         foreach (var amigo in listaOrdenada)
        {
            if (@amigo.Aniversario == DateTime.Today)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
                   Write(amigo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
                   Write(amigo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>
</table>
<br />
<br />
<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">E-mail</th>
            <th scope=""col"">Aniversário</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 50 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
         foreach (var amigo in listaOrdenada)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
               Write(amigo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
               Write(amigo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
               Write(amigo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
               Write(amigo.Aniversario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Rafae\source\repos\App2\App2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Amigo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
