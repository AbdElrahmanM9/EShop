#pragma checksum "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c2d6ca30716ae8154ca0fd9138b041d0efcbd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SupplierRequests), @"mvc.1.0.view", @"/Views/Admin/SupplierRequests.cshtml")]
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
#line 1 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\_ViewImports.cshtml"
using EShop_Gp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\_ViewImports.cshtml"
using EShop_Gp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c2d6ca30716ae8154ca0fd9138b041d0efcbd2", @"/Views/Admin/SupplierRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SupplierRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop_Gp.ViewModel.ItemsList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
  
    ViewBag.Title = "Supplier Requests";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid padding\" id=\"RequestTablez\">\r\n    <div class=\"row padding\">\r\n");
#nullable restore
#line 9 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 col-sm-6\">\r\n                <div class=\"product-grid3\">\r\n                    <div class=\"product-image3\">\r\n                        <a href=\"#\"></a>\r\n                        <img style=\"width: 100%;\"");
            BeginWriteAttribute("src", " src=\"", 465, "\"", 495, 1);
#nullable restore
#line 15 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 471, Url.Content(item.Image), 471, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\">\r\n                        <h4 class=\"card-title\"><b>");
#nullable restore
#line 16 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
                                             Write(item.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 17 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <input type=\"button\" class=\"btn btn-primary btn-sm \"");
            BeginWriteAttribute("onclick", " onclick=\"", 722, "\"", 777, 7);
            WriteAttributeValue("", 732, "Save(", 732, 5, true);
#nullable restore
#line 19 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 737, item.Id, 737, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 745, ",\'", 745, 2, true);
#nullable restore
#line 19 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 747, item.NameAr, 747, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, "\',", 759, 2, true);
#nullable restore
#line 19 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 761, item.PriceCost, 761, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 776, ")", 776, 1, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Save\" />\r\n                        <input type=\"button\" class=\"btn btn-primary btn-sm \"");
            BeginWriteAttribute("onclick", " onclick=\"", 872, "\"", 929, 7);
            WriteAttributeValue("", 882, "Delete(", 882, 7, true);
#nullable restore
#line 20 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 889, item.Id, 889, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 897, ",\'", 897, 2, true);
#nullable restore
#line 20 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 899, item.NameAr, 899, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 911, "\',", 911, 2, true);
#nullable restore
#line 20 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
WriteAttributeValue("", 913, item.PriceCost, 913, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 928, ")", 928, 1, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Delete\" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<script>\r\n    function Save(Id, NameAr, PriceCost) {\r\n        debugger;\r\n        var Items = {\r\n            Id: Id,\r\n            NameAr: NameAr,\r\n            PriceCost: PriceCost,\r\n        }\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 37 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
             Write(Url.Action("SaveRequest", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
                Items: Items,
            },
            type: 'post',
            success: function (data) {
                debugger;
                $(""#RequestTablez"").html("""");
                $(""#RequestTablez"").html(data);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) { }
        });
    }
    function Delete(Id, NameAr, PriceCost) {
        debugger;
        var Items = {
            Id: Id,
            NameAr: NameAr,
            PriceCost: PriceCost,
        }
        $.ajax({
            url: '");
#nullable restore
#line 58 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Admin\SupplierRequests.cshtml"
             Write(Url.Action("DeleteRequest", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
                Id: Id,
                Items: Items,
            },
            type: 'post',
            success: function (data) {
                debugger;
                $(""#RequestTablez"").html("""");
                $(""#RequestTablez"").html(data);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) { }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop_Gp.ViewModel.ItemsList> Html { get; private set; }
    }
}
#pragma warning restore 1591
