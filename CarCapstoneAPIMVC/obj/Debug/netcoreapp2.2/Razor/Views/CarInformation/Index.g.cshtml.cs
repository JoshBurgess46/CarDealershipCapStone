#pragma checksum "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f531b7fc59d87ad6e37609667e80c1ce557db2e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarInformation_Index), @"mvc.1.0.view", @"/Views/CarInformation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarInformation/Index.cshtml", typeof(AspNetCore.Views_CarInformation_Index))]
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
#line 1 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\_ViewImports.cshtml"
using CarCapstoneAPIMVC;

#line default
#line hidden
#line 2 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\_ViewImports.cshtml"
using CarCapstoneAPIMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f531b7fc59d87ad6e37609667e80c1ce557db2e3", @"/Views/CarInformation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559e4361960d3264bf5cd33c0e68e23c8ff4b7f0", @"/Views/_ViewImports.cshtml")]
    public class Views_CarInformation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarCapstoneAPIMVC.Models.CarInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f531b7fc59d87ad6e37609667e80c1ce557db2e33846", async() => {
                BeginContext(149, 9, true);
                WriteLiteral("Add a car");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 38, false);
#line 16 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(293, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(349, 40, false);
#line 19 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.make));

#line default
#line hidden
            EndContext();
            BeginContext(389, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(445, 41, false);
#line 22 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.model));

#line default
#line hidden
            EndContext();
            BeginContext(486, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(542, 40, false);
#line 25 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.year));

#line default
#line hidden
            EndContext();
            BeginContext(582, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(638, 41, false);
#line 28 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.color));

#line default
#line hidden
            EndContext();
            BeginContext(679, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(797, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(846, 37, false);
#line 37 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(939, 39, false);
#line 40 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.make));

#line default
#line hidden
            EndContext();
            BeginContext(978, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1034, 40, false);
#line 43 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.model));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1130, 39, false);
#line 46 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.year));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 40, false);
#line 49 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.color));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1321, 54, false);
#line 52 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.ActionLink("Edit", "EditCar", new { id=item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1396, 58, false);
#line 53 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteCar", new { id=item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1493, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarCapstoneAPIMVC.Models.CarInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591