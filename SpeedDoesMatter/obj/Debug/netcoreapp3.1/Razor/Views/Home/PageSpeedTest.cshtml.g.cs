#pragma checksum "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4538f6256c7fb55a9028e76fb35daecdda985b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PageSpeedTest), @"mvc.1.0.view", @"/Views/Home/PageSpeedTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4538f6256c7fb55a9028e76fb35daecdda985b9", @"/Views/Home/PageSpeedTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2d7d04fac82f09bae9f773886e37c61f8045d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PageSpeedTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageSpeedTestModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
  
    ViewData["Title"] = "PageSpeedTest";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script");
            BeginWriteAttribute("src", " src=\"", 85, "\"", 158, 1);
#nullable restore
#line 6 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
WriteAttributeValue("", 91, Url.Content("~/lib/jquery-validation/dist/jquery.validate.min.js"), 91, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script");
            BeginWriteAttribute("src", " src=\"", 201, "\"", 293, 1);
#nullable restore
#line 7 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
WriteAttributeValue("", 207, Url.Content("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), 207, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n");
#nullable restore
#line 8 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
Write(Html.ValidationSummary(true, "Correct The Errors first."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
 using (Html.BeginForm("Index", "PageSpeedTest", FormMethod.Post))




{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    <label class=\"col-form-label col-form-label-lg\" for=\"inputLarge\" style=\"font-size: 2rem;\">How fast does your website load? Check it now!</label>\r\n    <br /><br />\r\n    ");
#nullable restore
#line 19 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
Write(Html.TextBoxFor(model => model.WebsiteURL, new { @id = "WebsiteURL", @class = "form-control form-control-lg", @type = "text", @placeholder = "Enter you web page URL" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 20 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
Write(Html.ValidationMessageFor(model => model.WebsiteURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
Write(Html.Raw(ViewBag.Response));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br /><br />\r\n    <input id=\"Submit\" type=\"submit\" class=\"btn btn-success btn-lg\" value=\"Go!\" />\r\n    <br /><br />\r\n</div>\r\n");
#nullable restore
#line 26 "/Users/omega/Documents/GitHub/SpeedDoesMatter/SpeedDoesMatter/Views/Home/PageSpeedTest.cshtml"
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
