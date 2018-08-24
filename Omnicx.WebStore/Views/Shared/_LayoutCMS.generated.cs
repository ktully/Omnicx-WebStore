﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    
    #line 18 "..\..\Views\Shared\_LayoutCMS.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Shared\_LayoutCMS.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 19 "..\..\Views\Shared\_LayoutCMS.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Shared\_LayoutCMS.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LayoutCMS.cshtml")]
    public partial class _Views_Shared__LayoutCMS_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared__LayoutCMS_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_LayoutCMS.cshtml"
  
/*
    Name: Fluid Layout
    Purpose: CMS Layout for using Full with for the screen
    Structure: /Views/Shared/_LayoutCMS.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_LayoutHeadTag.cshtml
        b-/Views/Shared/_LayoutHeader.cshtml
        c-/Views/Shared/_SearchBox.cshtml
        d-/Views/Shared/_LayoutFooter.cshtml

    Contained In (Where we Use this View):
        a-/Views/Page/DynamicPage.cshtml
        b-/Views/Page/Index.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n");

WriteLiteral("<html");

WriteLiteral(" ng-app=\"btApp\"");

WriteLiteral(" ng-controller=\"globalCtrl as gm\"");

WriteLiteral(" id=\"sidebarFix\"");

WriteLiteral(">\r\n\r\n");

            
            #line 26 "..\..\Views\Shared\_LayoutCMS.cshtml"
Write(Html.Partial("~/Views/Shared/_LayoutHeadTag.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<body>\r\n");

WriteLiteral("    ");

            
            #line 28 "..\..\Views\Shared\_LayoutCMS.cshtml"
Write(Html.GetGlobalSnipptes(SnippetPlacements.BodyStartHtmlTagAfter));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 29 "..\..\Views\Shared\_LayoutCMS.cshtml"
Write(RenderSection("siteheader", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <header");

WriteLiteral(" class=\"siteHeader\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 31 "..\..\Views\Shared\_LayoutCMS.cshtml"
   Write(Html.Partial("~/Views/Shared/_LayoutHeader.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" id=\"all\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"container-min clearfix\"");

WriteLiteral(">               \r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\Views\Shared\_LayoutCMS.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..\Views\Shared\_LayoutCMS.cshtml"
           Write(Html.GetGlobalSnipptes(SnippetPlacements.PageContainerAfter));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 39 "..\..\Views\Shared\_LayoutCMS.cshtml"
        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Shared\_LayoutCMS.cshtml"
          /*Search popup for Mobile View*/
            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"modal fade in\"");

WriteLiteral(" id=\"globalSearch\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-dialog modal-xl\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"modal-header text-center\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1835), Tuple.Create("\"", 1881)
, Tuple.Create(Tuple.Create("", 1841), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/logo-small.png")
, 1841), false)
);

WriteLiteral(" alt=\"OCX Store logo\"");

WriteLiteral(" style=\"margin-top: -10px; margin-left: 15px;\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Shared\_LayoutCMS.cshtml"
                                                                                                                                                                    Write(LT("Header.Text.GoHome", "OCX Store - go to homepage"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close search-close-btn\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Shared\_LayoutCMS.cshtml"
                                                                                                                                                    Write(LT("Checkout.Button.Close", "Close"));

            
            #line default
            #line hidden
WriteLiteral("</span></button>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"modal-body no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 51 "..\..\Views\Shared\_LayoutCMS.cshtml"
                       Write(Html.Partial("~/Views/Shared/_SearchBox.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n        </div>            \r\n" +
"    </header>\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"dvloader\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"global-loader\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2804), Tuple.Create("\"", 2846)
, Tuple.Create(Tuple.Create("", 2810), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/loader.svg")
, 2810), false)
);

WriteLiteral(" />\r\n        </span>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 65 "..\..\Views\Shared\_LayoutCMS.cshtml"
Write(Html.Partial("~/Views/Shared/_LayoutFooter.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("   \r\n");

DefineSection("scripts", () => {

            
            #line 66 "..\..\Views\Shared\_LayoutCMS.cshtml"
    
            
            #line default
            #line hidden
});

WriteLiteral("    ");

            
            #line 67 "..\..\Views\Shared\_LayoutCMS.cshtml"
      
        var pcaAccessCode = "";
        if (SessionContext.CurrentSiteConfig != null && SessionContext.CurrentSiteConfig.GeoLocators != null)
        {
            var pca = SessionContext.CurrentSiteConfig.GeoLocators.FirstOrDefault(x => x.PluginCode == Omnicx.WebStore.Models.Enums.GeoLocatorPlugin.PCA.ToString());
            if (pca != null)
            {
                pcaAccessCode = pca.AccessKey;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("        <script>\r\n            var pcaAccessCode = \"");

            
            #line 78 "..\..\Views\Shared\_LayoutCMS.cshtml"
                            Write(pcaAccessCode);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n        </script>\r\n");

            
            #line 80 "..\..\Views\Shared\_LayoutCMS.cshtml"
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("    ");

            
            #line 82 "..\..\Views\Shared\_LayoutCMS.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    <script>\r\n\r\n        var setContactForm = \'");

            
            #line 86 "..\..\Views\Shared\_LayoutCMS.cshtml"
                          Write(Html.BuildUrlFromExpression<CommonController>(c => c.ContactForm(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getBasketUrl = \'");

            
            #line 87 "..\..\Views\Shared\_LayoutCMS.cshtml"
                        Write(Html.BuildUrlFromExpression<BasketController>(c => c.GetBasketData()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToBasket = \'");

            
            #line 88 "..\..\Views\Shared\_LayoutCMS.cshtml"
                       Write(Html.BuildUrlFromExpression<BasketController>(c => c.AddtoBasket(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var signIn = \'");

            
            #line 89 "..\..\Views\Shared\_LayoutCMS.cshtml"
                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var register = \'");

            
            #line 90 "..\..\Views\Shared\_LayoutCMS.cshtml"
                    Write(Html.BuildUrlFromExpression<AccountController>(c => c.Registration(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getShippingMethods = \'");

            
            #line 91 "..\..\Views\Shared\_LayoutCMS.cshtml"
                              Write(Html.BuildUrlFromExpression<BasketController>(c => c.GetShippingMethods("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var updateShipping = \'");

            
            #line 92 "..\..\Views\Shared\_LayoutCMS.cshtml"
                          Write(Html.BuildUrlFromExpression<BasketController>(c => c.UpdateShipping(null,null,null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var applyPromoCode = \'");

            
            #line 93 "..\..\Views\Shared\_LayoutCMS.cshtml"
                          Write(Html.BuildUrlFromExpression<BasketController>(c => c.ApplyPromoCode(null,null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var currencySettingUrl = \'");

            
            #line 94 "..\..\Views\Shared\_LayoutCMS.cshtml"
                              Write(Html.BuildUrlFromExpression<HomeController>(c => c.UpdateCurrencySetting()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var paymentMethodsUrl = \'");

            
            #line 95 "..\..\Views\Shared\_LayoutCMS.cshtml"
                             Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GetPaymentMethods()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var newsLetterSubscription = \'");

            
            #line 96 "..\..\Views\Shared\_LayoutCMS.cshtml"
                                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.NewsletterSubscription(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var removePromoCode = \'");

            
            #line 97 "..\..\Views\Shared\_LayoutCMS.cshtml"
                           Write(Html.BuildUrlFromExpression<BasketController>(c => c.RemovePromoCode("","")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var forgotPassword = \'");

            
            #line 98 "..\..\Views\Shared\_LayoutCMS.cshtml"
                          Write(Html.BuildUrlFromExpression<AccountController>(c => c.ForgotPassword(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var bulkAddproduct = \'");

            
            #line 99 "..\..\Views\Shared\_LayoutCMS.cshtml"
                          Write(Html.BuildUrlFromExpression<BasketController>(c=> c.BulkAddProduct(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getDefaultCountryUrl = \'");

            
            #line 100 "..\..\Views\Shared\_LayoutCMS.cshtml"
                                Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetDefaultCountry()));

            
            #line default
            #line hidden
WriteLiteral(@"';
        window.app.constant('globalConfig', {
            setContactForm: setContactForm,
            getBasketUrl: getBasketUrl,
            addToBasket: addToBasket,
            signIn: signIn,
            register: register,
            getShippingMethods: getShippingMethods,
            updateShipping: updateShipping,
            applyPromoCode: applyPromoCode,
            currencySettingUrl: currencySettingUrl,
            paymentMethodsUrl: paymentMethodsUrl,
            newsLetterSubscription: newsLetterSubscription,
            removePromoCode: removePromoCode,
            forgotPassword: forgotPassword,
            bulkAddproduct: bulkAddproduct,
            pcaAccessCode: pcaAccessCode,
            getDefaultCountryUrl: getDefaultCountryUrl
        });
    </script>
");

WriteLiteral("    ");

            
            #line 120 "..\..\Views\Shared\_LayoutCMS.cshtml"
Write(Html.GetGlobalSnipptes(SnippetPlacements.BodyEndHtmlTagBefore));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591