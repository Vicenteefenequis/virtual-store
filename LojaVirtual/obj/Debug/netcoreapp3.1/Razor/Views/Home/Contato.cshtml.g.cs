#pragma checksum "C:\Users\vicen\Desktop\LojaVirtual\virtual-store\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30aaf216ea190fa349b631b3196180948b960bc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30aaf216ea190fa349b631b3196180948b960bc", @"/Views/Home/Contato.cshtml")]
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
                    <a href=""#"" data-html=""code_payment"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_payment"">

                    <article class=""card"">
                        <div class=""card-body p-5"">
                            <p class=""alert alert-success"">Mensagem de sucesso!</p>

                            <form role=""form"">
                                <div class=""form-group"">
                                    <label for=""username"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-con");
            WriteLiteral("trol\" name=\"username\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2113, "\"", 2127, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", "\r\n                                               required=\"", 2128, "\"", 2187, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""form-group"">
                                    <label for=""cardNumber"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""cardNumber""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2849, "\"", 2863, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" style=""width:100%""></textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div> <!-- row.// -->
                                <button class=""subscribe btn btn-primary btn-block"" type=""button""> Enviar </button>
                            </form>
                        </div> <!-- card-body.// -->
                    ");
            WriteLiteral("</article> <!-- card.// -->\r\n\r\n                </div> <!-- code-wrap.// -->\r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>");
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
