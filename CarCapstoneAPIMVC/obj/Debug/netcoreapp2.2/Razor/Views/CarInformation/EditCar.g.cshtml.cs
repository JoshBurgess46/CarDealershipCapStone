#pragma checksum "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91659edc93240d995c1ad00114bf66d71914be6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarInformation_EditCar), @"mvc.1.0.view", @"/Views/CarInformation/EditCar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarInformation/EditCar.cshtml", typeof(AspNetCore.Views_CarInformation_EditCar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91659edc93240d995c1ad00114bf66d71914be6d", @"/Views/CarInformation/EditCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559e4361960d3264bf5cd33c0e68e23c8ff4b7f0", @"/Views/_ViewImports.cshtml")]
    public class Views_CarInformation_EditCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarCapstoneAPIMVC.Models.CarInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("EditCar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
  
    ViewData["Title"] = "EditCar";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 23, true);
            WriteLiteral("\r\n<h1>Edit Car</h1>\r\n\r\n");
            EndContext();
            BeginContext(111, 508, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91659edc93240d995c1ad00114bf66d71914be6d4437", async() => {
                BeginContext(148, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 184, "\"", 201, 1);
#line 11 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 192, Model.id, 192, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(202, 39, true);
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"Make\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 241, "\"", 260, 1);
#line 12 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 249, Model.make, 249, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 261, "\"", 286, 1);
#line 12 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 275, Model.make, 275, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(287, 40, true);
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"Model\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 327, "\"", 347, 1);
#line 13 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 335, Model.model, 335, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 348, "\"", 374, 1);
#line 13 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 362, Model.model, 362, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(375, 41, true);
                WriteLiteral(" />\r\n    <input type=\"number\" name=\"Year\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 416, "\"", 435, 1);
#line 14 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 424, Model.year, 424, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 436, "\"", 461, 1);
#line 14 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 450, Model.year, 450, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(462, 40, true);
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"Color\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 502, "\"", 522, 1);
#line 15 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 510, Model.color, 510, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 523, "\"", 549, 1);
#line 15 "C:\Users\JoshB\OneDrive\CarCapstoneAPIMVC\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 537, Model.color, 537, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(550, 62, true);
                WriteLiteral(" />\r\n\r\n\r\n    <input type=\"submit\" value=\"Save Data\" />\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarCapstoneAPIMVC.Models.CarInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
