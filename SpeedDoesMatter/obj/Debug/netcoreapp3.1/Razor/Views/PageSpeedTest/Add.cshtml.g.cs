#pragma checksum "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/PageSpeedTest/Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae0f87afc42f7eb6a138e21199a7588c10e92d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PageSpeedTest_Add), @"mvc.1.0.view", @"/Views/PageSpeedTest/Add.cshtml")]
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
#line 1 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/_ViewImports.cshtml"
using SpeedDoesMatter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/_ViewImports.cshtml"
using SpeedDoesMatter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/_ViewImports.cshtml"
using SpeedDoesMatter.Models.PageSpeedTest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae0f87afc42f7eb6a138e21199a7588c10e92d6", @"/Views/PageSpeedTest/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2d7d04fac82f09bae9f773886e37c61f8045d5", @"/Views/_ViewImports.cshtml")]
    public class Views_PageSpeedTest_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageSpeedTestModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Add WebsiteURL</h1>\r\n\r\n");
#nullable restore
#line 5 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/PageSpeedTest/Add.cshtml"
 using (Html.BeginForm("Add", "WebsiteURL", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 8 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/PageSpeedTest/Add.cshtml"
   Write(Html.LabelFor(model => model.WebsiteURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/PageSpeedTest/Add.cshtml"
   Write(Html.TextBoxFor(model => model.WebsiteURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 10 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/PageSpeedTest/Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.WebsiteURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Add Website</button>\r\n");
#nullable restore
#line 14 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/PageSpeedTest/Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageSpeedTestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
