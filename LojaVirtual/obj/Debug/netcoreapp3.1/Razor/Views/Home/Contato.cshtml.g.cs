#pragma checksum "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "530bf880eac999305a1a232e30432faf37fbbc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530bf880eac999305a1a232e30432faf37fbbc55", @"/Views/Home/Contato.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Home\Contato.cshtml"
   
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -");
            WriteLiteral(@"->
            </aside>
            <aside class=""col-sm-6"">

                <h4 class=""subtitle-doc"">
                    # Contato
                </h4>
                <div>

                    <article class=""card"">
                        <div class=""card-body p-5"">
");
#nullable restore
#line 42 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Home\Contato.cshtml"
                             if(ViewData["MSG_SUCESSO"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"alert alert-success\">");
#nullable restore
#line 44 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Home\Contato.cshtml"
                                                      Write(ViewData["MSG_SUCESSO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Home\Contato.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <form role=""form"" method=""post"" action=""/Home/ContatoAcao"">
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" id=""nome"" class=""form-control"" name=""nome""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2186, "\"", 2200, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", "\r\n                                               required=\"", 2201, "\"", 2260, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> 
                                </div> 

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" id=""email"" class=""form-control"" name=""email""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2878, "\"", 2892, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div> 

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%""></textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div> 
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            </form>
                        </div> 
                    </article> 
                </div> 

      ");
            WriteLiteral("      </aside>\r\n        </div>\r\n    </div>\r\n</main>");
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
