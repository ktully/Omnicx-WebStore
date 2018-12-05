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
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 13 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_MobileHeaderLayout.cshtml")]
    public partial class _Views_Shared__MobileHeaderLayout_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared__MobileHeaderLayout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
  
/*
    Name: Mobile Header
    Purpose: Mobile Site Header UI
    Structure: /Views/Shared/_MobileHeaderLayout.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Shared/_LayoutHeader.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
  

    var checkoutUrl = Url.Action("OnePageCheckout", "Checkout");
    if (ConfigKeys.OnePageCheckout == false)
    {
        checkoutUrl = Url.Action("StandardCheckout", "Checkout");
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container-fluid headerMobile\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-xs-2\"");

WriteLiteral("></div>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
       Write(Html.Action("SiteLogo", "Home", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-xs-4\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row mobileHeaderBorder\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"col-xs-6 no-padding\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#globalSearch-xs\"");

WriteLiteral(" class=\"headerAction\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 1157), Tuple.Create("\"", 1203)
, Tuple.Create(Tuple.Create("", 1163), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/search-ico.png")
, 1163), false)
);

WriteLiteral(" /></a>\r\n                </div>               \r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"col-xs-6 no-padding mobile-menu-box right-header\"");

WriteLiteral(">\r\n                    <ul>\r\n                        <li");

WriteLiteral(" class=\"shopping-cart cartopen {{gm.activeClass}}\"");

WriteLiteral(" id=\"shoppingCart\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"gm.isShow=!gm.isShow;gm.showBasket(gm.isShow);\"");

WriteLiteral(" title=\"Cart\"");

WriteLiteral(" class=\"headerAction text-center\"");

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1665), Tuple.Create("\"", 1716)
, Tuple.Create(Tuple.Create("", 1671), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/shoppingbag-ico.png")
, 1671), false)
);

WriteLiteral(" />\r\n                                <span");

WriteLiteral(" class=\"metaLinks__basket__indicator\"");

WriteLiteral(" ng-bind=\"gm.count\"");

WriteLiteral("></span>\r\n                            </a>\r\n                            <ul");

WriteLiteral(" id=\"mobileBasket\"");

WriteLiteral(" class=\"submenu-mainmenu cart-group-1\"");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                                <li");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                                    <ul");

WriteLiteral(" id=\"cartdropdown\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" class=\"single-cart-item clearfix\"");

WriteLiteral(" ng-repeat=\"items in gm.basketResponse.lineItems track by $index\"");

WriteLiteral(" ng-if=\"items.parentProductId == gm.emptyGuid\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(" ng-if=\"items.parentProductId == gm.emptyGuid\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"col-sm-3 col-xs-3 no-padding\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cart-img no-border\"");

WriteLiteral(">\r\n                                                        <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                                            <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                                        </a>\r\n                " +
"                                    </span>\r\n                                   " +
"             </div>\r\n                                                <div");

WriteLiteral(" class=\"col-sm-9 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 cart-info\"");

WriteLiteral(">\r\n                                                        <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                                                    </div>\r\n              " +
"                                      <div");

WriteLiteral(" class=\"col-xs-7 no-padding\"");

WriteLiteral(">                                                        \r\n                      " +
"                                  <select");

WriteLiteral(" ng-model=\"items.qty\"");

WriteLiteral(" ng-options=\"qty for qty in gm.basketQtyDropdown\"");

WriteLiteral(" name=\"qty\"");

WriteLiteral(" class=\"form-control cart-text\"");

WriteLiteral(" ng-change=\"gm.updateBasketQty(items.productId, items.qty, items.oldQty, items.di" +
"splayOrder);\"");

WriteLiteral("></select>\r\n                                                        <span");

WriteLiteral(" class=\"disp-inline-b\"");

WriteLiteral(" ng-bind=\"items.price.formatted.withTax\"");

WriteLiteral("></span>                                                        \r\n               " +
"                                     </div>\r\n                                   " +
"                 <div");

WriteLiteral(" class=\"col-xs-5 no-padding-left text-right\"");

WriteLiteral(">\r\n                                                        <span");

WriteLiteral(" class=\"basket-price-mob-strong\"");

WriteLiteral(" ng-bind=\"items.totalPrice.formatted.withTax\"");

WriteLiteral("></span>\r\n                                                    </div>\r\n           " +
"                                         <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 padding-sm\"");

WriteLiteral(">\r\n                                                            <strong");

WriteLiteral(" class=\"text-orange\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 4673), Tuple.Create("\"", 4756)
, Tuple.Create(Tuple.Create("", 4683), Tuple.Create("items.displayInBasket", 4683), true)
, Tuple.Create(Tuple.Create(" ", 4704), Tuple.Create("&&", 4705), true)
, Tuple.Create(Tuple.Create(" ", 4707), Tuple.Create("items.itemType", 4708), true)
, Tuple.Create(Tuple.Create(" ", 4722), Tuple.Create("==", 4723), true)
            
            #line 72 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                           , Tuple.Create(Tuple.Create("", 4725), Tuple.Create<System.Object, System.Int32>(ItemTypes.Bundle.GetHashCode()
            
            #line default
            #line hidden
, 4725), false)
);

WriteLiteral(">");

            
            #line 72 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                                                                                                                       Write(LT("YourBag.Text.IncludeComponents", "Included Components:"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                                                            <div");

WriteLiteral(" class=\"row component-row\"");

WriteLiteral(" ng-repeat=\"bundle in gm.basketResponse.lineItems track by $index\"");

WriteLiteral(" ng-if=\"bundle.parentProductId == items.productId\"");

WriteLiteral(" ng-show=\"items.displayInBasket\"");

WriteLiteral(">\r\n                                                                <div");

WriteLiteral(" class=\"col-sm-8 col-xs-8 no-padding\"");

WriteLiteral(">\r\n                                                                    <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{bundle.slug}}\"");

WriteLiteral(" ng-bind=\"bundle.name\"");

WriteLiteral("></a>\r\n                                                                </div>\r\n  " +
"                                                              <div");

WriteLiteral(" class=\"col-sm-4 col-xs-4 no-padding-left text-right\"");

WriteLiteral(">\r\n                                                                    <strong>");

            
            #line 78 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                       Write(LT("YourBag.Text.Qty", "Qty:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong><span");

WriteLiteral(" ng-bind=\"bundle.qty\"");

WriteLiteral(@"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                                                            <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"btn btn-link delete-link\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"gm.addToBasket(items.productId,0,items.displayOrder)\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                                                                                                                                  Write(LT("YourBag.Text.Remove", "Remove"));

            
            #line default
            #line hidden
WriteLiteral(@"</a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div");

WriteLiteral(" ng-if=\"items.parentProductId != gm.emptyGuid\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"col-sm-3 col-xs-3 no-padding\"");

WriteLiteral(">\r\n                                                        <span");

WriteLiteral(" class=\"cart-img\"");

WriteLiteral(">\r\n                                                            <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                                                <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                                            </a>\r\n            " +
"                                            </span>\r\n                           " +
"                         </div>\r\n                                               " +
"     <div");

WriteLiteral(" class=\"col-sm-9 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                                                        <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                                            <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                                                            <span");

WriteLiteral(" class=\"pull-right text-right\"");

WriteLiteral(">");

            
            #line 102 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                                           Write(LT("YourBag.Text.Free", "FREE"));

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </li>
                                <li");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                                    <select");

WriteLiteral(" id=\"deliverydrpdwn\"");

WriteLiteral(" ng-model=\"selectedid\"");

WriteLiteral(" ng-change=\"gm.updateShipping(selectedid)\"");

WriteLiteral(">\r\n                                        <option");

WriteLiteral(" ng-repeat=\"methods in gm.basketResponse.shippingMethods track by $index\"");

WriteLiteral(" ng-selected=\"methods.id == gm.basketResponse.shippingMethodId\"");

WriteLiteral(" ng-model=\"methods.id\"");

WriteLiteral(" id=\"{{methods.id}}\"");

WriteLiteral(" ng-value=\"methods.id\"");

WriteLiteral(" ng-bind=\"methods.displayName +\' \' + \'(\' + methods.price.formatted.withTax + \')\'\"" +
"");

WriteLiteral("></option>\r\n                                    </select>\r\n                      " +
"          </li>\r\n                                <li");

WriteLiteral(" class=\"total-amount sub_total_price\"");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">                                                                       \r\n       " +
"                             <div");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 no-padding\"");

WriteLiteral(">\r\n                                        <p");

WriteLiteral(" class=\"basket-price\"");

WriteLiteral(">\r\n");

WriteLiteral("                                            ");

            
            #line 118 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                       Write(LT("YourBag.Text.GrandTotal", "Order Total"));

            
            #line default
            #line hidden
WriteLiteral(": <span");

WriteLiteral(" class=\"money\"");

WriteLiteral(" data-currency-usd=\"$48.00\"");

WriteLiteral(" data-currency-eur=\"&amp;euro;45.42\"");

WriteLiteral(" data-currency=\"EUR\"");

WriteLiteral(" ng-bind=\"gm.basketResponse.grandTotal.formatted.withTax\"");

WriteLiteral("></span>\r\n                                        </p>\r\n                         " +
"           </div>\r\n                                    <div");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 no-padding\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding-left\"");

WriteLiteral(">\r\n                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 9790), Tuple.Create("\"", 9827)
            
            #line 123 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 9797), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Basket")
            
            #line default
            #line hidden
, 9797), false)
);

WriteLiteral(" class=\"animate btn-bordered\"");

WriteLiteral(">");

            
            #line 123 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                                                             Write(LT("Header.Link.ViewCart", "View Cart"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                                        </div>\r\n                      " +
"                  <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6\"");

WriteLiteral(">\r\n                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 10105), Tuple.Create("\"", 10150)
            
            #line 126 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 10112), Tuple.Create<System.Object, System.Int32>(checkoutUrl
            
            #line default
            #line hidden
, 10112), false)
, Tuple.Create(Tuple.Create("", 10124), Tuple.Create("//{{gm.basketResponse.id}}", 10124), true)
);

WriteLiteral(" class=\"animate btn-orange\"");

WriteLiteral(">");

            
            #line 126 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                                                                   Write(LT("Checkout.Title.Checkout", "Place Order"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                                        </div>\r\n                      " +
"              </div>\r\n                                </li>\r\n                   " +
"             <li");

WriteLiteral(" ng-hide=\"gm.basketResponse.lineItems.length > 0\"");

WriteLiteral(">\r\n                                    <p");

WriteLiteral(" class=\"no-item\"");

WriteLiteral(">Your Bag is empty.</p>\r\n                                </li>\r\n                 " +
"           </ul>\r\n                        </li>\r\n                    </ul>\r\n    " +
"            </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div" +
"");

WriteLiteral(" class=\"modal fade in\"");

WriteLiteral(" id=\"globalSearch-xs\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-search\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header text-center\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"heading-h3 text-center\"");

WriteLiteral(">Search</h3>\r\n                </a>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close search-close-btn\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 148 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                                                                                                                                            Write(LT("Checkout.Button.Close", "Close"));

            
            #line default
            #line hidden
WriteLiteral("</span></button>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 153 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
                   Write(Html.Partial("~/Views/Shared/_SearchBox.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
"     <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 161 "..\..\Views\Shared\_MobileHeaderLayout.cshtml"
Write(Html.Action("GetMobileNav", "Home"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
