#pragma checksum "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GlobalSearchPartial), @"mvc.1.0.view", @"/Views/Shared/_GlobalSearchPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f", @"/Views/Shared/_GlobalSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2705eaa6d8887b8c4c89056a7c9b84bf19b1963b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__GlobalSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GlobalSearchVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:60px;object-fit:cover;margin-right:15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul id=""mySearchList"" style=""max-height: 1000px; overflow-y:auto; background-color:white; color:black"">
    <li class=""text-center"">-------------------------------------</li>
    <li class=""text-center"">List Flights</li>
    <li class=""text-center"">-------------------------------------</li>
");
#nullable restore
#line 6 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Flights.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Flight flight in Model.Flights)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px;justify-content:center\">\r\n                <a>");
#nullable restore
#line 11 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(flight.Departure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 13 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 18 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class =\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Tickets</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 22 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Tickets.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Ticket ticket in Model.Tickets)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px;justify-content:center\">\r\n                <a>");
#nullable restore
#line 27 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(ticket.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 29 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 34 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Perfumeries</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 38 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Perfumeries.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Perfumery perfumery in Model.Perfumeries)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f8523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1740, "~/assets/img/", 1740, 13, true);
#nullable restore
#line 43 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 1753, perfumery.Image, 1753, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 44 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(perfumery.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 46 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 51 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Cosmetics</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 55 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Cosmetics.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Cosmetic cosmetic in Model.Cosmetics)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f12000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2449, "~/assets/img/", 2449, 13, true);
#nullable restore
#line 60 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 2462, cosmetic.Image, 2462, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 61 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(cosmetic.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 63 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 68 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Spirits</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 72 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Spirits.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Spirit spirit in Model.Spirits)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f15466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3146, "~/assets/img/", 3146, 13, true);
#nullable restore
#line 77 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 3159, spirit.Image, 3159, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 78 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(spirit.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 80 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 85 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Gourmet Foods</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 89 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.GourmetFoods.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (GourmetFood gourmetFood in Model.GourmetFoods)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f18954", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3865, "~/assets/img/", 3865, 13, true);
#nullable restore
#line 94 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 3878, gourmetFood.Image, 3878, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 95 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(gourmetFood.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 97 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 102 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Foods</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 106 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Foods.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Food food in Model.Foods)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f22419", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4558, "~/assets/img/", 4558, 13, true);
#nullable restore
#line 111 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 4571, food.Image, 4571, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 112 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 114 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 119 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Beverages</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 123 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Beverages.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Beverage beverage in Model.Beverages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f25894", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5257, "~/assets/img/", 5257, 13, true);
#nullable restore
#line 128 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 5270, beverage.Image, 5270, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 129 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(beverage.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 131 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 136 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Jewelry</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 140 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Jewelries.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Jewelry jewelry in Model.Jewelries)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f29373", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5960, "~/assets/img/", 5960, 13, true);
#nullable restore
#line 145 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 5973, jewelry.Image, 5973, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 146 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(jewelry.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 148 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 153 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"text-center\">-------------------------------------</li>\r\n    <li class=\"text-center\">List Clothes</li>\r\n    <li class=\"text-center\">-------------------------------------</li>\r\n");
#nullable restore
#line 157 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Clothes.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Clothes clothes in Model.Clothes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"display:flex;align-items:center;padding:8px 3px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d57cb9aa2fb6c38a8ed021f943de7e9f58b2f32846", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6657, "~/assets/img/", 6657, 13, true);
#nullable restore
#line 162 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 6670, clothes.Image, 6670, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a>");
#nullable restore
#line 163 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
              Write(clothes.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 165 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger text-center\" style=\"font-weight:600;padding-top:30px\">Not Found</li>\r\n");
#nullable restore
#line 170 "C:\Users\USER\OneDrive\İş masası\AviaPlus\AviaPlus\AviaPlus\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GlobalSearchVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
