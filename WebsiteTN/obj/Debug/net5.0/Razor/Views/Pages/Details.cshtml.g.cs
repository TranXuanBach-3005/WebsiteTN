#pragma checksum "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18ce0578bc6e11c1872daa78baa84b1a28b7c3f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Details), @"mvc.1.0.view", @"/Views/Pages/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ce0578bc6e11c1872daa78baa84b1a28b7c3f7", @"/Views/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea9efaef97dd87a44c64475cdd6391fda8e4af5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteTN.Models.Page>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/page/{Model.Alias}";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 14 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
                                                  Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <ul>\r\n                            <li>\r\n                                <a href=\"/\">Trang ch??? <i class=\"pe-7s-angle-right\"></i></a>\r\n                            </li>\r\n                            <li>");
#nullable restore
#line 19 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
                           Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18ce0578bc6e11c1872daa78baa84b1a28b7c3f75141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1243, "~/images/page/", 1243, 14, true);
#nullable restore
#line 32 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
AddHtmlAttributeValue("", 1257, Model.Thumb, 1257, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
AddHtmlAttributeValue("", 1276, Model.Title, 1276, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 37 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
                                                                                     Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    <li>
                                        <span class=""comments me-3"">
                                            <a href=""javascript:void(0)"">2 Comments</a>
                                        </span>
                                        <span class=""link-share"">
                                            <a href=""javascript:void(0)"">Share</a>
                                        </span>
                                    </li>
                                </ul>
                            </div>
                            <h5 class=""title mb-4"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 2272, "\"", 2283, 1);
#nullable restore
#line 49 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
WriteAttributeValue("", 2279, url, 2279, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
                                          Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            ");
#nullable restore
#line 51 "D:\WebsiteTN\WebsiteTN\Views\Pages\Details.cshtml"
                       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteTN.Models.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
