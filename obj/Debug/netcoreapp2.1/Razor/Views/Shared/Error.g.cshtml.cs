#pragma checksum "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca53f4f63bd0f24bc15d0c33577154a67e716752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca53f4f63bd0f24bc15d0c33577154a67e716752", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalesWebMvc.Models.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(94, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(121, 17, false);
#line 6 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 32, true);
            WriteLiteral(".</h1>\r\n<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(171, 13, false);
#line 7 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml"
                   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(184, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(223, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(276, 15, false);
#line 12 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(291, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "c:\Users\DELL-PC\Desktop\SalesWebMvc\Views\Shared\Error.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalesWebMvc.Models.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
