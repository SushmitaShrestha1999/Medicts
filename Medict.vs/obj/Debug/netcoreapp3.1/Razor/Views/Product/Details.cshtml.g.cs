#pragma checksum "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c6c7fce1c4a1cdce949e377b1d6b92686e01b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\_ViewImports.cshtml"
using Medict;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\_ViewImports.cshtml"
using Medict.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6c7fce1c4a1cdce949e377b1d6b92686e01b61", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97ef5063ab72ffba2cf865e24d89459e428c2d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medict.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of Product</h1>\r\n\r\n<table class=\"table table-hover table-bordered\">\r\n    <thead>\r\n        <tr scope=\"col\">\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 55 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 59 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ShotrtDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 62 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 65 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 69 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 73 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 76 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\"></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 82 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-light\">\r\n                <td scope=\"row\">\r\n\r\n                    ");
#nullable restore
#line 87 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 91 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShotrtDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 94 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 97 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 101 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 105 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3955, "\"", 3985, 1);
#nullable restore
#line 109 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
WriteAttributeValue("", 3961, Url.Content(item.Image), 3961, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:60px;height:60px;\">\r\n                    ");
#nullable restore
#line 110 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6c7fce1c4a1cdce949e377b1d6b92686e01b619647", async() => {
                WriteLiteral("Add to cart");
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
#nullable restore
#line 113 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 118 "C:\Users\user\Downloads\Medict.vs (3)\Medict.vs (2)\Medict.vs\Views\Product\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medict.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591