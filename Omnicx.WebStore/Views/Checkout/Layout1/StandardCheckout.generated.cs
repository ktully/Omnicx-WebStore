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
    
    #line 18 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
    using Omnicx.WebStore.Models.Common;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 21 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/Layout1/StandardCheckout.cshtml")]
    public partial class _Views_Checkout_Layout1_StandardCheckout_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<CheckoutViewModel>
    {
        public _Views_Checkout_Layout1_StandardCheckout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
  
/*
    Name: Standard Checkout (Steps)
    Purpose: Standard Checkout for steps to process
    Structure: /Views/Checkout/Layout1/StandardCheckout.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_OpcLayout.cshtml                   (For Base Structure)
        b-/Views/Checkout/Layout1/_CheckoutDeliveryAddress.cshtml   (Select Delivery Address)
        c-/Views/Checkout/Layout1/_CheckoutDeliveryMethod.cshtml    (Select Delivery Method)
        d-/Views/Checkout/Layout1/_CheckoutPaymentMethod.cshtml     (Select Payment Method)
        e-/Views/Checkout/Layout1/_CheckoutOrderReview.cshtml       (Complete Overview of order with all selected items)
        f-/Views/Checkout/Layout1/_GuestRegistration.cshtml         (Guest Checkout or Registration)

    Contained In (Where we Use this View):
        a-/Views/Basket/Layout1/Index.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 23 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
  
    ViewBag.Title = @LT("Checkout.Title.Checkout", "Checkout");
    //Layout = "~/Views/Shared/_Layout.cshtml";
    var checkoutForm = Html.Angular().ModelFor("ck.model");
    Layout = "~/Views/Shared/Layout1/_OpcLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 29 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
  
    if (Model.Checkout.Basket.GrandTotal.Raw.WithTax > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <section");

WriteLiteral(" ng-controller=\"checkoutCtrl as ck\"");

WriteLiteral(" ng-init=\"ck.guestCheckout = false;ck.createAccount=false;ck.loginAccount=true;ck" +
".userPanel=true;ck.custAddressGrid();\"");

WriteLiteral(">\r\n");

            
            #line 33 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*Step 1 For Login Or Create Account*/
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 34 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
             if (SessionContext.CurrentUser == null)
            { 

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-init=\"ck.custAddressGrid();\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"checkoutStepLogin\"");

WriteLiteral(" ng-show=\"ck.userPanel\"");

WriteLiteral(">\r\n\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                            <section");

WriteLiteral(" class=\"checkout-accordion\"");

WriteLiteral(">\r\n");

            
            #line 41 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                  /*Registration Form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n                                <div>\r\n                                    <inp" +
"ut");

WriteLiteral(" id=\"ac-2\"");

WriteLiteral(" name=\"accordion-1\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" class=\"visible-xs\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"label-ac visible-xs\"");

WriteLiteral(" for=\"ac-2\"");

WriteLiteral(" ng-click=\"ck.loginAccount=false;ck.createAccount=true;ck.guestCheckout=false;\"");

WriteLiteral("> Create an account</label>\r\n                                    <article");

WriteLiteral(" class=\"ac-large\"");

WriteLiteral(" ng-show=\"ck.createAccount==true\"");

WriteLiteral(">\r\n                                        <form");

WriteLiteral(" name=\"registrationForm\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(" ng-submit=\"ck.registration(ck.model.register)\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" novalidate>                                            \r\n                       " +
"                     <h2");

WriteLiteral(" class=\"checkout-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                         Write(LT("Checkout.Text.Login", "Registration"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 49 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                           Write(checkoutForm.FormGroupFor(x => x.Register.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 52 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                           Write(checkoutForm.FormGroupFor(x => x.Register.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 55 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                           Write(checkoutForm.FormGroupFor(x => x.Register.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding checkout-button\"");

WriteLiteral(">\r\n                                                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-checkout width-full\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 58 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                                               Write(LT("Global.Buttons.Register", "Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                            </div>\r\n                  " +
"                          <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <span>Already a customer?</spa" +
"n>\r\n                                            </div>\r\n                        " +
"                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" class=\"btn btn-default width-full\"");

WriteLiteral(" ng-click=\"ck.loginAccount=true;ck.createAccount=false;ck.guestCheckout=false;\"");

WriteLiteral(">Login Here</a>\r\n                                            </div>\r\n            " +
"                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <span>OR</span>\r\n             " +
"                               </div>\r\n                                         " +
"   <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" class=\"btn btn-default width-full\"");

WriteLiteral(" ng-click=\"ck.loginAccount=false;ck.createAccount=false;ck.guestCheckout=true;\"");

WriteLiteral(">Checkout as Guest</a>\r\n                                            </div>\r\n     " +
"                                   </form>\r\n                                    " +
"</article>\r\n                                </div>\r\n");

            
            #line 75 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                  /*Login Form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n                                <div>\r\n                                    <inp" +
"ut");

WriteLiteral(" id=\"ac-1\"");

WriteLiteral(" name=\"accordion-1\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" checked");

WriteLiteral(" class=\"visible-xs\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"label-ac visible-xs\"");

WriteLiteral(" for=\"ac-1\"");

WriteLiteral(" ng-click=\"ck.loginAccount=true;ck.createAccount=false;ck.guestCheckout=false;\"");

WriteLiteral("> Login. <span>Already a customer?</span></label>\r\n                              " +
"      <article");

WriteLiteral(" class=\"ac-large\"");

WriteLiteral(" ng-show=\"ck.loginAccount==true\"");

WriteLiteral(">\r\n                                        <form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" ng-submit=\"ck.login(ck.model.login)\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" novalidate");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                                            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"ck.errorMessage != null\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" ng-repeat=\"err in ck.errorMessage track by $index\"");

WriteLiteral(">\r\n                                                    <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                                                </div>\r\n               " +
"                             </div>\r\n                                           " +
" <h2");

WriteLiteral(" class=\"checkout-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                         Write(LT("Checkout.Text.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 88 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                           Write(checkoutForm.FormGroupFor(x => x.Login.Username));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 91 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                           Write(checkoutForm.FormGroupFor(x => x.Login.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding\"");

WriteLiteral(">\r\n                                                <label");

WriteLiteral(" class=\"checkout-label\"");

WriteLiteral(">\r\n                                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keep\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> Keep me signed in\r\n                                                </label>\r\n" +
"                                            </div>\r\n                            " +
"                <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"checkout-link\"");

WriteLiteral(">Forgot Password</a>\r\n                                            </div>\r\n       " +
"                                     <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding checkout-button\"");

WriteLiteral(">\r\n                                                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-checkout width-full\"");

WriteLiteral(">");

            
            #line 102 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                     Write(LT("Global.Buttons.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></button>\r\n                                            </div>\r\n             " +
"                               <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider hidden-xs\"");

WriteLiteral(">\r\n                                                <span>New to Store?</span>\r\n  " +
"                                          </div>\r\n                              " +
"              <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" class=\"btn btn-default width-full\"");

WriteLiteral(" ng-click=\"ck.loginAccount=false;ck.createAccount=true;ck.guestCheckout=false;\"");

WriteLiteral(">Create an Account</a>\r\n                                            </div>\r\n     " +
"                                       <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <span>OR</span>\r\n             " +
"                               </div>\r\n                                         " +
"   <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" class=\"btn btn-default width-full\"");

WriteLiteral(" ng-click=\"ck.loginAccount=false;ck.createAccount=false;ck.guestCheckout=true;\"");

WriteLiteral(">Checkout as Guest</a>\r\n                                            </div>\r\n     " +
"                                   </form>\r\n                                    " +
"</article>\r\n                                </div>\r\n");

            
            #line 119 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                  /*Checkout as Guest Form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n                                <div>\r\n                                    <inp" +
"ut");

WriteLiteral(" id=\"ac-3\"");

WriteLiteral(" name=\"accordion-1\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" class=\"visible-xs\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"label-ac visible-xs\"");

WriteLiteral(" for=\"ac-3\"");

WriteLiteral(" ng-click=\"ck.loginAccount=false;ck.createAccount=false;ck.guestCheckout=true;\"");

WriteLiteral("> Checkout as Guest</label>\r\n                                    <article");

WriteLiteral(" class=\"ac-large\"");

WriteLiteral(" ng-show=\"ck.guestCheckout==true\"");

WriteLiteral(">\r\n                                        <form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" name=\"guestForm\"");

WriteLiteral(" class=\"\"");

WriteLiteral(" novalidate");

WriteLiteral(" ng-submit=\"ck.ContinueAsGuest(guestForm)\"");

WriteLiteral(">\r\n                                            <h2");

WriteLiteral(" class=\"checkout-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 125 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                         Write(LT("Checkout.Text.Login" , "Checkout as a Guest"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                                                <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"ck.guestError != null\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" ng-repeat=\"err in ck.guestError track by $index\"");

WriteLiteral(">\r\n                                                        <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                                                    </div>\r\n           " +
"                                     </div>\r\n                                   " +
"         </div>\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 134 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                           Write(checkoutForm.FormGroupFor(x => x.Checkout.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"form-group margin-bottom-sm\"");

WriteLiteral(">\r\n                                                <p");

WriteLiteral(" class=\"checkout-text\"");

WriteLiteral(">");

            
            #line 137 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                    Write(LT("Checkout.Label.NeedEmailAddress" , "We need your email address to send your order and shipping confirmation. We will never share your details with anyone."));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                            </div>\r\n                       " +
"                     <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding checkout-button\"");

WriteLiteral(">\r\n                                                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-checkout width-full\"");

WriteLiteral(">");

            
            #line 140 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                     Write(LT("Global.Buttons.Login" , "Checkout as a Guest"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></button>\r\n                                            </div>\r\n\r\n           " +
"                                 <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <span>New to Store?</span>\r\n  " +
"                                          </div>\r\n                              " +
"              <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" class=\"btn btn-default width-full\"");

WriteLiteral(" ng-click=\"ck.createAccount=true;ck.loginAccount=false;ck.guestCheckout=false;\"");

WriteLiteral(">Create an Account</a>\r\n                                            </div>\r\n     " +
"                                       <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <span>Already a customer?</spa" +
"n>\r\n                                            </div>\r\n                        " +
"                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding margin-top-md hidden-xs\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" class=\"btn btn-default width-full\"");

WriteLiteral(" ng-click=\"ck.loginAccount=true;ck.createAccount=false;ck.guestCheckout=false;\"");

WriteLiteral(@">Login Here</a>
                                            </div>
                                        </form>

                                    </article>
                                </div>
                            </section>
                        </div>
                    </div>
                </div>
");

            
            #line 163 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 164 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
             if (SessionContext.CurrentUser != null)
            {
                if (SessionContext.CurrentUser.FirstName != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h2");

WriteLiteral(" class=\"checkout-summery-h6 pull-right text-right top-login-user-panel\"");

WriteLiteral(">You are logged in as: <strong>");

            
            #line 168 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                                        Write(SessionContext.CurrentUser.FirstName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 168 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                                                                              Write(SessionContext.CurrentUser.LastName);

            
            #line default
            #line hidden
WriteLiteral("</strong></h2>\r\n");

            
            #line 169 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h2");

WriteLiteral(" class=\"checkout-summery-h6 pull-right text-right top-login-user-panel\"");

WriteLiteral(">You are logged in as: <strong>");

            
            #line 172 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                                        Write(SessionContext.CurrentUser.Email);

            
            #line default
            #line hidden
WriteLiteral("</strong></h2>\r\n");

            
            #line 173 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 176 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 176 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*End Step 1*/
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 178 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 178 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*Step 2 For Select Delivery Address*/
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 179 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
       Write(Html.Partial("/Views/Checkout/Layout1/_CheckoutDeliveryAddress.cshtml", @Model.Checkout.ShippingAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 180 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 180 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*END Step 2*/
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 182 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 182 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*Step 3 For Select Delivery Option OR Delivery Speed*/
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 183 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
       Write(Html.Partial("/Views/Checkout/Layout1/_CheckoutDeliveryMethod.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 184 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 184 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*END Step 3*/
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 186 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 186 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*Step 4 For Select Payment Method*/
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 187 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
       Write(Html.Partial("/Views/Checkout/Layout1/_CheckoutPaymentMethod.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 188 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 188 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*END Step 4*/
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 190 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 190 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*Step 5 For Checkout Summey Before Payment page*/
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 191 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
       Write(Html.Partial("/Views/Checkout/Layout1/_CheckoutOrderReview.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 192 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 192 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
              /*END Step 5*/
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 194 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 194 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
             if (SessionContext.CurrentUser == null)
            {
                
            
            #line default
            #line hidden
            
            #line 196 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
           Write(Html.Partial("~/Views/Checkout/Layout1/_GuestRegistration.cshtml", new LoginRegistrationModel { Registration = Model.Register }));

            
            #line default
            #line hidden
            
            #line 196 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                                                                                                                                 
            }

            
            #line default
            #line hidden
WriteLiteral("        </section>\r\n");

            
            #line 199 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <h3>\r\n");

WriteLiteral("                ");

            
            #line 204 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
           Write(LT("Checkout.Label.EmptyBasket", "Basket no longer available"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h3>\r\n        </div>\r\n");

            
            #line 207 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var signIn = \'");

            
            #line 213 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var converToOrder = \'");

            
            #line 214 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                         Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.ConvertToOrder(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var custGridUrl = \'");

            
            #line 215 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                       Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetCustomerAddress()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var deleteAddressUrl = \'");

            
            #line 216 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                            Write(Html.BuildUrlFromExpression<AccountController>(c => c.DeleteAddress(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var register = \'");

            
            #line 217 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                    Write(Html.BuildUrlFromExpression<AccountController>(c => c.Registration(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToBasket = \'");

            
            #line 218 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                       Write(Html.BuildUrlFromExpression<BasketController>(c => c.AddtoBasket(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var removePromoCode = \'");

            
            #line 219 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                           Write(Html.BuildUrlFromExpression<BasketController>(c => c.RemovePromoCode("","")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var searchPhysicalStore = \'");

            
            #line 220 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                               Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GetClickAndCollectOptions(null, null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var nominatedDelivery = \'");

            
            #line 221 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                             Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GetNominatedDelivery(null,null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var guestCheckout = \'");

            
            #line 222 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                         Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GuestCheckout(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var validateGuestPassword = \'");

            
            #line 223 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                 Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.ValidateGuestPassword(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addProductToWishlist = \'");

            
            #line 224 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.AddProductToWishlist("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var removeWishList = \'");

            
            #line 225 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                          Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.RemoveWishList("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var validateLoginPassword = \'");

            
            #line 226 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                 Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral(@"';
        window.app.constant('checkoutConfig',{
            signIn : signIn,
            converToOrder : converToOrder,
            custGridUrl: custGridUrl,
            deleteAddressUrl :deleteAddressUrl,
            register : register,
            addToBasket: addToBasket,
            removePromoCode : removePromoCode,
            searchPhysicalStore : searchPhysicalStore,
            nominatedDelivery : nominatedDelivery,
            guestCheckout : guestCheckout,
            validateGuestPassword : validateGuestPassword,
            addProductToWishlist : addProductToWishlist,
            removeWishList : removeWishList,
            validateLoginPassword : validateLoginPassword
        });
        window.app.constant('model', ");

            
            #line 243 "..\..\Views\Checkout\Layout1\StandardCheckout.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
