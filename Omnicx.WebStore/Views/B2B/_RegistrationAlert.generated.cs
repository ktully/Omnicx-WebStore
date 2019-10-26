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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/B2B/_RegistrationAlert.cshtml")]
    public partial class _Views_B2B__RegistrationAlert_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_B2B__RegistrationAlert_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\B2B\_RegistrationAlert.cshtml"
  
/*
    Name: Registration Validation Message
    Purpose: Company registration Form Modal
    Structure: /Views/B2B/_RegistrationAlert.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/B2B/_Register.cshtml  (Navigation Link Desktop and Big Screen)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"alertBlock\"");

WriteLiteral(">\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" ng-repeat=\"err in gm.errorMessage track by $index\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon-warning-sign\"");

WriteLiteral("></i>&nbsp;&nbsp;&nbsp;<span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"divErrMsg alert alert-danger hide\"");

WriteLiteral(">\r\n        <div>\r\n            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span></span>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591