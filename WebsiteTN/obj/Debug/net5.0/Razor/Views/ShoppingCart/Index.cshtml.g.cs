#pragma checksum "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a910c7215d6367035b3934c4df8ebe21db721d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "D:\WebsiteTN\WebsiteTN\Views\_ViewImports.cshtml"
using WebsiteTN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebsiteTN\WebsiteTN\Views\_ViewImports.cshtml"
using WebsiteTN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a910c7215d6367035b3934c4df8ebe21db721d", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea9efaef97dd87a44c64475cdd6391fda8e4af5", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebsiteTN.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientassets/cartjs/indexCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Xem giỏ hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"main-content\">\r\n    <div class=\"cart-area section-space-y-axis-100\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n");
#nullable restore
#line 11 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9a910c7215d6367035b3934c4df8ebe21db721d4777", async() => {
                WriteLiteral(@"
                            <div class=""table-content table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""product_remove"">Xóa</th>
                                            <th class=""product-thumbnail"">Ảnh</th>
                                            <th class=""cart-product-name"">Sản phẩm</th>
                                            <th class=""product-price"">Đơn giá</th>
                                            <th class=""product-quantity"">Số lượng</th>
                                            <th class=""product-subtotal"">Thành tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 27 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                         if (Model != null && Model.Count() > 0)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <tr>
                                                    <td class=""product_remove"">
                                                        <a href=""javascript:void(0)"">
                                                            <i class=""pe-7s-close"" title=""Remove""></i>
                                                        </a>
                                                    </td>
                                                    <td class=""product-thumbnail"">
                                                        <a href=""javascript:void(0)"">
                                                            <img");
                BeginWriteAttribute("src", " src=\"", 2271, "\"", 2309, 2);
                WriteAttributeValue("", 2277, "/images/post/", 2277, 13, true);
#nullable restore
#line 39 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2290, item.product.Thumb, 2290, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2310, "\"", 2335, 1);
#nullable restore
#line 39 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2316, item.product.Title, 2316, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        </a>\r\n                                                    </td>\r\n                                                    <td class=\"product-name\"><a href=\"javascript:void(0)\">");
#nullable restore
#line 42 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                                                                                     Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                    <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 43 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                                                                              Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VNĐ</span></td>
                                                    <td class=""quantity"">
                                                        <div class=""cart-plus-minus"">
                                                            <input data-id=""");
#nullable restore
#line 46 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                                                       Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-unitprice=\"");
#nullable restore
#line 46 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                                                                                                Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"cart-plus-minus-box\"");
                BeginWriteAttribute("value", " value=\"", 3089, "\"", 3111, 1);
#nullable restore
#line 46 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3097, item.quantity, 3097, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" type=\"number\">\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td class=\"product-subtotal\"><span class=\"amount\">");
#nullable restore
#line 49 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                                                                                 Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 51 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-5 ml-auto"">
                                    <div class=""cart-page-total"">
                                        <h2>Tổng tiền</h2>
                                        <ul>
                                            <li>Thành tiền <span>");
#nullable restore
#line 61 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                                                            Write(Model.Sum(x=>x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></li>
                                            <li>Thanh toán<span>$118.60</span></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Chưa có hàng hóa trong giỏ hàng.Bạn hãy tích cực mua sắm đi nào</p>\r\n");
#nullable restore
#line 72 "D:\WebsiteTN\WebsiteTN\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9a910c7215d6367035b3934c4df8ebe21db721d14130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebsiteTN.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
