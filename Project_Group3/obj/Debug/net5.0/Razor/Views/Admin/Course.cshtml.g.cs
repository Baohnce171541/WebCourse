#pragma checksum "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4a43266d0fe13df23578dd2edf65d0b9536aae3f87e560ee7a3dd34cae0dcc5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Course), @"mvc.1.0.view", @"/Views/Admin/Course.cshtml")]
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
#line 1 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4a43266d0fe13df23578dd2edf65d0b9536aae3f87e560ee7a3dd34cae0dcc5c", @"/Views/Admin/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<WebLibrary.Models.Course>, List<WebLibrary.Models.Category>,
List<WebLibrary.Models.Instruct>, List<WebLibrary.Models.Instructor>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
  
    ViewData["Title"] = "Course Management";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a43266d0fe13df23578dd2edf65d0b9536aae3f87e560ee7a3dd34cae0dcc5c6859", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a43266d0fe13df23578dd2edf65d0b9536aae3f87e560ee7a3dd34cae0dcc5c7997", async() => {
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
#line 11 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
  
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
#nullable restore
#line 22 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
 if (TempData["EditSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"editAlert\"");
            BeginWriteAttribute("class", "\r\n        class=\"", 723, "\"", 835, 6);
            WriteAttributeValue("", 740, "alert", 740, 5, true);
            WriteAttributeValue(" ", 745, "alert-", 746, 7, true);
#nullable restore
#line 25 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 752, (bool)TempData["EditSuccess"] ? "success" : "danger", 752, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 807, "alert-dismissible", 808, 18, true);
            WriteAttributeValue(" ", 825, "fade", 826, 5, true);
            WriteAttributeValue(" ", 830, "show", 831, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 26 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
    Write((bool)TempData["EditSuccess"] ? "Instructor edited successfully." : "Failed to edit instructor.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
 if (TempData["DeleteSuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"deleteAlert\"");
            BeginWriteAttribute("class", "\r\n        class=\"", 1072, "\"", 1186, 6);
            WriteAttributeValue("", 1089, "alert", 1089, 5, true);
            WriteAttributeValue(" ", 1094, "alert-", 1095, 7, true);
#nullable restore
#line 34 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 1101, (bool)TempData["DeleteSuccess"] ? "success" : "danger", 1101, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1158, "alert-dismissible", 1159, 18, true);
            WriteAttributeValue(" ", 1176, "fade", 1177, 5, true);
            WriteAttributeValue(" ", 1181, "show", 1182, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 35 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
    Write((bool)TempData["DeleteSuccess"] ? "Instructor deleted successfully." : "Failed to delete instructor.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"progressBar\"></div>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card bg-theme p-0 mt-2 mb-5"">
    <div class=""container no-footer mt-5 mb-3 p-0"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-6 d-flex mr-5"" style=""justify-content: space-between;"">
                <div class=""container-fluid"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a43266d0fe13df23578dd2edf65d0b9536aae3f87e560ee7a3dd34cae0dcc5c13160", async() => {
                WriteLiteral("\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1755, "\"", 1778, 1);
#nullable restore
#line 45 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 1763, ViewBag.search, 1763, 15, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"user-plus\">\r\n");
#nullable restore
#line 52 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                      
                        int countCourse = 0;
                        foreach(var course in Model.Item1){
                            if(course.Status == "Wait"){
                                countCourse++;
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2466, "\"", 2542, 3);
            WriteAttributeValue("", 2476, "location.href=\'", 2476, 15, true);
#nullable restore
#line 60 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 2491, Url.Action("Course", new { showOnlyWait = true }), 2491, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2541, "\'", 2541, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn"">
                        <i class='bx bxs-book-add text-theme' style=""font-size: 2.5rem;""></i>
                        <p class=""badge-instructor bg-danger rounded-pill text-center text-white"" 
                        style=""position: absolute; width: 18px; height: 18px; font-size: .8rem; top: 0;right: 16px;"">");
#nullable restore
#line 63 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                                                                Write(countCourse);

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
                    <th width=""250"" class=""text-theme"">Course Name</th>
                    <th width=""170"" class=""text-theme"">Category</th>
                    <th width=""120"" class=""text-theme"">Instructor</th>
                    <th width=""90"" class=""text-theme"">Price</th>
                    <th width=""50"" class=""text-theme"">Status</th>
                    <th width=""70"" class=""text-theme"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 84 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                  
                    if (ViewBag.Status == "Wait"){
                        foreach (var course in Model.Item1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 3915, "\"", 3923, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <td class=""  dt-checkboxes-cell"">
                                    <input type=""checkbox"">
                                </td>
                                <td class=""text-theme"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 4189, "\"", 4232, 2);
            WriteAttributeValue("", 4196, "/admin/courseDetail/", 4196, 20, true);
#nullable restore
#line 93 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 4216, course.CourseId, 4216, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                              Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </td>\r\n");
#nullable restore
#line 95 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                 foreach (var category in Model.Item2)
                                {
                                    if (category.CategoryId == course.CategoryId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-theme\">");
#nullable restore
#line 99 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 100 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                 foreach (var instructor in Model.Item4)
                                {
                                    foreach (var instruct in Model.Item3)
                                    {
                                        if (course.CourseId == instruct.CourseId && instructor.InstructorId == instruct.InstructorId)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-theme\">");
#nullable restore
#line 108 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                              Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 108 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                                    Write(instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 109 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"text-theme\">");
#nullable restore
#line 112 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                  Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 114 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                               Write(course.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td class=\"text-theme\">\r\n                                    <div class=\"action-icon d-flex text-center\">\r\n                                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", "\r\n                                            href=\"", 5790, "\"", 5882, 2);
            WriteAttributeValue("", 5842, "/admin/CourseModeration/", 5842, 24, true);
#nullable restore
#line 119 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 5866, course.CourseId, 5866, 16, false);

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
#line 126 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                        }
                    }else{
                        foreach (var course in Model.Item1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 6368, "\"", 6376, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <td class=""  dt-checkboxes-cell"">
                                    <input type=""checkbox"">
                                </td>
                                <td class=""text-theme"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6642, "\"", 6685, 2);
            WriteAttributeValue("", 6649, "/admin/courseDetail/", 6649, 20, true);
#nullable restore
#line 135 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 6669, course.CourseId, 6669, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 135 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                              Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </td>\r\n");
#nullable restore
#line 137 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                 foreach (var category in Model.Item2)
                                {
                                    if (category.CategoryId == course.CategoryId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-theme\">");
#nullable restore
#line 141 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 142 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                 foreach (var instructor in Model.Item4)
                                {
                                    foreach (var instruct in Model.Item3)
                                    {
                                        if (course.CourseId == instruct.CourseId && instructor.InstructorId == instruct.InstructorId)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-theme\">");
#nullable restore
#line 150 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                              Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 150 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                                    Write(instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 151 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"text-theme\">");
#nullable restore
#line 154 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                  Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 156 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                               Write(course.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </td>
                                <td class=""text-theme"">
                                    <div class=""action-icon d-flex text-center"">
                                        <a class=""btn btn-warning mr-2""");
            BeginWriteAttribute("href", "\r\n                                        href=\"", 8248, "\"", 8354, 1);
#nullable restore
#line 161 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 8296, Url.Action("Edit", "Admin", new { id = @course.CourseId}), 8296, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\">\r\n                                            <i class=\'bx bxs-edit\'></i>\r\n                                        </a>\r\n");
#nullable restore
#line 164 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                          
                                            if(course.Status != "Delete"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <a class=""btn text-theme"" style=""background-color: rgb(169, 140, 140); cursor: pointer;"" data-bs-toggle=""modal"" data-bs-target=""#deleteModal"">
                                                    <i class='bx bxs-trash-alt'></i>
                                                </a>
");
#nullable restore
#line 169 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a43266d0fe13df23578dd2edf65d0b9536aae3f87e560ee7a3dd34cae0dcc5c30933", async() => {
                WriteLiteral("\r\n                                                    <i class=\'bx bxs-trash-alt\'></i>\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 170 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                                                                                      WriteLiteral(course.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 173 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 178 "C:\Users\admin\Downloads\Project03\WebCourse\Project_Group3\Views\Admin\Course.cshtml"
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
        You can't not delete this course
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<WebLibrary.Models.Course>, List<WebLibrary.Models.Category>,
List<WebLibrary.Models.Instruct>, List<WebLibrary.Models.Instructor>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
