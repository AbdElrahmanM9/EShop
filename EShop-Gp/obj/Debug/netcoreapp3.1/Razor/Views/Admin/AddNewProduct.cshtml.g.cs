#pragma checksum "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf40dc8640595fa60ace509c0d47e2f780c60d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddNewProduct), @"mvc.1.0.view", @"/Views/Admin/AddNewProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf40dc8640595fa60ace509c0d47e2f780c60d2", @"/Views/Admin/AddNewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddNewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop_Gp.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
  
    ViewBag.Title = "Add New Product";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Add New Product</h2>\r\n\r\n\r\n");
#nullable restore
#line 11 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
 using (Html.BeginForm("AddNewProduct", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
#nullable restore
#line 18 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 20 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
       Write(Html.LabelFor(model => model.NameAr, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 22 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.EditorFor(model => model.NameAr, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.NameAr, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 28 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
       Write(Html.LabelFor(model => model.NameEn, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 30 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.EditorFor(model => model.NameEn, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.NameEn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 36 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
       Write(Html.LabelFor(model => model.Image, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <input type=\"file\" name=\"upload\" class=\"control-label col-md-4 subscribe btn btn-light btn-lg btn-block\" />\r\n                ");
#nullable restore
#line 39 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Image, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 44 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 46 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 47 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 52 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
       Write(Html.LabelFor(model => model.categoryid, "Categoryid", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n");
#nullable restore
#line 54 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
                 if (ViewBag.Categoryid != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
               Write(Html.DropDownList("Categoryid", ViewBag.Categoryid,"Select Category", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.categoryid, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
                                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 67 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Admin\AddNewProduct.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop_Gp.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
