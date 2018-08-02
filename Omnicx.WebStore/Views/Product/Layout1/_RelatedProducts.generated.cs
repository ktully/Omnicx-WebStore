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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/Layout1/_RelatedProducts.cshtml")]
    public partial class _Views_Product_Layout1__RelatedProducts_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Product_Layout1__RelatedProducts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Product\Layout1\_RelatedProducts.cshtml"
  
/*
    Name: Related Products
    Purpose: Show related products of open product in detail page
    Structure: /Views/Product/Layout1/_RelatedProducts.cshtml
    Contains (Partial Views Used):
        a-/Views/Search/Layout1/_ProductWidget.cshtml

    Contained In (Where we Use this View):
        a-/Views/Product/Layout1/ProductDetail.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding gridView\"");

WriteLiteral(" ng-init=\"pm.quickView=true;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"accordion\"");

WriteLiteral(">\r\n        <dl>\r\n            <dt>\r\n                <a");

WriteLiteral(" href=\"#relatedProduct\"");

WriteLiteral(" aria-expanded=\"true\"");

WriteLiteral(" aria-controls=\"relatedProduct\"");

WriteLiteral(" class=\"accordion-title accordionTitle js-accordionTrigger is-collapsed is-expand" +
"ed\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Product\Layout1\_RelatedProducts.cshtml"
                                                                                                                                                                             Write(LT("ProductDetail.label.AlsoLike", "You may also like these products"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </dt>\r\n            <dd");

WriteLiteral(" class=\"accordion-content accordionItem-lg no-padding is-expanded animateIn\"");

WriteLiteral(" id=\"relatedProduct\"");

WriteLiteral(" aria-hidden=\"false\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-5ths col-xs-5ths col-lg-5ths col-md-5ths resultContainerRelated\"");

WriteLiteral(" ng-repeat=\"product in pm.model.relatedProductList track by $index\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Views\Product\Layout1\_RelatedProducts.cshtml"
               Write(Html.Partial("~/Views/Search/Layout1/_ProductWidgetNew.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
