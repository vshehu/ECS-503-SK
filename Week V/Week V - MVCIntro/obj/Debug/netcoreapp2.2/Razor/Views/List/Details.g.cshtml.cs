#pragma checksum "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\List\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "183fd19d57ef4033b577ea8cd7b4a0e040b755f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Details), @"mvc.1.0.view", @"/Views/List/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/Details.cshtml", typeof(AspNetCore.Views_List_Details))]
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
#line 1 "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\_ViewImports.cshtml"
using Week_V___MVCIntro;

#line default
#line hidden
#line 2 "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\_ViewImports.cshtml"
using Week_V___MVCIntro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"183fd19d57ef4033b577ea8cd7b4a0e040b755f5", @"/Views/List/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f505c5c7ea96d2529518c5c565ada31a001d6a", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Week_V___MVCIntro.Models.TodoList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\List\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 22, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n");
            EndContext();
            BeginContext(108, 36, false);
#line 8 "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\List\Details.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(144, 11, true);
            WriteLiteral(";\r\n<br />\r\n");
            EndContext();
            BeginContext(156, 43, false);
#line 10 "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\List\Details.cshtml"
Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(199, 13, true);
            WriteLiteral(";\r\n\r\n<br />\r\n");
            EndContext();
            BeginContext(213, 40, false);
#line 13 "C:\Users\Visar\source\repos\Week V - MVCIntro\Week V - MVCIntro\Views\List\Details.cshtml"
Write(Html.DisplayFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(253, 3, true);
            WriteLiteral(";\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Week_V___MVCIntro.Models.TodoList> Html { get; private set; }
    }
}
#pragma warning restore 1591
