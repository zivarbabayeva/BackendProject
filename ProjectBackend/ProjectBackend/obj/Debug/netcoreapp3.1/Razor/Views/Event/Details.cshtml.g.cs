#pragma checksum "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5bdf19d00db25ed113dde9e48fdafaafca693db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Details), @"mvc.1.0.view", @"/Views/Event/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bdf19d00db25ed113dde9e48fdafaafca693db", @"/Views/Event/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89a7216f342ea5bcfe877e26f562fcdefa4b965a", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventdetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>event / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Event Details Start -->
<div class=""event-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""event-details"">
                    <div class=""event-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e5bdf19d00db25ed113dde9e48fdafaafca693db5954", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 923, "~/img/event/", 923, 12, true);
#nullable restore
#line 31 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
AddHtmlAttributeValue("", 935, Model.Event.ImageUrl, 935, 21, false);

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
            WriteLiteral("\r\n                        <div class=\"event-date\">\r\n                            <h3>");
#nullable restore
#line 33 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                           Write(Model.Event.Date.ToString("dd MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"event-details-content\">\r\n                        <h2>");
#nullable restore
#line 37 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                       Write(Model.Event.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <ul>\r\n                            <li><span>time : </span>");
#nullable restore
#line 39 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                                               Write(Model.Event.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 39 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                                                                        Write(Model.Event.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><span>venue : </span>");
#nullable restore
#line 40 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                                                Write(Model.Event.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <p>");
#nullable restore
#line 42 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p>");
#nullable restore
#line 43 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                      Write(Model.SubDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 44 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                      Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"speakers-area fix\">\r\n                            <h4>speakers</h4>\r\n");
#nullable restore
#line 47 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                             foreach (EventSpeakers es in Model.EventSpeakers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-speaker\">\r\n                                    <div class=\"speaker-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e5bdf19d00db25ed113dde9e48fdafaafca693db10882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2058, "~/img/event/", 2058, 12, true);
#nullable restore
#line 51 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
AddHtmlAttributeValue("", 2070, es.Speakers.SpeakerImageUrl, 2070, 28, false);

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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"speaker-name\">\r\n                                        <h5>");
#nullable restore
#line 54 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                                       Write(es.Speakers.SpeakerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p>");
#nullable restore
#line 55 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
                                      Write(es.Speakers.SpeakerQualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 58 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    ");
#nullable restore
#line 63 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
               Write(await Component.InvokeAsync("Sidebar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bdf19d00db25ed113dde9e48fdafaafca693db14278", async() => {
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    ");
#nullable restore
#line 79 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
               Write(await Component.InvokeAsync("Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n<!-- Event Details End -->\r\n<!-- Subscribe Start -->\r\n");
#nullable restore
#line 85 "C:\Users\LEGION\Desktop\BackendProject\ProjectBackend\ProjectBackend\Views\Event\Details.cshtml"
Write(await Component.InvokeAsync("Subscribe"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Subscribe End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventdetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
