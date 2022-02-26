#pragma checksum "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bbe64d63b72fa62c2475795e894f32de95c18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(onlinebookstore.Views.Shared.Views_Shared_BookInfo), @"mvc.1.0.view", @"/Views/Shared/BookInfo.cshtml")]
namespace onlinebookstore.Views.Shared
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
#line 3 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/_ViewImports.cshtml"
using onlinebookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/_ViewImports.cshtml"
using onlinebookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/_ViewImports.cshtml"
using onlinebookstore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bbe64d63b72fa62c2475795e894f32de95c18d", @"/Views/Shared/BookInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140bc5a1545a2a7dd5b76d5135c6d6e45270e369", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-light p-1\">\n        <h4 style=\"color:darkblue; font-family:Impact, Haettenschweiler, \'Arial Narrow Bold\', sans-serif; letter-spacing:2px;font-size:38px;\">");
#nullable restore
#line 9 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
                                                                                                                                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n        <span lang=\"badge bg-info\" style=\"float:right;\">\n            <span>ISBN: ");
#nullable restore
#line 12 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
                   Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <br />\n            <span style=\"color:lightcoral\">Price: $");
#nullable restore
#line 14 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
                                              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </span>\n    </div>\n    <ul>\n        <li>Author: ");
#nullable restore
#line 18 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
               Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Publisher: ");
#nullable restore
#line 19 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
                  Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Classification: ");
#nullable restore
#line 20 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
                       Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Page Count: ");
#nullable restore
#line 21 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
                   Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    </ul>\n    <br />\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bbe64d63b72fa62c2475795e894f32de95c18d7056", async() => {
                WriteLiteral("\n\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1bbe64d63b72fa62c2475795e894f32de95c18d7320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 27 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 842, "\"", 897, 1);
#nullable restore
#line 28 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Views/Shared/BookInfo.cshtml"
WriteAttributeValue("", 850, ViewContext.HttpContext.Request.PathAndQuery(), 850, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n\n        <span class=\"card-text\">\n            <button type=\"submit\" class=\"btn btn-success btn-sm float-end\">Add To Cart</button>\n        </span>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
