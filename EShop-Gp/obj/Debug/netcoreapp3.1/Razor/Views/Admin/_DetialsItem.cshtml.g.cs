#pragma checksum "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb5de2dc0804fcd3f5664710a280091d9e52c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__DetialsItem), @"mvc.1.0.view", @"/Views/Admin/_DetialsItem.cshtml")]
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
#line 1 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\_ViewImports.cshtml"
using EShop_Gp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\_ViewImports.cshtml"
using EShop_Gp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb5de2dc0804fcd3f5664710a280091d9e52c8d", @"/Views/Admin/_DetialsItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__DetialsItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop_Gp.Models.Items>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
  
    ViewBag.Title = "Detials Item";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 11 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
       Write(Html.DisplayNameFor(model => model.NameAr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 15 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
       Write(Html.DisplayFor(model => model.NameAr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd>\r\n            <img style=\"height:200px; width:200px;\"");
            BeginWriteAttribute("src", " src=\"", 401, "\"", 432, 1);
#nullable restore
#line 18 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
WriteAttributeValue("", 407, Url.Content(Model.Image), 407, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Sample Image\" />\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 25 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 29 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 33 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-outline-secondary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 914, "\"", 993, 3);
            WriteAttributeValue("", 924, "location.href=\'", 924, 15, true);
#nullable restore
#line 39 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
WriteAttributeValue("", 939, Url.Action("Update", "Admin", new { id = Model.Id }), 939, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 992, "\'", 992, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Update</button> |\r\n    <button type=\"button\" class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1069, "\"", 1148, 3);
            WriteAttributeValue("", 1079, "location.href=\'", 1079, 15, true);
#nullable restore
#line 40 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\_DetialsItem.cshtml"
WriteAttributeValue("", 1094, Url.Action("Delete", "Admin", new { id = Model.Id }), 1094, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1147, "\'", 1147, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop_Gp.Models.Items> Html { get; private set; }
    }
}
#pragma warning restore 1591
