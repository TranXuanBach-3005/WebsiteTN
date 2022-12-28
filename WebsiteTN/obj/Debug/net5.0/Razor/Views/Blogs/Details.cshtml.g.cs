#pragma checksum "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66124e5d45d216ab8403f934ca812a834d5b1e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Details), @"mvc.1.0.view", @"/Views/Blogs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66124e5d45d216ab8403f934ca812a834d5b1e9", @"/Views/Blogs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea9efaef97dd87a44c64475cdd6391fda8e4af5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteTN.Models.Post>
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
#line 2 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/tin-tuc/{Model.Alias}-{Model.PostId}.html";
    List<Post> postRelated = ViewBag.PostRelated;
    Post postFocusesDetail = (Post)ViewBag.PostFocusesDetail;

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"main-content\">\r\n    <div class=\"breadcrumb-area breadcrumb-height\" data-bg-image=\"/images/post/");
#nullable restore
#line 10 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                                                                          Write(postFocusesDetail.Thumb);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Blog Layout</h2>
                        <ul>
                            <li>
                                <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>");
#nullable restore
#line 20 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                           Write(postFocusesDetail.Title);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c66124e5d45d216ab8403f934ca812a834d5b1e95287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1373, "~/images/post/", 1373, 14, true);
#nullable restore
#line 33 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
AddHtmlAttributeValue("", 1387, Model.Thumb, 1387, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
AddHtmlAttributeValue("", 1406, Model.Title, 1406, 12, false);

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
#line 38 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 2402, "\"", 2413, 1);
#nullable restore
#line 50 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
WriteAttributeValue("", 2409, url, 2409, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            ");
#nullable restore
#line 52 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"tag-wtih-social\">\r\n                                <div class=\"tag\">\r\n                                    <span class=\"title text-primary\">Tags:</span>\r\n                                    ");
#nullable restore
#line 56 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                               Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            WriteLiteral(@"
                            <div class=""feedback-area section-space-top-55"">
                                <h4 class=""heading mb-1"">Bài viết liên quan</h4>
                                <hr />
                                <div class=""widgets-area mb-9"">
                                    <div class=""widgets-item"">
                                        <div class=""swiper-container widgets-list-slider style-2 swiper-container-multirow swiper-container-initialized swiper-container-horizontal swiper-container-pointer-events"">
                                            <div class=""swiper-wrapper"" id=""swiper-wrapper-62104b1dfbb1d3188"" aria-live=""polite"" style=""width: 288px; transform: translate3d(0px, 0px, 0px);"">
");
#nullable restore
#line 132 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                                                 if (postRelated != null && postRelated.Count() > 0)
                                                {
                                                    foreach (var item in postRelated)
                                                    {
                                                        string _url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""swiper-slide"" role=""group"" aria-label=""3 / 3"" style=""margin-top: 25px; width: 263px; margin-right: 25px;"">
                                                            <div class=""product-list-item"">
                                                                <div class=""product-img img-zoom-effect"">
                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 9840, "\"", 9852, 1);
#nullable restore
#line 140 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
WriteAttributeValue("", 9847, _url, 9847, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c66124e5d45d216ab8403f934ca812a834d5b1e912118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9955, "~/images/post/", 9955, 14, true);
#nullable restore
#line 141 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
AddHtmlAttributeValue("", 9969, item.Thumb, 9969, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 141 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
AddHtmlAttributeValue("", 9987, item.Title, 9987, 11, false);

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
                                                                    </a>
                                                                </div>
                                                                <div class=""product-content"">
                                                                    <h5 class=""title mb-3"">
                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 10410, "\"", 10422, 1);
#nullable restore
#line 146 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
WriteAttributeValue("", 10417, _url, 10417, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 146 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                    </h5>
                                                                    <div class=""blog-meta text-manatee pb-1"">
                                                                        <ul>
                                                                            <li class=""date"">");
#nullable restore
#line 150 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                                                                                        Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                                        </ul>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
");
#nullable restore
#line 156 "D:\WebsiteTN\WebsiteTN\Views\Blogs\Details.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteTN.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
