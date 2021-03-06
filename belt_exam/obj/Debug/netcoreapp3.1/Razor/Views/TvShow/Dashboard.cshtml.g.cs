#pragma checksum "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cce0989206d07b0fa8050aae96eb912e1c1455c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.TvShow.Views_TvShow_Dashboard), @"mvc.1.0.view", @"/Views/TvShow/Dashboard.cshtml")]
namespace MyApp.Namespace.TvShow
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
#line 1 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
using belt_exam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cce0989206d07b0fa8050aae96eb912e1c1455c", @"/Views/TvShow/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_TvShow_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardView>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cce0989206d07b0fa8050aae96eb912e1c1455c3106", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Belt Prep</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cce0989206d07b0fa8050aae96eb912e1c1455c4498", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"d-flex justify-content-between\">\r\n            <h1>Welcome ");
#nullable restore
#line 16 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
                   Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
            <a href=""/logout"">Log Out</a>
        </div>
        <h2>TV Shows</h2>
        <table class=""table"">
            <thead>
                <tr class=""row"">
                    <th class=""col-7"">Show</th>
                    <th class=""col-2"">Network</th>
                    <th class=""col-3"">Avg Rating</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
                 foreach(TVShow show in Model.AllShows)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr class=\"row\">\r\n                        <td class=\"col-7\"><a");
                BeginWriteAttribute("href", " href=\"", 1200, "\"", 1228, 2);
                WriteAttributeValue("", 1207, "/shows/", 1207, 7, true);
#nullable restore
#line 32 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
WriteAttributeValue("", 1214, show.TVShowId, 1214, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
                                                                     Write(show.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                        <td class=\"col-2\">");
#nullable restore
#line 33 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
                                     Write(show.Network);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"col-3\">");
#nullable restore
#line 34 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
                                     Write(show.AverageRating);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\randy\dotnetprojects\belt_exam\Views\TvShow\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <a href=\"/shows/new\" class=\"btn btn-secondary\">Add a Show</a>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardView> Html { get; private set; }
    }
}
#pragma warning restore 1591
