#pragma checksum "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c882fdfd4abd1c270efc003cea097361ab3ffab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_MyProductApproval), @"mvc.1.0.view", @"/Views/Supplier/MyProductApproval.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c882fdfd4abd1c270efc003cea097361ab3ffab", @"/Views/Supplier/MyProductApproval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_MyProductApproval : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop_Gp.ViewModel.PopUp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml"
  
    ViewBag.Title = "Supplier Home";
    Layout = "~/Views/Shared/_LayoutSupplier.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid padding\">\r\n    <div class=\"row padding\">\r\n");
#nullable restore
#line 10 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 col-sm-6\">\r\n                <div class=\"product-grid3\">\r\n                    <div class=\"product-image3\">\r\n                        <a href=\"#\">\r\n                            <img style=\"width: 100%;\"");
            BeginWriteAttribute("src", " src=\"", 493, "\"", 523, 1);
#nullable restore
#line 16 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml"
WriteAttributeValue("", 499, Url.Content(item.Image), 499, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\">\r\n                            <h4 class=\"card-title\"><b>");
#nullable restore
#line 17 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml"
                                                 Write(item.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\AYA\source\repos\EShop\EShop-Gp\Views\Supplier\MyProductApproval.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop_Gp.ViewModel.PopUp> Html { get; private set; }
    }
}
#pragma warning restore 1591
