#pragma checksum "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6127e3cd178dd566a5960a19465b0ae027d2109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__DetialsItem), @"mvc.1.0.view", @"/Views/Home/_DetialsItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6127e3cd178dd566a5960a19465b0ae027d2109", @"/Views/Home/_DetialsItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__DetialsItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop_Gp.ViewModel.ItemsList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
  
    ViewBag.Title = "Detials Item";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 11 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
       Write(Html.DisplayNameFor(model => model.Item.NameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 15 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
       Write(Html.DisplayFor(model => model.Item.NameAr));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n        <dd>\r\n            <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 397, "\"", 433, 1);
#nullable restore
#line 18 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 403, Url.Content(Model.Item.Image), 403, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
       Write(Html.DisplayNameFor(model => model.Item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 25 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
       Write(Html.DisplayFor(model => model.Item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 29 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
       Write(Html.DisplayNameFor(model => model.Item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 33 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
       Write(Html.DisplayFor(model => model.Item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>

    </dl>
</div>

<div class=""DivFore"">
    <div class=""container"">
        <h2>منتجات قد تعجبك</h2>
        <div class=""carousel5"">
            <div class=""card"">
                <div class=""card-header"">
                    <img class=""pic-1""");
            BeginWriteAttribute("src", " src=\"", 1097, "\"", 1132, 1);
#nullable restore
#line 45 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 1103, Url.Content(Model.Slid.Img1), 1103, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-content\">\r\n                        <div class=\"card-title\">\r\n                            <p>\r\n                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 1386, "\"", 1472, 3);
            WriteAttributeValue("", 1396, "location.href=\'", 1396, 15, true);
#nullable restore
#line 51 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 1411, Url.Action("MoreDetials", "Home" , new {NameEn = "Phones"}), 1411, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1471, "\'", 1471, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a>");
#nullable restore
#line 52 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                  Write(Model.Slid.Name1);

#line default
#line hidden
#nullable disable
            WriteLiteral(").First()</a>\r\n                                </i>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <h1 class=\"text-lg-left\">السعر : ");
#nullable restore
#line 57 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                                        Write(Model.Slid.Price1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 2003, "\"", 2038, 1);
#nullable restore
#line 64 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 2009, Url.Content(Model.Slid.Img2), 2009, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-content\">\r\n                        <div class=\"card-title\">\r\n                            <p>\r\n                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 2292, "\"", 2378, 3);
            WriteAttributeValue("", 2302, "location.href=\'", 2302, 15, true);
#nullable restore
#line 70 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 2317, Url.Action("MoreDetials", "Home" , new {NameEn = "Phones"}), 2317, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2377, "\'", 2377, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a>");
#nullable restore
#line 71 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                  Write(Model.Slid.Name2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </i>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <h1 class=\"text-lg-left\">السعر : ");
#nullable restore
#line 76 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                                        Write(Model.Slid.Price2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 2902, "\"", 2937, 1);
#nullable restore
#line 84 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 2908, Url.Content(Model.Slid.Img3), 2908, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-content\">\r\n                        <div class=\"card-title\">\r\n                            <p>\r\n                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 3191, "\"", 3277, 3);
            WriteAttributeValue("", 3201, "location.href=\'", 3201, 15, true);
#nullable restore
#line 90 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 3216, Url.Action("MoreDetials", "Home" , new {NameEn = "Phones"}), 3216, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3276, "\'", 3276, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a>");
#nullable restore
#line 91 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                  Write(Model.Slid.Name3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </i>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <h1 class=\"text-lg-left\">السعر : ");
#nullable restore
#line 96 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                                        Write(Model.Slid.Price3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 3801, "\"", 3836, 1);
#nullable restore
#line 104 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 3807, Url.Content(Model.Slid.Img4), 3807, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-content\">\r\n                        <div class=\"card-title\">\r\n                            <p>\r\n                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 4090, "\"", 4176, 3);
            WriteAttributeValue("", 4100, "location.href=\'", 4100, 15, true);
#nullable restore
#line 110 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 4115, Url.Action("MoreDetials", "Home" , new {NameEn = "Phones"}), 4115, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4175, "\'", 4175, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a>");
#nullable restore
#line 111 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                  Write(Model.Slid.Name4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </i>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <h1 class=\"text-lg-left\">السعر : ");
#nullable restore
#line 116 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                                        Write(Model.Slid.Price4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 4700, "\"", 4735, 1);
#nullable restore
#line 124 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 4706, Url.Content(Model.Slid.Img5), 4706, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-content\">\r\n                        <div class=\"card-title\">\r\n                            <p>\r\n                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 4989, "\"", 5075, 3);
            WriteAttributeValue("", 4999, "location.href=\'", 4999, 15, true);
#nullable restore
#line 130 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 5014, Url.Action("MoreDetials", "Home" , new {NameEn = "Phones"}), 5014, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5074, "\'", 5074, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a>");
#nullable restore
#line 131 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                  Write(Model.Slid.Name5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </i>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <h1 class=\"text-lg-left\">السعر : ");
#nullable restore
#line 136 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                                        Write(Model.Slid.Price5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 5599, "\"", 5634, 1);
#nullable restore
#line 144 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 5605, Url.Content(Model.Slid.Img6), 5605, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-content\">\r\n                        <div class=\"card-title\">\r\n                            <p>\r\n                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 5888, "\"", 5974, 3);
            WriteAttributeValue("", 5898, "location.href=\'", 5898, 15, true);
#nullable restore
#line 150 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
WriteAttributeValue("", 5913, Url.Action("MoreDetials", "Home" , new {NameEn = "Phones"}), 5913, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5973, "\'", 5973, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a>");
#nullable restore
#line 151 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                  Write(Model.Slid.Name6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </i>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <h1 class=\"text-lg-left\">السعر : ");
#nullable restore
#line 156 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Home\_DetialsItem.cshtml"
                                                        Write(Model.Slid.Price6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
