#pragma checksum "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Instructor), @"mvc.1.0.view", @"/Views/Admin/Instructor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c", @"/Views/Admin/Instructor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Instructor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebLibrary.Models.Instructor>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/instructor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-initial rounded-circle bg-label-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteInstructor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
  
    ViewData["Title"] = "Instructor Management";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c7443", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c8581", async() => {
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
#line 11 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
  
    String iconClass = "";

    if (ViewBag.IconClass == "bxs-down-arrow")
    {
        iconClass = "bxs-up-arrow";
    }
    else
    {
       iconClass = "bxs-down-arrow";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
 if (TempData["EditSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"editAlert\"");
            BeginWriteAttribute("class", "\r\n        class=\"", 630, "\"", 742, 6);
            WriteAttributeValue("", 647, "alert", 647, 5, true);
            WriteAttributeValue(" ", 652, "alert-", 653, 7, true);
#nullable restore
#line 27 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 659, (bool)TempData["EditSuccess"] ? "success" : "danger", 659, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 714, "alert-dismissible", 715, 18, true);
            WriteAttributeValue(" ", 732, "fade", 733, 5, true);
            WriteAttributeValue(" ", 737, "show", 738, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 28 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
    Write((bool)TempData["EditSuccess"] ? "Instructor edited successfully." : "Failed to edit instructor.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 31 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
 if (TempData["DeleteSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"deleteAlert\"");
            BeginWriteAttribute("class", "\r\n        class=\"", 979, "\"", 1093, 6);
            WriteAttributeValue("", 996, "alert", 996, 5, true);
            WriteAttributeValue(" ", 1001, "alert-", 1002, 7, true);
#nullable restore
#line 36 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 1008, (bool)TempData["DeleteSuccess"] ? "success" : "danger", 1008, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1065, "alert-dismissible", 1066, 18, true);
            WriteAttributeValue(" ", 1083, "fade", 1084, 5, true);
            WriteAttributeValue(" ", 1088, "show", 1089, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 37 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
    Write((bool)TempData["DeleteSuccess"] ? "Instructor deleted successfully." : "Failed to delete instructor.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 40 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card bg-theme p-0 mt-2 mb-5"">
    <div class=""container no-footer mt-5 mb-3 p-0"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-6 d-flex mr-5"" style=""justify-content: space-between;"">
                <div class=""container-fluid"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c13619", async() => {
                WriteLiteral("\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1670, "\"", 1693, 1);
#nullable restore
#line 49 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 1678, ViewBag.search, 1678, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""search"" name=""search""
                            placeholder=""Search"">
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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"user-plus\">\r\n");
#nullable restore
#line 57 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                      
                        int countInstructor = 0; 

                        foreach (var instructor in Model)
                        {
                            if (instructor.Status == "Wait")
                            {
                                countInstructor++;

                            }

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2485, "\"", 2565, 3);
            WriteAttributeValue("", 2495, "location.href=\'", 2495, 15, true);
#nullable restore
#line 70 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 2510, Url.Action("Instructor", new { showOnlyWait = true }), 2510, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2564, "\'", 2564, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"
                        class=""btn"">
                        <i class='bx bxs-user-plus text-theme' style=""font-size: 2.5rem;""></i>
                        <p class=""badge-instructor bg-danger rounded-pill text-center text-white""
                            style=""position: absolute; width: 18px; height: 18px; font-size: .8rem; top: 0;right: 16px;"">
                            ");
#nullable restore
#line 75 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                       Write(countInstructor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </button>
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
#line 96 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                  
                    if (ViewBag.Status == "Wait")
                    {
                        foreach (var instructor in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 3997, "\"", 4005, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <td class=""  dt-checkboxes-cell"">
                                    <input type=""checkbox"">
                                </td>
                                <td>
                                    <div class=""d-flex justify-content-start align-items-center user-name"">
                                        <div class=""avatar-wrapper"">
                                            <div class=""avatar mr-2"">
                                                <img class=""avatar-initial rounded-circle bg-label-warning""");
            BeginWriteAttribute("src", " src=\"", 4571, "\"", 4596, 1);
#nullable restore
#line 109 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 4577, instructor.Picture, 4577, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"d-flex flex-column\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4820, "\"", 4869, 2);
            WriteAttributeValue("", 4827, "/admin/userDetail/", 4827, 18, true);
#nullable restore
#line 113 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 4845, instructor.InstructorId, 4845, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <span class=\"text-truncate text-theme\">");
#nullable restore
#line 114 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                                                  Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    ");
#nullable restore
#line 115 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                               Write(instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                                <small class=\"text-truncate text-muted text-theme\">");
#nullable restore
#line 116 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                                                              Write(instructor.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            </a>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"text-theme\">");
#nullable restore
#line 121 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                  Write(instructor.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-theme\">");
#nullable restore
#line 122 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                  Write(instructor.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-theme\">");
#nullable restore
#line 123 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                  Write(instructor.RegistrationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 125 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                                               Write(instructor.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td class=\"text-theme\">\r\n                                    <div class=\"action-icon d-flex text-center\">\r\n                                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", "\r\n                                            href=\"", 6019, "\"", 6120, 2);
            WriteAttributeValue("", 6071, "/admin/AccountModeration/", 6071, 25, true);
#nullable restore
#line 130 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 6096, instructor.InstructorId, 6096, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                            title=""Check account"">
                                            <i class='bx bxs-user-pin'></i>
                                        </a>
                                    </div>
                                </td>
                            </tr>
");
#nullable restore
#line 137 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                        }

                    }
                    else if (ViewBag.Status == "")
                    {
                        foreach (var instructor in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 6676, "\"", 6684, 0);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c25488", async() => {
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
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"d-flex flex-column\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7491, "\"", 7556, 3);
            WriteAttributeValue("", 7498, "/admin/userDetail/", 7498, 18, true);
#nullable restore
#line 156 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 7516, instructor.InstructorId, 7516, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7540, "?role=instructor", 7540, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <span class=\"text-truncate text-theme\">");
#nullable restore
#line 157 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                                                  Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    ");
#nullable restore
#line 158 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                               Write(instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                                <small class=\"text-truncate text-muted text-theme\">");
#nullable restore
#line 159 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                                                              Write(instructor.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            </a>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"text-theme\">");
#nullable restore
#line 164 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                  Write(instructor.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-theme\">");
#nullable restore
#line 165 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                  Write(instructor.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-theme\">");
#nullable restore
#line 166 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                  Write(instructor.RegistrationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 168 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                                               Write(instructor.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </td>
                                <td class=""text-theme"">
                                    <div class=""action-icon d-flex text-center"">
                                        <a class=""btn btn-warning mr-2""");
            BeginWriteAttribute("href", " href=\"", 8711, "\"", 8759, 2);
            WriteAttributeValue("", 8718, "/instructor/edit/", 8718, 17, true);
#nullable restore
#line 172 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
WriteAttributeValue("", 8735, instructor.InstructorId, 8735, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                            title=\"Edit\">\r\n                                            <i class=\'bx bxs-edit\'></i>\r\n                                        </a>\r\n");
#nullable restore
#line 176 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                          
                                            if (instructor.Status != "Delete")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <a class=""btn text-theme"" style=""background-color: rgb(169, 140, 140); cursor: pointer;""
                                                    data-bs-toggle=""modal"" data-bs-target=""#deleteModal"">
                                                    <i class='bx bxs-trash-alt'></i>
                                                </a>
");
#nullable restore
#line 183 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011688b6ad0412462af425592142c168370a09fb1cff4215385153db2d9265c32116", async() => {
                WriteLiteral("\r\n                                                    <i class=\'bx bxs-trash-alt\'></i>\r\n                                                ");
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
#line 187 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                                      WriteLiteral(instructor.InstructorId);

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
#line 190 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 195 "E:\2024\SP24\WebCourse\Project_Group3\Views\Admin\Instructor.cshtml"
                        }

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebLibrary.Models.Instructor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
