#pragma checksum "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2029e8ae9bbbe140c0dfe75478d6f3659cc873ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditStep), @"mvc.1.0.view", @"/Views/Home/EditStep.cshtml")]
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
#line 1 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\_ViewImports.cshtml"
using MindYourPsandQs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\_ViewImports.cshtml"
using MindYourPsandQs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2029e8ae9bbbe140c0dfe75478d6f3659cc873ef", @"/Views/Home/EditStep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6eec99b45840a3593389f36de47ff3917669c3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditStep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Step>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <div class=""border bg-success p-3"">
        <div class=""row"">
            <div class=""col text-center"">
                <img src=""https://www.learnwithkak.com/wp-content/uploads/2017/12/pq-639x406.jpg"" height=""200px"" alt=""psandqs"">
            </div>
            <div class=""d-flex flex-column col justify-content-center"">
                <div>
                    <a href=""/dashboard"" class=""text-light"">Back to Languages | </a>
                    <a");
            BeginWriteAttribute("href", " href=\"", 487, "\"", 545, 2);
            WriteAttributeValue("", 494, "/language/", 494, 10, true);
#nullable restore
#line 11 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
WriteAttributeValue("", 504, ViewBag.RussianDoll.Objective.LanguageId, 504, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-light\">| Back to Objectives | </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 653, 2);
            WriteAttributeValue("", 624, "/objective/", 624, 11, true);
#nullable restore
#line 12 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
WriteAttributeValue("", 635, Model.ObjectiveId, 635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-light\">| Back to Steps</a>\r\n                </div>\r\n                <div>\r\n                    <h3>Update Step in ");
#nullable restore
#line 15 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
                                  Write(ViewBag.RussianDoll.Objective.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>\r\n\r\n<div class=\"text-center container mt-5\">\r\n    <div class=\"row container\">\r\n        <div class=\"col\">\r\n            Instructions:\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2029e8ae9bbbe140c0dfe75478d6f3659cc873ef6270", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2029e8ae9bbbe140c0dfe75478d6f3659cc873ef6540", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 27 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AStep);

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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2029e8ae9bbbe140c0dfe75478d6f3659cc873ef8034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 28 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AStep);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"ObjectiveId\"");
                BeginWriteAttribute("value", " value=\"", 1269, "\"", 1295, 1);
#nullable restore
#line 29 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
WriteAttributeValue("", 1277, Model.ObjectiveId, 1277, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-info\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1063, "/update/step/", 1063, 13, true);
#nullable restore
#line 26 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
AddHtmlAttributeValue("", 1076, Model.StepId, 1076, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            <p>Delete Step?</p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1481, "\"", 1513, 2);
            WriteAttributeValue("", 1488, "/deleteStep/", 1488, 12, true);
#nullable restore
#line 35 "C:\Users\wordy\Desktop\CodingDojo\MindYourPsandQs\Views\Home\EditStep.cshtml"
WriteAttributeValue("", 1500, Model.StepId, 1500, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Step> Html { get; private set; }
    }
}
#pragma warning restore 1591