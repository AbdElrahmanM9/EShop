#pragma checksum "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8cb6e5605ef86fd368b6d73f6891555f83047fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Register), @"mvc.1.0.razor-page", @"/Views/Register/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cb6e5605ef86fd368b6d73f6891555f83047fb", @"/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc79e141d2b9222a5e56d7e10704f4cafdf4d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Login/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html>

<style>

    * {
        box-sizing: border-box;
        margin: 0;
        padding: 0;
        font-family: Raleway, sans-serif;
    }

    body {
        background: linear-gradient(90deg, #dcdceb, #152aa1);
    }

    .container {
        display: flex;
        align-items: center;
        justify-content: center;
        min-height: 100vh;
    }

    .screen {
        background: linear-gradient(90deg, #dcdceb, #122fcf);
        position: relative;
        height: 690px;
        width: 360px;
        box-shadow: 0px 0px 24px #5C5696;
    }

    .screen__content {
        z-index: 1;
        position: relative;
        height: 100%;
    }

    .screen__background {
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        z-index: 0;
        clip-path: inset(0 0 0 0);
    }

    .screen__background__shape {
        transform: rotate(45deg);
        position: absolute;
    }

    .screen__back");
            WriteLiteral(@"ground__shape1 {
        height: 520px;
        width: 520px;
        background: #FFF;
        top: -50px;
        right: 120px;
        border-radius: 0 72px 0 0;
    }

    .screen__background__shape2 {
        height: 220px;
        width: 220px;
        background: #6C63AC;
        top: -172px;
        right: 0;
        border-radius: 32px;
    }

    .screen__background__shape3 {
        height: 540px;
        width: 190px;
        background: linear-gradient(90deg, #dcdceb, #122fcf);
        top: -24px;
        right: 0;
        border-radius: 32px;
    }

    .screen__background__shape4 {
        height: 400px;
        width: 200px;
        background: #7E7BB9;
        top: 420px;
        right: 50px;
        border-radius: 60px;
    }

    .login {
        width: 320px;
        padding: 30px;
        padding-top: 156px;
    }

    .login__field {
        padding: 20px 0px;
        position: relative;
        top: -100px;
    }

    .login__icon {
     ");
            WriteLiteral(@"   position: absolute;
        top: 30px;
        color: #7875B5;
    }

    .login__input {
        border: none;
        border-bottom: 2px solid #D1D1D4;
        background: none;
        padding: 10px;
        padding-left: 24px;
        font-weight: 700;
        width: 75%;
        transition: .2s;
    }

        .login__input:active,
        .login__input:focus,
        .login__input:hover {
            outline: none;
            border-bottom-color: #6A679E;
        }

    .login__submit {
        background: #fff;
        font-size: 14px;
        margin-top: -70px;
        padding: 16px 20px;
        border-radius: 26px;
        border: 1px solid #D4D3E8;
        text-transform: uppercase;
        font-weight: 700;
        display: flex;
        align-items: center;
        width: 100%;
        color: #4C489D;
        box-shadow: 0px 2px 2px #5C5696;
        cursor: pointer;
        transition: .2s;
    }

        .login__submit:active,
        .login__submit:");
            WriteLiteral(@"focus,
        .login__submit:hover {
            border-color: #6A679E;
            outline: none;
        }

    .button__icon {
        font-size: 24px;
        margin-left: auto;
        color: #7875B5;
    }

    .social-login {
        position: absolute;
        height: 140px;
        width: 160px;
        text-align: center;
        bottom: -69px;
        right: 0px;
        color: #fff;
    }




        .social-login a {
            color: #FFF;
        }
</style>

<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb6e5605ef86fd368b6d73f6891555f83047fb7567", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Register</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb6e5605ef86fd368b6d73f6891555f83047fb8633", async() => {
                WriteLiteral(@"

    <div class=""container"">
        <div class=""screen"">
            <div class=""screen__content"">
                <div class=""row justify-content-md-center login"">
                    <div class=""col-md-4"">
                        <div class=""card"">
                            <div class=""card-body"">
");
#nullable restore
#line 193 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                 using (Html.BeginForm("Register", "Register", FormMethod.Post))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"login__field\">\r\n                                        ");
#nullable restore
#line 197 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.TextBoxFor(m => m.username, "", new { @class = "login__input", @placeholder = "User name", @Id = "UserName" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 198 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"login__field\">\r\n                                        ");
#nullable restore
#line 201 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.TextBoxFor(m => m.Email, "", new { @class = "login__input", @placeholder = "Email", @Id = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 202 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n                                    <div class=\"login__field\">\r\n                                        ");
#nullable restore
#line 206 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.TextBoxFor(m => m.Password, new { @class = "login__input", @placeholder = "Password", @type = "password", @Id = "password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 207 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"login__field\">\r\n                                        ");
#nullable restore
#line 210 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.TextBoxFor(m => m.ConfirmPassword, new { @class = "login__input", @placeholder = "Repeat Password", @type = "password", @Id = "password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 211 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"login__field\">\r\n                                        ");
#nullable restore
#line 214 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.TextBoxFor(m => m.Phonenumber, new { @class = "login__input", @placeholder = "Phone Number", @type = "Phonenumber", @Id = "Phonenumber" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 215 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Phonenumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 217 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                     if (ViewBag.Error != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"login__field\">\r\n                                            <p style=\"color:red\">");
#nullable restore
#line 220 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                                            Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n");
#nullable restore
#line 222 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"form-group\">\r\n                                        <input type=\"submit\" name=\"submit\" class=\"button login__submit\" value=\"Login\" />\r\n                                    </div>\r\n");
#nullable restore
#line 226 "G:\AbdElrahman\Project\EShop-Gp\EShop-Gp\Views\Register\Register.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class=""social-login"">
                    <h4>Already Member?</h4>
                    <br />
                    <h3>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb6e5605ef86fd368b6d73f6891555f83047fb15950", async() => {
                    WriteLiteral(" Login ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    </h3>
                </div>
            </div>
            <div class=""screen__background"">
                <span class=""screen__background__shape screen__background__shape4""></span>
                <span class=""screen__background__shape screen__background__shape3""></span>
                <span class=""screen__background__shape screen__background__shape2""></span>
                <span class=""screen__background__shape screen__background__shape1""></span>
            </div>
        </div>
    </div>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop_Gp.Models.RegisterViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EShop_Gp.Models.RegisterViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EShop_Gp.Models.RegisterViewModel>)PageContext?.ViewData;
        public EShop_Gp.Models.RegisterViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
