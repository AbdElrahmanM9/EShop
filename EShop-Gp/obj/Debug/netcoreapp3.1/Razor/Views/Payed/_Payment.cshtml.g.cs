#pragma checksum "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15a7a6d38570c9ab529deb9b5ae1b07086dac0ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payed__Payment), @"mvc.1.0.view", @"/Views/Payed/_Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a7a6d38570c9ab529deb9b5ae1b07086dac0ba", @"/Views/Payed/_Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Payed__Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-6"">
        <p id=""menu"" class=""nav-link"" data-toggle=""modal"" data-target=""#menu-Model"" href=""#"">
            (paypal) ادفع عن طريق
            <a id=""#paypal-button""></a>
        </p>
    </div>
    <div class=""col-lg-6"">
        <p id=""menu"" class=""nav-link"" data-toggle=""modal"" data-target=""#menu-Model"" href=""#"">
            أضف بطاقة الائتمان أو الخصم
            <a class=""fa-brands fa-cc-visa"" style=""width:100%""></a>
        </p>
    </div>

</div>
<hr />
<div class=""input-group-prepend"">
    <div class=""row"">
        <div class=""col-12 my-0"">
            <h3 class=""form-check-label"">
                الدفع عند الاستلام
                <input class=""request_input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios1"" value=""option1"" spellcheck=""false"" orderId=""true"">
            </h3>
            <p class=""form-check-label my-2"">
                .الدفع نقدًا عند الاستلام. قد يتم تطبيق رسوم قدرها 9 جنيه مصري مقابل الدفع عند الاستلام
       ");
            WriteLiteral(@"     </p>
        </div>
        <div class=""col-xs-4 col-md-4 my-5"">
            <button onclick=""FinallyPaid()"" class=""subscribe btn btn-success btn-lg btn-block"" type=""button"">ادفع</button>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""menu-Model"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-contentV2"" id=""modal-contentV2"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12 col-md-12"">
                        <div class=""panel panel-default"">
                            <div class=""modal-header"" style=""background-color:rgba(0,0,0,0.075)"">
                                <h5 class=""modal-title"" id=""exampleModalLabel"">
                                    ادفع بالبطاقة
                                </h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" id=""closeMo");
            WriteLiteral("\">\r\n                                    <span aria-hidden=\"true\">&times;</span>\r\n                                </button>\r\n                            </div>\r\n                            <div class=\"panel-body\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15a7a6d38570c9ab529deb9b5ae1b07086dac0ba6991", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-xs-12"" style="" padding-right: 15px; padding-left: 15px;"">
                                            <div class=""form-group my-2"">
                                                <label for=""cardNumber"">رقم البطاقة</label>
                                                <div class=""input-group"">
                                                    <input type=""tel""
                                                           class=""form-control""
                                                           name=""CardNumber""
                                                           id=""CardNumber""
                                                           placeholder=""Valid Card Number""
                                                           autocomplete=""cc-number""
                                                           required autofocus />
                                            ");
                WriteLiteral(@"        <span class=""input-group-addon"" style=""padding-left: 15px; padding-top:7px"">
                                                        <i class=""fa fa-credit-card""></i>
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-xs-7 col-md-7"">
                                            <div class=""form-group"">
                                                <label for=""cardExpiry"">
                                                    <span class=""hidden-xs"">
                                                        تاريخ انتهاء الصلاحية
                                                    </span>
                                                </label>
                                      ");
                WriteLiteral(@"          <input type=""tel""
                                                       class=""form-control""
                                                       name=""ExpirationDate""
                                                       id=""ExpirationDate""
                                                       placeholder=""MM / YY""
                                                       autocomplete=""cc-exp""
                                                       required />
                                            </div>
                                        </div>
                                        <div class=""col-xs-5 col-md-5 pull-right"">
                                            <div class=""form-group"">
                                                <label for=""cardCVC"">الاسم علي البطاقة</label>
                                                <input type=""tel""
                                                       class=""form-control""
                                              ");
                WriteLiteral(@"         name=""NameOnTheCard""
                                                       id=""NameOnTheCard""
                                                       placeholder=""CVC""
                                                       autocomplete=""cc-csc""
                                                       required />
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row my-2"">
                                        <div class=""col-xs-8 col-lg-8"">
                                            <button class=""subscribe btn btn-success btn-lg btn-block"" type=""button"" onclick=""AddToCard()"">إضافة الي بطاقتك</button>
                                        </div>
                                        <div class=""col-xs-4 col-lg-4"">
                                            <button class=""subscribe btn btn-light btn-lg btn-block "" type=""button"" data-dismiss=""moda");
                WriteLiteral(@"l"" aria-label=""Close"">
                                                إلغاء
                                                <span aria-hidden=""true""></span>
                                            </button>
                                        </div>
                                    </div>
                                    <div class=""row"" style=""display:none;"">
                                        <div class=""col-xs-12"">
                                            <p class=""payment-errors""></p>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>


<script>
    function FinallyPaid() {
        debugger;
        var IsCash = false;
        var ctr = 0;
        $('.request_input').each(function (index) {
            if ($(this).is("":checked"")) {
                ctr++;
            }
        });
        if (ctr > 0) {
            IsCash = true;
        }
        debugger;
        $.ajax({
            url: '");
#nullable restore
#line 145 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Payment.cshtml"
             Write(Url.Action("FinallyPaid", "Payed"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: {\r\n                Cash: IsCash,\r\n            },\r\n            success: function (data) {\r\n                debugger;\r\n                if (data == \"CashDone\") {\r\n                    $.ajax({\r\n                        url: \'");
#nullable restore
#line 153 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Payment.cshtml"
                         Write(Url.Action("_GoodsAndShipping", "Payed"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        type: 'get',
                        data: {},
                        success: function (data) {
                            debugger;
                            cleartabs();
                            $('#GoodsAndShippingTab').addClass('active');
                            $('#GoodsAndShippingTab').addClass('active');
                            $("".GoodsAndShipping"").removeClass('disabled');
                            $(""#GoodsAndShippingTab"").html(data);
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                        debugger;
                        }
                    });
                }
                else if (data == ""CreditDone"") {
                    $.ajax({
                        url: '");
#nullable restore
#line 171 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Payment.cshtml"
                         Write(Url.Action("_GoodsAndShipping", "Payed"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        type: 'get',
                        data: {},
                        success: function (data) {
                            debugger;
                            cleartabs();
                            $('#GoodsAndShippingTab').addClass('active');
                            $('#GoodsAndShippingTab').addClass('active');
                            $("".GoodsAndShipping"").removeClass('disabled');
                            $(""#GoodsAndShippingTab"").html(data);
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                        debugger;
                        }
                    });
                }
                else if (data == ""ChoosePaymentMethod"") {
                    toastr.message('برجاء اختيار طريقة سداد', 'error', 3000);
                }
                else {
                    toastr.message('برجاء مراجعة مستويات الصلاحية', 'error', 3000);
                }
            },
");
            WriteLiteral(@"            error: function (XMLHttpRequest, textStatus, errorThrown) {
                debugger;
            }
        });

    }

    function AddToCard() {
        debugger;
        var CardNumber = $(""#CardNumber"").val();
        var ExpirationDate = $(""#ExpirationDate"").val();
        var NameOnTheCard = $(""#NameOnTheCard"").val();
        $.ajax({
            url: '");
#nullable restore
#line 207 "D:\ASP.NET\Projects\EShop\EShop-Gp\Views\Payed\_Payment.cshtml"
             Write(Url.Action("AddToCard", "Payed"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'get',
            data: {
                CardNumber: CardNumber,
                ExpirationDate: ExpirationDate,
                NameOnTheCard: NameOnTheCard
            },
            success: function (data) {
                debugger;
                if (data == ""Error"") {
                    toastr.message('يوجد مشكلة في هذه البطاقة', 'error', 3000);
                }
                else {
                    $("".close"").click();
                    $("".modal-backdrop"").remove();
                    $("".Payment"").tab('show');
                    $(""#Payment"").html(data);

                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                debugger;
            }
        });

    }

    paypal.Button.render({
        // Configure environment
        env: 'sandbox',
        client: {
            sandbox: 'ATHL135HGWmxmQR3_ydH_Wl0eC-yoDTjfclYTQZsoQK2VDCazqt2g2b1TIeRn1MY4FHzWkxG3XiVAX7q',
            p");
            WriteLiteral(@"roduction: 'demo_production_client_id'
        },
        // Customize button (optional)
        locale: 'en_US',
        style: {
            size: 'small',
            color: 'gold',
            shape: 'pill',
        },

        // Enable Pay Now checkout flow (optional)
        commit: true,

        // Set up a payment
        payment: function (data, actions) {
            return actions.payment.create({
                transactions: [{
                    amount: {
                        total: '0.01',
                        currency: 'USD'
                    }
                }]
            });
        },
        // Execute the payment
        onAuthorize: function (data, actions) {
            return actions.payment.execute().then(function () {
                // Show a confirmation message to the buyer
                window.alert('Thank you for your purchase!');
            });
        }
    }, '#paypal-button');

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
