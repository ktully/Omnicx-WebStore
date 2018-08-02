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
    
    #line 12 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/Layout1/_CheckoutBillingAddress.cshtml")]
    public partial class _Views_Checkout_Layout1__CheckoutBillingAddress_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Commerce.AddressModel>
    {
        public _Views_Checkout_Layout1__CheckoutBillingAddress_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
  
/*
    Name: Standard Checkout Billing Address
    Purpose: Billing Address
    Structure: /Views/Checkout/Layout1/_CheckoutBillingAddress.cshtml
    Contains (Partial Views Used):
    
    Contained In (Where we Use this View):
        a-/Views/Basket/Layout1/_CheckoutPaymentMethod.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
  
    var addressForm = Html.Angular().ModelFor("ck.model.checkout.billingAddress");

            
            #line default
            #line hidden
WriteLiteral("\r\n<form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" name=\"billingForm\"");

WriteLiteral(" novalidate");

WriteLiteral(" ng-init=\"ck.model.checkout.billingAddress={}\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">       \r\n        <div");

WriteLiteral(" class=\"or-spacer\"");

WriteLiteral("><div");

WriteLiteral(" class=\"mask\"");

WriteLiteral("></div></div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 margin-top-sm\"");

WriteLiteral(">\r\n                <h5");

WriteLiteral(" class=\"margin-top-sm margin-bottom-sm checkout-h2\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
                                                                  Write(LT("Checkout.Label.BillingAddress" , "Billing Address"));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control control--checkbox ng-binding\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
                   Write(LT("Checkout.Label.SameAs" , "Same As"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 29 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
                                                            Write(LT("Checkout.Label.BillingAdd" , "Delivery Address"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <input");

WriteLiteral(" id=\"billing\"");

WriteLiteral(" name=\"billing\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"ck.sameAsBillAddress\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-click=\"ck.setShipAddress(ck.sameAsBillAddress)\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                    </label>\r\n                </div>\r\n            </div>" +
"\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 39 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.row " +
"-->\r\n\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 53 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.Address1));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.Address2));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.row " +
"-->\r\n\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 67 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.City));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.PostCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 77 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">Country</label>\r\n                    <select");

WriteLiteral(" id=\"ck.model.checkout.billingAddress.countryCode\"");

WriteLiteral(" name=\"title\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"ck.model.checkout.billingAddress.countryCode\"");

WriteLiteral(">\r\n                        <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
                                    Write(LT("Common.Label.Select" , "Select"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 84 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
                                                                          Write(LT("Checkout.Label.State" , "County"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                        <option");

WriteLiteral(" ng-repeat=\"countries in ck.model.billingCountries\"");

WriteLiteral(" value=\"{{countries.twoLetterIsoCode}}\"");

WriteLiteral(" ng-bind=\"countries.name\"");

WriteLiteral("></option>\r\n                    </select>\r\n                </div>\r\n            </" +
"div>\r\n\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 92 "..\..\Views\Checkout\Layout1\_CheckoutBillingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.PhoneNo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.row " +
"-->\r\n    </div>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
