#pragma checksum "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a15a21d4ecd814356cb569a631bc8e327c266e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a15a21d4ecd814356cb569a631bc8e327c266e", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Produto -> visualizar</h1>\r\n:)\r\n\r\nRazor:\r\n");
#nullable restore
#line 8 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
  
    string nome = "Vicente Nascimento";


#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>Produto</h2>\r\n\r\n<b>Codigo: </b> ");
#nullable restore
#line 16 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n<b>Nome: </b> ");
#nullable restore
#line 17 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<b>Descricao </b> ");
#nullable restore
#line 19 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n<b>Valor</b> ");
#nullable restore
#line 21 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Valor.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n\r\n<br />\r\nTodos os direitos reservados &copy; ");
#nullable restore
#line 25 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591