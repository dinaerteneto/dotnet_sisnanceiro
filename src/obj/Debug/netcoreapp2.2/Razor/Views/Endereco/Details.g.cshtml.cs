#pragma checksum "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d3166cce075c3c7e1be5473a9cf732f7a9d187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Endereco_Details), @"mvc.1.0.view", @"/Views/Endereco/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Endereco/Details.cshtml", typeof(AspNetCore.Views_Endereco_Details))]
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
#line 1 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\_ViewImports.cshtml"
using src;

#line default
#line hidden
#line 2 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\_ViewImports.cshtml"
using src.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d3166cce075c3c7e1be5473a9cf732f7a9d187", @"/Views/Endereco/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6abdd9730bf1b4f2a327dc2e2bda1bd41f892c", @"/Views/_ViewImports.cshtml")]
    public class Views_Endereco_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<src.Models.Endereco>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Endereco</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(205, 40, false);
#line 14 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(245, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(309, 36, false);
#line 17 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(345, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(408, 39, false);
#line 20 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(447, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(511, 35, false);
#line 23 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(546, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(609, 42, false);
#line 26 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(651, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(715, 38, false);
#line 29 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(753, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(816, 47, false);
#line 32 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(863, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(927, 43, false);
#line 35 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(970, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1033, 46, false);
#line 38 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1143, 42, false);
#line 41 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1248, 42, false);
#line 44 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1354, 38, false);
#line 47 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1455, 42, false);
#line 50 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1561, 38, false);
#line 53 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1662, 38, false);
#line 56 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1764, 34, false);
#line 59 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
       Write(Html.DisplayFor(model => model.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1845, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d3166cce075c3c7e1be5473a9cf732f7a9d18711439", async() => {
                BeginContext(1891, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\929001318\Documents\pessoais\estudo\dotnet\dotnet_sisnanceiro\src\Views\Endereco\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1899, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1907, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d3166cce075c3c7e1be5473a9cf732f7a9d18713786", async() => {
                BeginContext(1929, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1945, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<src.Models.Endereco> Html { get; private set; }
    }
}
#pragma warning restore 1591
