#pragma checksum "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2130895808faaa487be53728e8a4d0aeec6a5b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/_ViewImports.cshtml"
using DojoTemplate;

#line default
#line hidden
#line 2 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/_ViewImports.cshtml"
using DojoTemplate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2130895808faaa487be53728e8a4d0aeec6a5b6", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c28a43f11e428aa23d7b5fef99e861dbeff80a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 82, true);
            WriteLiteral("<div class=\"jumbotron\">\n    <div class=\"container\">\n        <h1 class=\"display-3\">");
            EndContext();
            BeginContext(83, 10, false);
#line 3 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml"
                         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(93, 78, true);
            WriteLiteral("</h1>\n        <h3>Description:</h3>\n        <ul>\n            <li class=\"lead\">");
            EndContext();
            BeginContext(172, 17, false);
#line 6 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml"
                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(189, 93, true);
            WriteLiteral("</li>\n        </ul>\n        <h3>Trail Length:</h3>\n        <ul>\n            <li class=\"lead\">");
            EndContext();
            BeginContext(283, 12, false);
#line 10 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml"
                        Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(295, 103, true);
            WriteLiteral(" Miles</li>\n        </ul>\n        <h3>Elevation Change:</h3>\n        <ul>\n            <li class=\"lead\">");
            EndContext();
            BeginContext(399, 15, false);
#line 14 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml"
                        Write(Model.Elevation);

#line default
#line hidden
            EndContext();
            BeginContext(414, 145, true);
            WriteLiteral(" feet</li>\n        </ul>\n        <div class=\"col-sm-5 col-sm-offset-7\">\n            <div class=\"row\">\n                <p class=\"lead\">Longitude: ");
            EndContext();
            BeginContext(560, 15, false);
#line 18 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml"
                                      Write(Model.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(575, 13, true);
            WriteLiteral(" | Latitude: ");
            EndContext();
            BeginContext(589, 14, false);
#line 18 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_jan_2019/cSharp/DojoTemplate/Views/Home/Show.cshtml"
                                                                   Write(Model.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(603, 93, true);
            WriteLiteral("</p>\n                <a href=\"/\">Home</a>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591