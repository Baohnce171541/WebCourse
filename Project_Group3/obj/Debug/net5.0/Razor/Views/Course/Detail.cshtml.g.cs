#pragma checksum "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6904a3f3d72cb815510260de58a2d2a4127b4af42e902f625d4f0fdb42211439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Detail), @"mvc.1.0.view", @"/Views/Course/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6904a3f3d72cb815510260de58a2d2a4127b4af42e902f625d4f0fdb42211439", @"/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<WebLibrary.Models.Course, IEnumerable<WebLibrary.Models.Chapter>, IEnumerable<WebLibrary.Models.Category>,
     IEnumerable<WebLibrary.Models.Instruct>, IEnumerable<WebLibrary.Models.Lesson>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatars/course/course-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_LayoutCourse.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/wwwroot/css/site.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6904a3f3d72cb815510260de58a2d2a4127b4af42e902f625d4f0fdb422114395842", async() => {
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
            WriteLiteral(@"


<div class=""container-fluid mt-2 mb-3 p-0"">
    <div class=""card mb-4 bg-theme"">
        <div class=""card-body d-flex"" style=""justify-content: space-between;"">
            <div class=""d-flex align-items-start align-items-sm-center gap-4 ml-5"">
                <div class=""mt-5"">
                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6904a3f3d72cb815510260de58a2d2a4127b4af42e902f625d4f0fdb422114397300", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"id-text form-group\">\r\n                    <label class=\"text-theme font-weight-bold\">Course ID</label>\r\n                    <input");
            BeginWriteAttribute("value", " value=\"", 997, "\"", 1026, 1);
#nullable restore
#line 20 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1005, Model.Item1.CourseId, 1005, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                </div>
            </div>
        </div>
        <div class=""container-fluid ml-5"">
            <div class=""row"">
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Course Name</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 1425, "\"", 1456, 1);
#nullable restore
#line 29 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1433, Model.Item1.CourseName, 1433, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" disabled/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"mb-3 col-md-6\">\r\n                    <div class=\"form-group\"> \r\n");
#nullable restore
#line 34 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                          
                            foreach (var category in Model.Item3){
                                if(Model.Item1.CategoryId == category.CategoryId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label class=\"text-theme font-weight-bold\">Category Name</label>\r\n                                    <input");
            BeginWriteAttribute("value", " value=\"", 1979, "\"", 2009, 1);
#nullable restore
#line 38 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1987, category.CategoryName, 1987, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" disabled/>\r\n");
#nullable restore
#line 39 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"mb-3 col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"text-theme font-weight-bold\">Price</label>\r\n                        <input");
            BeginWriteAttribute("value", " value=\"", 2412, "\"", 2438, 1);
#nullable restore
#line 47 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 2420, Model.Item1.Price, 2420, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Total Time</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 2753, "\"", 2783, 1);
#nullable restore
#line 53 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 2761, Model.Item1.TotalTime, 2761, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width: 80%;"" disabled/>
                    </div>
                </div> 
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Description</label><br>
                        <textarea rows=""3"" cols=""60"" class=""outline-0 mt-2"" disabled>");
#nullable restore
#line 59 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                Write(Model.Item1.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>
                <div class=""mb-3 col-md-6"">
                    <div class=""form-group"">
                        <label class=""text-theme font-weight-bold"">Status</label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 3452, "\"", 3479, 1);
#nullable restore
#line 65 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 3460, Model.Item1.Status, 3460, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width: 80%;\" disabled/>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"container\">\r\n            <!-- List of Chapter Start-->\r\n");
#nullable restore
#line 73 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
              
                foreach(var chapter in Model.Item2){
                    if(chapter.CourseId == Model.Item1.CourseId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-12 col-md-12\">\r\n                            <div class=\"box-chaper mb-2\" data-bs-toggle=\"collapse\" data-bs-target=\"#list-lesson");
#nullable restore
#line 77 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                                           Write(chapter.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <div class=""chapter-list d-flex"">
                                    <div class=""chapter-item d-flex"">
                                        <i class='bx bx-plus text-primary mr-1 mt-3 ml-3'></i>
                                        <h5 class=""pt-3 text-theme""><b>");
#nullable restore
#line 81 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                  Write(chapter.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 81 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                 Write(chapter.ChapterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n                                    </div>\r\n");
#nullable restore
#line 83 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                      
                                        int lessonTmp = 0;
                                        foreach(var lesson in Model.Item5){
                                            if(chapter.ChapterId == lesson.ChapterId){
                                                lessonTmp++;
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"quanity-lesson text-dark text-end mr-4\"><b>");
#nullable restore
#line 91 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                    Write(lessonTmp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> lesson</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 5130, "\"", 5162, 2);
            WriteAttributeValue("", 5135, "list-lesson", 5135, 11, true);
#nullable restore
#line 95 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 5146, chapter.Index, 5146, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""collapse"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-lg-12 col-md-12"">
                                        <div class=""box-chaper mb-2"">
                                            <div class="" d-flex"">
");
#nullable restore
#line 101 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                  
                                                    foreach(var lesson in Model.Item5){
                                                        if(chapter.ChapterId == lesson.ChapterId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a");
            BeginWriteAttribute("href", " href=\"", 5799, "\"", 5837, 2);
            WriteAttributeValue("", 5806, "/Home/Learning/", 5806, 15, true);
#nullable restore
#line 104 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 5821, lesson.LessonId, 5821, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-flex justify-content-between"">
                                                                <div class=""lesson-item d-flex ml-4"">
                                                                    <i class='text-primary bx bxs-caret-right-circle mr-1 mt-3 ml-3'></i>
                                                                    <h6 class=""pt-3"">");
#nullable restore
#line 107 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                Write(lesson.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 107 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                               Write(lesson.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                                </div>\r\n");
#nullable restore
#line 109 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                  
                                                                    int? hourLesson = @lesson.Time / 60; // Số giờ
                                                                    int? minuteLesson = @lesson.Time % 60; // Số phút
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <p class=\"quanity-lesson text-end mt-2 ml-5\">");
#nullable restore
#line 113 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                                        Write(hourLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 113 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                                                                                      Write(minuteLesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                            </a>\r\n");
#nullable restore
#line 115 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div> 
                        </div>
                        <!-- List of Chapter End-->
");
#nullable restore
#line 125 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 129 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
          
            var cookieValue = Context.Request.Cookies["ID"];
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 7536, "\"", 7599, 1);
#nullable restore
#line 132 "E:\2024\SP24\WebCourse\Project_Group3\Views\Course\Detail.cshtml"
WriteAttributeValue("", 7543, Url.Action("Index", "Course", new { id = cookieValue }), 7543, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary ml-5 mb-5 mt-5\" style=\"width: 8rem;\">Back</a>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<WebLibrary.Models.Course, IEnumerable<WebLibrary.Models.Chapter>, IEnumerable<WebLibrary.Models.Category>,
     IEnumerable<WebLibrary.Models.Instruct>, IEnumerable<WebLibrary.Models.Lesson>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
