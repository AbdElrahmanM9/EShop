#pragma checksum "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e25d1986c21ec35686ea75373a40a2906b6bb339"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__UsersPage), @"mvc.1.0.view", @"/Views/Admin/_UsersPage.cshtml")]
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
#line 1 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\_ViewImports.cshtml"
using EShop_Gp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\_ViewImports.cshtml"
using EShop_Gp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25d1986c21ec35686ea75373a40a2906b6bb339", @"/Views/Admin/_UsersPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__UsersPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EShop_Gp.ViewModel.UserViewModel>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
  
    ViewBag.Title = "Admin Users Data";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25d1986c21ec35686ea75373a40a2906b6bb3393516", async() => {
                WriteLiteral(@"
    <style>
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }
/*        tr:hover {
            background-color: rgba(150, 212, 212, 0.4);
        }*/
        tr:nth-child(even) {
            background-color: rgba(150, 212, 212, 0.4);
        }

        th:nth-child(even), td:nth-child(even) {
            background-color: rgba(150, 212, 212, 0.4);
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25d1986c21ec35686ea75373a40a2906b6bb3394932", async() => {
                WriteLiteral("\r\n\r\n    <table style=\"width:100%\">\r\n        <tr>\r\n            <th>User Name</th>\r\n            <th>Email</th>\r\n            <th>User Phone Number</th>\r\n            <th>Type</th>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
               Write(item.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
               Write(item.UserPhoneNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
               Write(item.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Admin\_UsersPage.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EShop_Gp.ViewModel.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
