#pragma checksum "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4ee8c441b8f5f559e373e1877622bf781cd0cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Users.cshtml", typeof(AspNetCore.Views_Account_Users))]
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
#line 1 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\_ViewImports.cshtml"
using eTicket;

#line default
#line hidden
#line 2 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#line 3 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\_ViewImports.cshtml"
using eTicket.Models;

#line default
#line hidden
#line 4 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\_ViewImports.cshtml"
using eTickets.Data.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4ee8c441b8f5f559e373e1877622bf781cd0cb", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878cd7ef26910cb7a6b150c981653ae33d1e19c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of Users";

#line default
#line hidden
            BeginContext(88, 266, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <p>
            <h4>List of All Users</h4>
                
        </p>


        <table class=""table"">
            <thead>
                <tr class=""text-left"">
                    <th>");
            EndContext();
            BeginContext(355, 44, false);
#line 18 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(399, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(431, 44, false);
#line 19 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(475, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(507, 41, false);
#line 20 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(548, 94, true);
            WriteLiteral("</th>\r\n                   \r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(707, 95, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td class=\"align-middle\">\r\n                        ");
            EndContext();
            BeginContext(803, 43, false);
#line 30 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(846, 102, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"align-middle\">\r\n                        ");
            EndContext();
            BeginContext(949, 43, false);
#line 34 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(992, 102, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"align-middle\">\r\n                        ");
            EndContext();
            BeginContext(1095, 40, false);
#line 38 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 58, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n\r\n                </tr>\r\n");
            EndContext();
#line 44 "C:\Users\lenovo\source\repos\eTickets\eTicket\Views\Account\Users.cshtml"
                }

#line default
#line hidden
            BeginContext(1212, 66, true);
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
