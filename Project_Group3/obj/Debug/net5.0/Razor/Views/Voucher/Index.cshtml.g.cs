#pragma checksum "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "889164c6f8b3dd18293dd954e44a00fdfda68fc9cd82cae6195ac60b91e7226c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voucher_Index), @"mvc.1.0.view", @"/Views/Voucher/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\SWP\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SWP\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"889164c6f8b3dd18293dd954e44a00fdfda68fc9cd82cae6195ac60b91e7226c", @"/Views/Voucher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6925787e4d23fd4cbbfa572d9e9b5c1189eba9ade7d7bab7b284e3bc23eda31c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Voucher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebLibrary.Models.Voucher>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "889164c6f8b3dd18293dd954e44a00fdfda68fc9cd82cae6195ac60b91e7226c4925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div class=\"card bg-theme p-0 mt-2 mb-5\">\n    <div class=\"container my-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "889164c6f8b3dd18293dd954e44a00fdfda68fc9cd82cae6195ac60b91e7226c6150", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <table class=""table"">
            <thead>
                <tr>
                    <th>Admin ID</th>
                    <th>Voucher ID</th>
                    <th>Percent Discount</th>
                    <th>Code Voucher</th>
                    <th>Start At</th>
                    <th>End At</th>
                    <th>Is Active</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 28 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.AdminId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 29 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.VoucherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 30 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.PercentDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.CodeVoucher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 32 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.StartAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 33 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.EndAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 34 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
                       Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1211, "\"", 1277, 1);
#nullable restore
#line 35 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
WriteAttributeValue("", 1218, Url.Action("Delete", "Voucher", new{id = @item.VoucherId}), 1218, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\n                    </tr>\n");
#nullable restore
#line 37 "D:\SWP\Project_Group3\Views\Voucher\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebLibrary.Models.Voucher>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
