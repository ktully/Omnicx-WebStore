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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_Alerts.cshtml")]
    public partial class _Views_Shared_Layout1__Alerts_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Layout1__Alerts_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"alertBlock\"");

WriteLiteral(">\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-info\"");

WriteLiteral(" ng-show=\"gm.saving\"");

WriteLiteral(">\r\n        Saving changes...\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" ng-show=\"gm.success\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></span>\r\n        Changes saved!\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span");

WriteLiteral(" ng-bind=\"gm.errorMessage\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"divErrMsg\"");

WriteLiteral(" class=\"alert alert-danger hide\"");

WriteLiteral(">\r\n        <div>\r\n            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span></span>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
