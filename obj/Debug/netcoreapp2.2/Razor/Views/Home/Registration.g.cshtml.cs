#pragma checksum "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cabc291f428716bb6addddde324b15071c9a86a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registration.cshtml", typeof(AspNetCore.Views_Home_Registration))]
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
#line 1 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\_ViewImports.cshtml"
using Lab18CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\_ViewImports.cshtml"
using Lab18CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cabc291f428716bb6addddde324b15071c9a86a8", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe600a813aeb241e28f2cba4f76963bde4e3ff07", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18CoffeeShop.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
            BeginContext(50, 48, true);
            WriteLiteral("\r\n<h1>Please Register Down Below </h1>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
 using (var form = Html.BeginForm())
 {

#line default
#line hidden
            BeginContext(186, 21, true);
            WriteLiteral("    <div>\r\n\r\n        ");
            EndContext();
            BeginContext(208, 30, false);
#line 17 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(238, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(249, 90, false);
#line 18 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-input", placeholder = "User Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(339, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(355, 21, true);
            WriteLiteral("    <div>\r\n\r\n        ");
            EndContext();
            BeginContext(377, 27, false);
#line 23 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(404, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(415, 83, false);
#line 24 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-input", placeholder = "Email" }));

#line default
#line hidden
            EndContext();
            BeginContext(498, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(518, 21, true);
            WriteLiteral("    <div>\r\n\r\n        ");
            EndContext();
            BeginContext(540, 30, false);
#line 31 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(570, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(581, 90, false);
#line 32 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
   Write(Html.PasswordFor(m => m.Password, new { @class = "form-input", placeholder = "Password" }));

#line default
#line hidden
            EndContext();
            BeginContext(671, 25, true);
            WriteLiteral("\r\n       \r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(700, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 39 "C:\Users\achia\OneDrive\Desktop\LabsWeekFive\Lab18CoffeeShop\Views\Home\Registration.cshtml"
 }

#line default
#line hidden
            BeginContext(748, 213, true);
            WriteLiteral("\r\n<style>\r\n    body\r\n    {\r\n        background-image:url(https://www.sciencenews.org/sites/default/files/main/articles/100315_coffee_opener_NEW_0.jpg);\r\n            background-size:cover;\r\n       \r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18CoffeeShop.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
