#pragma checksum "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ada5ab1dc0864459f03a6abd9f368cd33be031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery;

#line default
#line hidden
#line 2 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ada5ab1dc0864459f03a6abd9f368cd33be031", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6531bab7f76b3f92639632e531729d736eaa2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrontPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(68, 31, true);
            WriteLiteral("\r\n<h2>New photos</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
     foreach (var item in Model.NewPhotos)
    {
        var routeData = new Dictionary<string, string>
        {
            { "id", item.Id.ToString() }
        };

#line default
#line hidden
            BeginContext(271, 79, true);
            WriteLiteral("        <li style=\"display:inline-block;margin:10px;border:1px solid darkgray\">");
            EndContext();
            BeginContext(350, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7bd52f576064174877861fb54f6c712", async() => {
                BeginContext(428, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 432, "\"", 454, 2);
                WriteAttributeValue("", 438, "/", 438, 1, true);
#line 15 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
WriteAttributeValue("", 439, item.Thumbnail, 439, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(455, 16, true);
                WriteLiteral(" height=\"200\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 15 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = routeData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(475, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(489, 42, true);
            WriteLiteral("</ul>\r\n\r\n<h2>Popular photos</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 22 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
     foreach (var item in Model.PopularPhotos)
    {
        var routeData = new Dictionary<string, string>
        {
            { "id", item.Id.ToString() }
        };

#line default
#line hidden
            BeginContext(707, 89, true);
            WriteLiteral("        <li style=\"display:inline-block;margin:10px;border:1px solid darkgray\">\r\n        ");
            EndContext();
            BeginContext(796, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3469af5539d74bb5a03bff376b19ffc0", async() => {
                BeginContext(874, 18, true);
                WriteLiteral("\r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 892, "\"", 914, 2);
                WriteAttributeValue("", 898, "/", 898, 1, true);
#line 30 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
WriteAttributeValue("", 899, item.Thumbnail, 899, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(915, 26, true);
                WriteLiteral(" height=\"200\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 29 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = routeData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(945, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 33 "C:\Users\opilane\Documents\GitHub\Iseseisevtoo\MediaGallery\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(969, 2338, true);
            WriteLiteral(@"</ul>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using ASP.NET Core MVC</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>How to</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">Add a Controller and View</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Secrets using Secret Manager.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2");
            WriteLiteral(@">Overview</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview of what is ASP.NET Core</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699321"">Client side development</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Run &amp; Deploy</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app<");
            WriteLiteral(@"/a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">Publish to Microsoft Azure Web Apps</a></li>
        </ul>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3327, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
