#pragma checksum "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0688abd698713c6f82467813217397dbceae6254"
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
#line 1 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\_ViewImports.cshtml"
using CarDealershipCapstoneAPI;

#line default
#line hidden
#line 2 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\_ViewImports.cshtml"
using CarDealershipCapstoneAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0688abd698713c6f82467813217397dbceae6254", @"/Views/CarInformation/EditCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0512eba4b921248446c3764324b3a0ba028910a2", @"/Views/_ViewImports.cshtml")]
    public class Views_CarInformation_EditCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarDealershipCapstoneAPI.Models.CarInfo>
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
#line 1 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
  
    ViewData["Title"] = "EditCar";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 23, true);
            WriteLiteral("\r\n<h1>Edit Car</h1>\r\n\r\n");
            EndContext();
            BeginContext(116, 508, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0688abd698713c6f82467813217397dbceae62544385", async() => {
                BeginContext(153, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 189, "\"", 206, 1);
#line 10 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 197, Model.id, 197, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(207, 39, true);
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"make\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 246, "\"", 265, 1);
#line 11 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 254, Model.make, 254, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 266, "\"", 291, 1);
#line 11 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 280, Model.make, 280, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(292, 40, true);
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"model\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 332, "\"", 352, 1);
#line 12 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 340, Model.model, 340, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 353, "\"", 379, 1);
#line 12 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 367, Model.model, 367, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(380, 41, true);
                WriteLiteral(" />\r\n    <input type=\"number\" name=\"year\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 421, "\"", 440, 1);
#line 13 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 429, Model.year, 429, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 441, "\"", 466, 1);
#line 13 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 455, Model.year, 455, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(467, 40, true);
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"color\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 507, "\"", 527, 1);
#line 14 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 515, Model.color, 515, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 528, "\"", 554, 1);
#line 14 "C:\Users\JoshB\OneDrive\CarDealershipCapstoneAPI\Views\CarInformation\EditCar.cshtml"
WriteAttributeValue("", 542, Model.color, 542, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(555, 62, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarDealershipCapstoneAPI.Models.CarInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
