#pragma checksum "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Shared\Components\Sidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef299495a03fad9b16c92f2b00a32de240b9ca53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Sidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
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
#line 1 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\_ViewImports.cshtml"
using ProjectBackend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\_ViewImports.cshtml"
using ProjectBackend.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef299495a03fad9b16c92f2b00a32de240b9ca53", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89a7216f342ea5bcfe877e26f562fcdefa4b965a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Sidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-4\">\r\n    <div class=\"blog-sidebar right\">\r\n        <div class=\"single-blog-widget mb-50\">\r\n            <h3>search</h3>\r\n            <div class=\"blog-search\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef299495a03fad9b16c92f2b00a32de240b9ca534286", async() => {
                WriteLiteral("\r\n                    <input type=\"search\" placeholder=\"Search...\" name=\"search\" />\r\n                    <button type=\"submit\">\r\n                        <span><i class=\"fa fa-search\"></i></span>\r\n                    </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""single-blog-widget mb-50"">
            <h3>categories</h3>
            <ul>
                <li><a href=""#"">CSS Engineering (10)</a></li>
                <li><a href=""#"">Political Science (12)</a></li>
                <li><a href=""#"">Micro Biology (08)</a></li>
                <li><a href=""#"">HTML5 &amp; CSS3 (15)</a></li>
                <li><a href=""#"">Web Design (20)</a></li>
                <li><a href=""#"">PHP (23)</a></li>
            </ul>
        </div>
        <div class=""single-blog-widget mb-50"">
            <div class=""single-blog-banner"">
                <a href=""blog-details.html"" id=""blog""><img src=""img/blog/blog-img.jpg"" alt=""blog""></a>
                <h2>best<br> eductaion<br> theme</h2>
            </div>
        </div>
        <div class=""single-blog-widget mb-50"">
            <h3>latest post</h3>
            <div class=""single-post mb-30"">
                <div class=""single-post-img"">
                    <a href");
            WriteLiteral(@"=""blog-details.html"">
                        <img src=""img/post/post1.jpg"" alt=""post"">
                        <div class=""blog-hover"">
                            <i class=""fa fa-link""></i>
                        </div>
                    </a>
                </div>
                <div class=""single-post-content"">
                    <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                    <p>By Alex  /  June 20, 2017</p>
                </div>
            </div>
            <div class=""single-post mb-30"">
                <div class=""single-post-img"">
                    <a href=""blog-details.html"">
                        <img src=""img/post/post2.jpg"" alt=""post"">
                        <div class=""blog-hover"">
                            <i class=""fa fa-link""></i>
                        </div>
                    </a>
                </div>
                <div class=""single-post-content"">
                    <h4><a href=""blog-details.html"">Adv");
            WriteLiteral(@"ance Web Design and Develop</a></h4>
                    <p>By Alex  /  June 20, 2017</p>
                </div>
            </div>
            <div class=""single-post"">
                <div class=""single-post-img"">
                    <a href=""blog-details.html"">
                        <img src=""img/post/post3.jpg"" alt=""post"">
                        <div class=""blog-hover"">
                            <i class=""fa fa-link""></i>
                        </div>
                    </a>
                </div>
                <div class=""single-post-content"">
                    <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                    <p>By Alex  /  June 20, 2017</p>
                </div>
            </div>
        </div>
        <div class=""single-blog-widget"">
            <h3>tags</h3>
            <div class=""single-tag"">
                <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                <a href=""blog-details.html"" class=""mr-1");
            WriteLiteral(@"0 mb-10"">education</a>
                <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                <a href=""blog-details.html"" class=""mr-10"">learning</a>
                <a href=""blog-details.html"" class=""mr-10"">university</a>
                <a href=""blog-details.html"">events</a>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
