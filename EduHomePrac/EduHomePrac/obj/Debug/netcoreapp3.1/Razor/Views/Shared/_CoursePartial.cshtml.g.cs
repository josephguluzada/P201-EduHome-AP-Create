#pragma checksum "C:\Users\asus\Desktop\Eduhome\EduHomePrac\EduHomePrac\Views\Shared\_CoursePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b69aeca1423677506ed2ac7f92fea2020b295b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CoursePartial), @"mvc.1.0.view", @"/Views/Shared/_CoursePartial.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\Eduhome\EduHomePrac\EduHomePrac\Views\_ViewImports.cshtml"
using EduHomePrac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\Eduhome\EduHomePrac\EduHomePrac\Views\_ViewImports.cshtml"
using EduHomePrac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\Desktop\Eduhome\EduHomePrac\EduHomePrac\Views\_ViewImports.cshtml"
using EduHomePrac.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b69aeca1423677506ed2ac7f92fea2020b295b", @"/Views/Shared/_CoursePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44798ee7dc967735cb7f03fc72f1572546f9dc1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CoursePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-header"">
    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>
<div class=""modal-body"">
    <h1 class=""product-title"">");
#nullable restore
#line 9 "C:\Users\asus\Desktop\Eduhome\EduHomePrac\EduHomePrac\Views\Shared\_CoursePartial.cshtml"
                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"product-desc\">");
#nullable restore
#line 10 "C:\Users\asus\Desktop\Eduhome\EduHomePrac\EduHomePrac\Views\Shared\_CoursePartial.cshtml"
                       Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        <button type=\"button\" class=\"btn btn-primary\">Save changes</button>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
