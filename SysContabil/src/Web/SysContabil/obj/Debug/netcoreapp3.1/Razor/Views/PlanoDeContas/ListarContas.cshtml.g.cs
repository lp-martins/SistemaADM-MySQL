#pragma checksum "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f65eda6e348328785e83f96c836785ff8b1508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlanoDeContas_ListarContas), @"mvc.1.0.view", @"/Views/PlanoDeContas/ListarContas.cshtml")]
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
#line 1 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\_ViewImports.cshtml"
using SysContabil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\_ViewImports.cshtml"
using SysContabil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f65eda6e348328785e83f96c836785ff8b1508", @"/Views/PlanoDeContas/ListarContas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9433e5a7a3137eb8e6fad2d471b593785c83e9a8", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoDeContas_ListarContas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SysContabil.Models.PlanoDeContasViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
  
    ViewData["Title"] = "ListarContas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Editar contas</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f65eda6e348328785e83f96c836785ff8b15084182", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroDaConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeDaConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroDaConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeDaConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div class=\"btn btn-outline-success\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
               Write(Html.ActionLink("Alterar", "Alterar", new { id = item.NumeroDaConta }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                 |||\r\n                <div class=\"btn btn-outline-danger\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
               Write(Html.ActionLink("Excluir", "Excluir", new { id = item.NumeroDaConta }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\MARTINS\Desktop\SistemaADM-MySQL\SysContabil\src\Web\SysContabil\Views\PlanoDeContas\ListarContas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SysContabil.Models.PlanoDeContasViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
