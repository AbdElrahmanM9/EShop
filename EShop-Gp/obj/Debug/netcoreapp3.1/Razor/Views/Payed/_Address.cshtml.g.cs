#pragma checksum "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665966a2c316ba82211d12d41cdc6a7557224081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payed__Address), @"mvc.1.0.view", @"/Views/Payed/_Address.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665966a2c316ba82211d12d41cdc6a7557224081", @"/Views/Payed/_Address.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Payed__Address : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop_Gp.ViewModel.UserDataViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
  

    var FullName = Model.FullName != null ? Model.FullName : "";
    var PhoneNumber = Model.PhoneNumber != null ? Model.PhoneNumber : "";
    var Street = Model.Street != null ? Model.Street : "";
    var BuildingNameOrNum = Model.BuildingNameOrNum != null ? Model.BuildingNameOrNum : "";
    var CityAndArea = Model.CityAndArea != null ? Model.CityAndArea : "";
    var NearestToken = Model.NearestToken != null ? Model.NearestToken : "";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665966a2c316ba82211d12d41cdc6a75572240813762", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"Name\">الاسم بالكامل</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Name\" placeholder=\"Your Name\"");
                BeginWriteAttribute("value", " value=\"", 671, "\"", 688, 1);
#nullable restore
#line 15 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
WriteAttributeValue("", 679, FullName, 679, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <span id=""SName"" style=""display:none;"" class=""alert-danger"">required</span>
    </div>
    <div class=""form-group"">
        <label for=""PhoneNum"">رقم التلفون</label>
        <input type=""text"" class=""form-control"" id=""PhoneNum"" placeholder=""01011111569""");
                BeginWriteAttribute("value", " value=\"", 957, "\"", 977, 1);
#nullable restore
#line 20 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
WriteAttributeValue("", 965, PhoneNumber, 965, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <span id=""SPhoneNum"" style=""display:none;"" class=""alert-danger"">required</span>
    </div>
    <div class=""form-group"">
        <label for=""street"">اسم الشارع</label>
        <input type=""text"" class=""form-control"" id=""street"" placeholder=""شارع طلعت حرب""");
                BeginWriteAttribute("value", " value=\"", 1247, "\"", 1262, 1);
#nullable restore
#line 25 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
WriteAttributeValue("", 1255, Street, 1255, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <span id=""Sstreet"" style=""display:none;"" class=""alert-danger"">required</span>
    </div>
    <div class=""form-group"">
        <label for=""street"">اسم/رقم المبنى، رقم الطابق، رقم الشقة، أو رقم الفيلا</label>
        <input type=""text"" class=""form-control"" id=""BuildingNameOrNum""");
                BeginWriteAttribute("value", " value=\"", 1555, "\"", 1581, 1);
#nullable restore
#line 30 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
WriteAttributeValue("", 1563, BuildingNameOrNum, 1563, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""رقم المبنى والطابق والشقة (مبنى 25ب، الدور الثالث، شقة رقم 20"">
        <span id=""SBuildingNameOrNum"" style=""display:none;"" class=""alert-danger"">required</span>
    </div>
    <div class=""form-group"">
        <label for=""street"">المدينة/المنطقة</label>
        <input type=""text"" class=""form-control"" id=""CityAndArea""");
                BeginWriteAttribute("value", " value=\"", 1918, "\"", 1938, 1);
#nullable restore
#line 35 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
WriteAttributeValue("", 1926, CityAndArea, 1926, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""النزهة ، مدينة القاهرة الجديدة والدقي"">
        <span id=""SCityAndArea"" style=""display:none;"" class=""alert-danger"">required</span>
    </div>
    <div class=""form-group"">
        <label for=""street"">أقرب علامة مميزة</label>
        <input type=""text"" class=""form-control"" id=""NearestToken""");
                BeginWriteAttribute("value", " value=\"", 2247, "\"", 2268, 1);
#nullable restore
#line 40 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
WriteAttributeValue("", 2255, NearestToken, 2255, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""على سبيل المثال كايرو فيستيفال سيتي"">
        <span id=""SNearestToken"" style=""display:none;"" class=""alert-danger"">required</span>
    </div>
    <div class=""col-xs-4 col-md-4"">
        <button onclick=""SaveAddress()"" class=""subscribe btn btn-success btn-lg btn-block"" type=""button"" style=""text-align:center"">استخدم هذا  العنوان</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>
    function SaveAddress() {
        debugger;
        var counter = 0;
        if ($(""#Name"").val() == """") { $(""#SName"").show(); counter++; } else { $(""#SName"").hide(); }
        if ($(""#PhoneNum"").val() == """") { $(""#SPhoneNum"").show(); counter++; } else { $(""#SPhoneNum"").hide(); }
        if ($(""#street"").val() == """") { $(""#Sstreet"").show(); counter++; } else { $(""#Sstreet"").hide(); }
        if ($(""#BuildingNameOrNum"").val() == """") { $(""#SBuildingNameOrNum"").show(); counter++; } else { $(""#SBuildingNameOrNum"").hide(); }
        if ($(""#CityAndArea"").val() == """") { $(""#SCityAndArea"").show(); counter++; } else { $(""#SCityAndArea"").hide(); }
        if ($(""#NearestToken"").val() == """") { $(""#SNearestToken"").show(); counter++; } else { $(""#SNearestToken"").hide(); }

        if (counter == 0) {
        var UserData = {
            FullName: $(""#Name"").val()??"""",
            PhoneNumber: $(""#PhoneNum"").val()??"""",
            Street: $(""#street"").val()??"""",
            BuildingNameOr");
            WriteLiteral("Num: $(\"#BuildingNameOrNum\").val()??\"\",\r\n            CityAndArea: $(\"#CityAndArea\").val()??\"\",\r\n            NearestToken: $(\"#NearestToken\").val(),\r\n        }\r\n\r\n            $.ajax({\r\n                type: \'POST\',\r\n                url: \'");
#nullable restore
#line 72 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
                 Write(Url.Action("SaveAddress", "Payed"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                data: UserData,\r\n                dataType: \'json\',\r\n                success: function (data) {\r\n                    debugger;\r\n                    $.ajax({\r\n                        url: \'");
#nullable restore
#line 78 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Address.cshtml"
                         Write(Url.Action("_Payment", "Payed"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        type: 'get',
                        data: {

                        },
                        success: function (data) {
                            debugger;
                            cleartabs();
                            $('#Payment').addClass('active');
                            $('#PaymentTab').addClass('active');
                            $("".Payment"").removeClass('disabled');
                            //$("".Payment"").tab('show');
                            //$("".Payment"").removeClass();
                            $(""#PaymentTab"").html(data);
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                        debugger;
                        }
                    });
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    debugger;
                }
        });
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop_Gp.ViewModel.UserDataViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
