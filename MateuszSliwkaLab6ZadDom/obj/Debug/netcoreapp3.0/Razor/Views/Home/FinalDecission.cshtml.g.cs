#pragma checksum "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e95fb49d4faf72b41903521adfa46a02d5dfcf14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FinalDecission), @"mvc.1.0.view", @"/Views/Home/FinalDecission.cshtml")]
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
#line 1 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\_ViewImports.cshtml"
using MateuszSliwkaLab6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\_ViewImports.cshtml"
using MateuszSliwkaLab6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95fb49d4faf72b41903521adfa46a02d5dfcf14", @"/Views/Home/FinalDecission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c534869da8734804308afe2043f46a5962bcb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FinalDecission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml"
  
    ViewData["Title"] = "Zamówienie";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95fb49d4faf72b41903521adfa46a02d5dfcf143518", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95fb49d4faf72b41903521adfa46a02d5dfcf144569", async() => {
                WriteLiteral("\r\n    <main role=\"main\">\r\n        <!--gorna sekcja z prezentacja wyboru -->\r\n        <section class=\"jumbotron text-center\">\r\n            <div class=\"container\">\r\n                <h1 class=\"jumbotron-heading\">Zamówienie ");
#nullable restore
#line 15 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml"
                                                    Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 16 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml"
                 if (Model == "potwierdzone")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p class=\"lead text-muted\">Dziękujemy, cieszymy się z naszej współpracy :)<br />Niedługo nasz konsultant do Państwa zadzwoni!</p>\r\n");
#nullable restore
#line 19 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p class=\"lead text-muted\">Bardzo nam przykro :( <br />Zapraszamy ponownie</p>\r\n");
#nullable restore
#line 23 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div class=\"text-center\">\r\n                <!--przycisk ew ponownego konfigurowania-->\r\n                <button class=\"btn btn-primary\">");
#nullable restore
#line 27 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\FinalDecission.cshtml"
                                           Write(Html.ActionLink("Konfiguruj ponownie", "Index", "Home", null, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n            </div>\r\n\r\n        </section>\r\n\r\n\r\n    </main>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
