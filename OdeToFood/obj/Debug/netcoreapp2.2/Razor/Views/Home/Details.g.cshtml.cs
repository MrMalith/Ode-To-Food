#pragma checksum "D:\ASP.NetCore\OdeToFood\OdeToFood\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f9afd2dc2f5e764c7c297ecb35bd3bf29094e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "D:\ASP.NetCore\OdeToFood\OdeToFood\Views\Home\Details.cshtml"
using OdeToFood.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f9afd2dc2f5e764c7c297ecb35bd3bf29094e3", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OdeToFood.Entities.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(76, 10, false);
#line 4 "D:\ASP.NetCore\OdeToFood\OdeToFood\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(86, 33, true);
            WriteLiteral("</h1>\r\n\r\n    <div>\r\n        Id = ");
            EndContext();
            BeginContext(120, 8, false);
#line 7 "D:\ASP.NetCore\OdeToFood\OdeToFood\Views\Home\Details.cshtml"
        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(128, 43, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Cuisine = ");
            EndContext();
            BeginContext(172, 13, false);
#line 10 "D:\ASP.NetCore\OdeToFood\OdeToFood\Views\Home\Details.cshtml"
             Write(Model.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(185, 27, true);
            WriteLiteral("\r\n    </div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(213, 52, false);
#line 14 "D:\ASP.NetCore\OdeToFood\OdeToFood\Views\Home\Details.cshtml"
Write(Html.ActionLink("Home",nameof(HomeController.Index)));

#line default
#line hidden
            EndContext();
            BeginContext(265, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Entities.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
