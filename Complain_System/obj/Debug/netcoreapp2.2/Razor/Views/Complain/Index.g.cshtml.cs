#pragma checksum "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5504c95b188105aa9a25a21105edf778e3d6e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complain_Index), @"mvc.1.0.view", @"/Views/Complain/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Complain/Index.cshtml", typeof(AspNetCore.Views_Complain_Index))]
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
#line 1 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System;

#line default
#line hidden
#line 2 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System.Models;

#line default
#line hidden
#line 3 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System.Models.Auth;

#line default
#line hidden
#line 4 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System.ViewModels;

#line default
#line hidden
#line 5 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
using Complain_System.Models.Regular;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f5504c95b188105aa9a25a21105edf778e3d6e2", @"/Views/Complain/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a392109b396bec8b99624aa6973f9e62f8e9fc0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Complain_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Complain>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Complain", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 114, true);
            WriteLiteral("<br /><br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-success\">Complains</h2>\n    </div>\n");
            EndContext();
            BeginContext(381, 376, true);
            WriteLiteral(@"</div>
<br />
<div>
    <table class=""table table-striped border"">
        <tr class=""table-success"">
            <th>
                UserName
            </th>
            <th>
                ContactNo
            </th>
            <th>
                Email
            </th>
            <th>
                Complain
            </th>
            <td></td>
        </tr>
");
            EndContext();
#line 33 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(804, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(842, 14, false);
#line 36 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(856, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(858, 13, false);
#line 36 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
                               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(871, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(898, 14, false);
#line 37 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
               Write(item.ContactNo);

#line default
#line hidden
            EndContext();
            BeginContext(912, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(939, 10, false);
#line 38 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(949, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(976, 12, false);
#line 39 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
               Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(988, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
            BeginContext(1120, 41, true);
            WriteLiteral("                <td>\n                    ");
            EndContext();
            BeginContext(1161, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f5504c95b188105aa9a25a21105edf778e3d6e27737", async() => {
                BeginContext(1258, 55, true);
                WriteLiteral("\n                        Solved???\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1317, 44, true);
            WriteLiteral("\n                </td>\n                <td>\n");
            EndContext();
            BeginContext(1567, 41, true);
            WriteLiteral("                </td>\n\n            </tr>\n");
            EndContext();
#line 55 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1618, 20, true);
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Complain>> Html { get; private set; }
    }
}
#pragma warning restore 1591