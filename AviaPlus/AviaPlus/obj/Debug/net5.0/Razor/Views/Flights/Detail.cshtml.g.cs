#pragma checksum "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8400733984abb0901327827818a4255c3ca9d2b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_Detail), @"mvc.1.0.view", @"/Views/Flights/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8400733984abb0901327827818a4255c3ca9d2b3", @"/Views/Flights/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2705eaa6d8887b8c4c89056a7c9b84bf19b1963b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Flights_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flight>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h5><b>Flight Detail</b></h5>\r\n<p> </p>\r\n<p><h7><b>Flight Number:</b> ");
#nullable restore
#line 4 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                        Write(Model.FlightNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Departure Time:</b> ");
#nullable restore
#line 5 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                         Write(Model.DepartureTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Arrival Time:</b> ");
#nullable restore
#line 6 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                       Write(Model.ArrivalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Departure:</b> ");
#nullable restore
#line 7 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                    Write(Model.Departure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Gate:</b> ");
#nullable restore
#line 8 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
               Write(Model.Gate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Carousel:</b> ");
#nullable restore
#line 9 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                   Write(Model.Carousel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p><h7><b>Price ($):</b> ");
#nullable restore
#line 10 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                    Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7></p>\r\n<p>\r\n    <h7>\r\n        <b>Status:</b> ");
#nullable restore
#line 13 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
                        if (Model.IsCancelled)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>Cancelled</a>\r\n");
#nullable restore
#line 16 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>Landed</a>\r\n");
#nullable restore
#line 20 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Flights\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h7>\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8400733984abb0901327827818a4255c3ca9d2b36891", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flight> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
