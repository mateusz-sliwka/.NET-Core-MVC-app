#pragma checksum "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d5693c72dd66d21247e136bcb57dd4167dc363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChooseOwner), @"mvc.1.0.view", @"/Views/Home/ChooseOwner.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d5693c72dd66d21247e136bcb57dd4167dc363", @"/Views/Home/ChooseOwner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c534869da8734804308afe2043f46a5962bcb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChooseOwner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
  
    ViewData["Title"] = "Dane zamawiającaego";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30d5693c72dd66d21247e136bcb57dd4167dc3633791", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30d5693c72dd66d21247e136bcb57dd4167dc3634826", async() => {
                WriteLiteral("\r\n    <main role=\"main\">\r\n        <!-- sekcja gorna wyswietlajaca tytul danej sekcji !-->\r\n        <section class=\"jumbotron text-center\">\r\n            <div class=\"container\">\r\n                <h1 class=\"jumbotron-heading\">Kupujesz Mercedes-Benz ");
#nullable restore
#line 14 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                                                                Write(CarOrder.Model.Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                                                                                      Write(TempData["currentCar"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                <p class=""lead text-muted"">Czas na podanie swoich danych osobowych.</p>

            </div>
        </section>

        <div class=""album py-5 bg-light"">
            <div class=""container"">
                <div class=""row"">
                    <!-- formularz tworzenia nowego clienta !-->
");
#nullable restore
#line 24 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                     using (Html.BeginForm("ShowBilling", "Home", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30d5693c72dd66d21247e136bcb57dd4167dc3636672", async() => {
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        <!-- Imie -->\r\n                        <div class=\"form-group\">\r\n                            <label>Imię</label>\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 33 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                           Write(Html.EditorFor(model => model.Firstname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"

                            </div>
                        </div>
                        <!-- Nazwisko -->
                        <div class=""form-group"">
                            <label>Nazwisko</label>
                            <div class=""col-md-10"">
                                ");
#nullable restore
#line 41 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                           Write(Html.EditorFor(model => model.Lastname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"

                            </div>
                        </div>
                        <!-- Email -->
                        <div class=""form-group"">
                            <label>Adres e-mail</label>
                            <div class=""col-md-10"">
                                ");
#nullable restore
#line 49 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </div>
                        </div>
                        <!-- Telefon -->
                        <div class=""form-group"">
                            <label>Telefon</label>
                            <div class=""col-md-10"">
                                ");
#nullable restore
#line 56 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                           Write(Html.EditorFor(model => model.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <!-- przycisk zatiwerdzenia !-->\r\n                        <input type=\"submit\" value=\"Wyślij\" class=\"btn btn-success\" />\r\n\r\n\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Mateusz\Desktop\MateuszSliwkaLab6ZadDom\MateuszSliwkaLab6ZadDom\Views\Home\ChooseOwner.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n        </div>\r\n        </div>\r\n\r\n    </main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
