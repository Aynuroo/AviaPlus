#pragma checksum "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e384faf1ba3a6bc32bc6b0c920883a52b18447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cosmetics_Detail), @"mvc.1.0.view", @"/Views/Cosmetics/Detail.cshtml")]
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
#line 1 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\_ViewImports.cshtml"
using AviaPlus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\_ViewImports.cshtml"
using AviaPlus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\_ViewImports.cshtml"
using AviaPlus.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e384faf1ba3a6bc32bc6b0c920883a52b18447", @"/Views/Cosmetics/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2705eaa6d8887b8c4c89056a7c9b84bf19b1963b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cosmetics_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosmetic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h5><b>Cosmetic Detail</b></h5>\r\n<p> </p>\r\n<p>\r\n    <h7>\r\n        <b>Image:</b>\r\n\r\n        <div class=\"product-item\">\r\n            <div class=\"product-image\" style=\"display:flex;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27e384faf1ba3a6bc32bc6b0c920883a52b184475080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 237, "~/assets/img/", 237, 13, true);
#nullable restore
#line 10 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
AddHtmlAttributeValue("", 250, Model.Image, 250, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </h7>\r\n</p>\r\n<p><h7><b>Name:</b> ");
#nullable restore
#line 16 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Brand:</b> ");
#nullable restore
#line 17 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Volume:</b> ");
#nullable restore
#line 18 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                 Write(Model.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Packing:</b> ");
#nullable restore
#line 19 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                  Write(Model.Packing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Gender:</b> ");
#nullable restore
#line 20 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                 Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Makeup:</b> ");
#nullable restore
#line 21 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                 Write(Model.Makeup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Age:</b> ");
#nullable restore
#line 22 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
              Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Skin Type:</b> ");
#nullable restore
#line 23 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                    Write(Model.SkinType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Price ($):</b> ");
#nullable restore
#line 24 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                    Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Quantity:</b> ");
#nullable restore
#line 25 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                   Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p>\r\n    <h7>\r\n        <b>Status:</b> ");
#nullable restore
#line 28 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
                        if (Model.IsCancelled)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a>Exhausted</a>\r\n");
#nullable restore
#line 31 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a>Available</a>\r\n");
#nullable restore
#line 35 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Cosmetics\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h7>\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27e384faf1ba3a6bc32bc6b0c920883a52b1844710410", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosmetic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
