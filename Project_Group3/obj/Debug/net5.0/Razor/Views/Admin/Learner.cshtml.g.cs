#pragma checksum "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Learner), @"mvc.1.0.view", @"/Views/Admin/Learner.cshtml")]
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
#line 1 "E:\2024\SP24\WebCourse\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2024\SP24\WebCourse\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab", @"/Views/Admin/Learner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Learner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebLibrary.Models.Learner>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/learner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-initial rounded-circle bg-label-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteLearner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
  
    ViewData["Title"] = "Learner Management";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab7411", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab8549", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js\"></script>\r\n\r\n");
#nullable restore
#line 10 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
  
    String iconClass = "";
    if(ViewBag.IconClass == "bxs-down-arrow")
    {
        iconClass = "bxs-up-arrow";
    }else{
        iconClass = "bxs-down-arrow";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
 if (TempData["EditSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"editAlert\"");
            BeginWriteAttribute("class", " class=\"", 608, "\"", 711, 6);
            WriteAttributeValue("", 616, "alert", 616, 5, true);
            WriteAttributeValue(" ", 621, "alert-", 622, 7, true);
#nullable restore
#line 22 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 628, (bool)TempData["EditSuccess"] ? "success" : "danger", 628, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 683, "alert-dismissible", 684, 18, true);
            WriteAttributeValue(" ", 701, "fade", 702, 5, true);
            WriteAttributeValue(" ", 706, "show", 707, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 23 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
    Write((bool)TempData["EditSuccess"] ? "Learner edited successfully." : "Failed to edit learner.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 26 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
 if (TempData["DeleteSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"deleteAlert\"");
            BeginWriteAttribute("class", " class=\"", 942, "\"", 1047, 6);
            WriteAttributeValue("", 950, "alert", 950, 5, true);
            WriteAttributeValue(" ", 955, "alert-", 956, 7, true);
#nullable restore
#line 30 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 962, (bool)TempData["DeleteSuccess"] ? "success" : "danger", 962, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1019, "alert-dismissible", 1020, 18, true);
            WriteAttributeValue(" ", 1037, "fade", 1038, 5, true);
            WriteAttributeValue(" ", 1042, "show", 1043, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 31 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
    Write((bool)TempData["DeleteSuccess"] ? "Learner deleted successfully." : "Failed to delete learner.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 34 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card bg-theme p-0 mt-2 mb-5\" >\r\n    <div class=\"container no-footer mt-5 mb-3 p-0\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-6\">\r\n                <div class=\"container-fluid\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab13468", async() => {
                WriteLiteral("\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1564, "\"", 1587, 1);
#nullable restore
#line 43 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 1572, ViewBag.search, 1572, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""search"" name=""search"" placeholder=""Search"">
                        <button class=""btn btn-primary btn-outline-primary ml-2"" type=""submit"">
                            <i class='bx bx-search-alt-2'></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        </div>
    </div>
    
    <div class=""container p-0 mt-3"">
        <table class=""datatables-basic table mb-5"">
            <thead>
                <tr>
                    <th width=""10""><input type=""checkbox"" id=""all"" class=""checkbox-item""></th>
                    <th width=""50"" class=""text-theme"">Name</th>
                    <th width=""120"" class=""text-theme"">Gender</th>
                    <th width=""120"" class=""text-theme"">Country</th>
                    <th width=""150"" class=""text-theme"">Registration</th>
                    <th width=""120"" class=""text-theme"">Status</th>
                    <th width=""70"" class=""text-theme"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 67 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                 foreach (var learner in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=\"", 2723, "\"", 2731, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <td class=""  dt-checkboxes-cell"">
                            <input type=""checkbox"">
                        </td>
                        <td>
                            <div class=""d-flex justify-content-start align-items-center user-name"">
                                <div class=""avatar-wrapper"">
                                    <div class=""avatar mr-2"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab17252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"d-flex flex-column\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3442, "\"", 3498, 3);
            WriteAttributeValue("", 3449, "/admin/userDetail/", 3449, 18, true);
#nullable restore
#line 80 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 3467, learner.LearnerId, 3467, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3485, "?role=learner", 3485, 13, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span class=\"text-truncate text-theme\">");
#nullable restore
#line 81 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                                          Write(learner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 81 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                             Write(learner.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <small class=\"text-truncate text-muted text-theme\">");
#nullable restore
#line 82 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                      Write(learner.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 87 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                          Write(learner.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 88 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                          Write(learner.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 89 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                          Write(learner.RegistrationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 91 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                                       Write(learner.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td class=\"text-theme\">\r\n                            <div class=\"action-icon d-flex text-center\">\r\n                                <a class=\"btn btn-warning mr-2\"");
            BeginWriteAttribute("href", " href=\"", 4459, "\"", 4498, 2);
            WriteAttributeValue("", 4466, "/learner/edit/", 4466, 14, true);
#nullable restore
#line 95 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 4480, learner.LearnerId, 4480, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\">\r\n                                    <i class=\'bx bxs-edit\'></i>\r\n                                </a>\r\n");
#nullable restore
#line 98 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                   
                                    if(learner.Status != "Delete"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <a class=""btn text-theme"" style=""background-color: rgb(169, 140, 140); cursor: pointer;"" data-bs-toggle=""modal"" data-bs-target=""#deleteModal"">
                                            <i class='bx bxs-trash-alt'></i>
                                        </a>
");
#nullable restore
#line 103 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54869e94d71bc9aeda6e750517326dd486f4ccc729f82a853065f050ad3e5ab23283", async() => {
                WriteLiteral("\r\n                                            <i class=\'bx bxs-trash-alt\'></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                               WriteLiteral(learner.LearnerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 107 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                    }
                                 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 112 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"7\">\r\n                        <div class=\"mt-3 text-theme\">\r\n                            Showing 1 to ");
#nullable restore
#line 116 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                    Write(ViewBag.PageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 116 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                         Write(ViewBag.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entries\r\n                        </div>\r\n                        <ul class=\"pagination ml-5 justify-content-end\" style=\"margin-top: -10px;\">\r\n");
#nullable restore
#line 119 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                             if (ViewBag.CurrentPage > 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6079, "\"", 6132, 2);
            WriteAttributeValue("", 6086, "/learner/index?page=", 6086, 20, true);
#nullable restore
#line 122 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 6106, ViewBag.CurrentPage - 1, 6106, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n                                </li>\r\n");
#nullable restore
#line 124 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                             for(int i = 1; i <= ViewBag.TotalPages; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item \">\r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 6419, "\"", 6495, 2);
            WriteAttributeValue("", 6427, "page-link", 6427, 9, true);
#nullable restore
#line 128 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue(" ", 6436, ViewBag.CurrentPage == i ? "bg-primary text-white" : "", 6437, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 6496, "\"", 6525, 2);
            WriteAttributeValue("", 6503, "/learner/index?page=", 6503, 20, true);
#nullable restore
#line 128 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 6523, i, 6523, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 128 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 130 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                             if (ViewBag.CurrentPage < ViewBag.TotalPages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6824, "\"", 6877, 2);
            WriteAttributeValue("", 6831, "/learner/index?page=", 6831, 20, true);
#nullable restore
#line 134 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
WriteAttributeValue("", 6851, ViewBag.CurrentPage + 1, 6851, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                                </li>\r\n");
#nullable restore
#line 136 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Learner.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </td>
                    </tr>
            </tbody>
        </table>
    </div>
</div>

<!-- The Modal -->
<div class=""modal"" id=""deleteModal"">
  <div class=""modal-dialog"">
    <div class=""modal-content bg-theme"">
      <div class=""modal-header"">
        <h3 class=""text-danger modal-title"">Error</h3>
        <button type=""button"" class=""btn-close bg-theme text-theme border-0"" data-bs-dismiss=""modal"">x</button>
      </div>
      <div class=""text-theme modal-body"">
        You can't not delete this account
      </div>

      <!-- Modal footer -->
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-success"" data-bs-dismiss=""modal"">OK</button>
      </div>
    </div>
  </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebLibrary.Models.Learner>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
