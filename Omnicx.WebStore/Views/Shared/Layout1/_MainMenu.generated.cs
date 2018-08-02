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
    
    #line 14 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_MainMenu.cshtml")]
    public partial class _Views_Shared_Layout1__MainMenu_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Site.NavigationModel>
    {
        public _Views_Shared_Layout1__MainMenu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
  
/*
    Name: Mega Menu
    Purpose: Show Mega Menu For Desktop and big screens
    Structure: /Views/Shared/Layout1/_MainMenu.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Shared/Layout1/_HeaderLayout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<section");

WriteLiteral(" class=\"siteNav\"");

WriteLiteral(" id=\"akc-container-fluid\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <nav");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"mobileMenuBtn hamburger hamburger--squeeze visible-xs\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" aria-label=\"Mobile Menu\"");

WriteLiteral(" aria-controls=\"navigation\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"hamburger-box\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"hamburger-inner\"");

WriteLiteral("></span>\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"mobileMenuBtn__text\"");

WriteLiteral(">Close</span>\r\n                </button>\r\n");

            
            #line 25 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                   if (Model != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                <center>\r\n                    <ul>\r\n");

            
            #line 29 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                         foreach (var items in @Model.Header.OrderBy(o => o.DisplayOrder))
                                {
                                    if (items.NavBlocks.Count <= 0)
                                    {


            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" class=\"menu__item\"");

WriteLiteral(" data-show-menu-option=\"");

            
            #line 35 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                            Write(items.Caption);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1499), Tuple.Create("\"", 1523)
, Tuple.Create(Tuple.Create("", 1506), Tuple.Create("/", 1506), true)
            
            #line 35 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                        , Tuple.Create(Tuple.Create("", 1507), Tuple.Create<System.Object, System.Int32>(items.Hyperlink
            
            #line default
            #line hidden
, 1507), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 36 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                   Write(items.Caption);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 37 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                         if (items.NavBlocks != null && items.NavBlocks.Count > 0)
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                <span");

WriteLiteral(" class=\"hidden-xs menu__item__arrow menu__item__arrow--grey\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                                                <span");

WriteLiteral(" class=\"visible-xs icon icon-arrow-right\"");

WriteLiteral("></span>\r\n");

            
            #line 41 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                    </a>\r\n                                </li>\r\n" +
"");

            
            #line 44 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"

                                    }
                                    else
                                    {


            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" class=\"menu__item\"");

WriteLiteral(" data-show-menu-option=\"");

            
            #line 50 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                            Write(items.Caption);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" value=\"{{items.id}}\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2372), Tuple.Create("\"", 2396)
, Tuple.Create(Tuple.Create("", 2379), Tuple.Create("/", 2379), true)
            
            #line 50 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                             , Tuple.Create(Tuple.Create("", 2380), Tuple.Create<System.Object, System.Int32>(items.Hyperlink
            
            #line default
            #line hidden
, 2380), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 51 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                   Write(items.Caption);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 52 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                         if (items.NavBlocks != null && items.NavBlocks.Count > 0)
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                <span");

WriteLiteral(" class=\"hidden-xs menu__item__arrow menu__item__arrow--grey\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                                                <span");

WriteLiteral(" class=\"visible-xs icon icon-arrow-right\"");

WriteLiteral("></span>\r\n");

            
            #line 56 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                    </a>\r\n                                </li>\r\n" +
"");

            
            #line 59 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"

                                    }
                                }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </center>\r\n");

            
            #line 64 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                    }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section");

WriteLiteral(" class=\"megaNav\"");

WriteLiteral(">\r\n    <!-- START: Mega nav: WOMENS -->\r\n");

            
            #line 73 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
    
            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
       if (Model != null)
        {
            foreach (var items in @Model.Header.OrderBy(o => o.DisplayOrder))
            {
                if (items.NavBlocks != null && items.NavBlocks.Count > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"menuOption desktopHoverItem\"");

WriteLiteral(" data-menu-option=\"");

            
            #line 79 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                          Write(items.Caption);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container padding-desktop-tb-2em\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 82 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                 if (items.HeaderContent != "0" && items.HeaderContent != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"col-sm-12 megamenu-Header\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"megamenu-img\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                          Write(Html.Raw(items.HeaderContent));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </div>\r\n");

            
            #line 87 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 88 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                 foreach (var child1 in @items.NavBlocks.OrderBy(o => o.DisplayOrder))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"col-sm-3 menuOption__mobContainer gutter-control-left\"");

WriteAttribute("style", Tuple.Create(" style=\"", 4246), Tuple.Create("\"", 4278)
, Tuple.Create(Tuple.Create("", 4254), Tuple.Create("width:", 4254), true)
            
            #line 90 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                , Tuple.Create(Tuple.Create("", 4260), Tuple.Create<System.Object, System.Int32>(child1.WidthPct
            
            #line default
            #line hidden
, 4260), false)
, Tuple.Create(Tuple.Create("", 4276), Tuple.Create("%;", 4276), true)
);

WriteLiteral(">\r\n");

            
            #line 91 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                     if (@child1.NavBlockType == @MenuTypes.SimpleLink.GetHashCode())
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" class=\"megaNav__header mobileMenuBack visible-xs\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4520), Tuple.Create("\"", 4554)
            
            #line 93 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                   , Tuple.Create(Tuple.Create("", 4527), Tuple.Create<System.Object, System.Int32>(child1.ItemIds.ToFullUrl()
            
            #line default
            #line hidden
, 4527), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"icon icon-arrow-left\"");

WriteLiteral("></span> ");

            
            #line 93 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                                                                                                                      Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                                        <a");

WriteLiteral(" class=\"megaNav__header visible-xs\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4698), Tuple.Create("\"", 4732)
            
            #line 94 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
    , Tuple.Create(Tuple.Create("", 4705), Tuple.Create<System.Object, System.Int32>(child1.ItemIds.ToFullUrl()
            
            #line default
            #line hidden
, 4705), false)
);

WriteLiteral(">");

            
            #line 94 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                                                            Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visible-xs icon icon-arrow-right\"");

WriteLiteral("></span></a>\r\n");

WriteLiteral("                                        <a");

WriteLiteral(" class=\"megaNav__header\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4876), Tuple.Create("\"", 4910)
            
            #line 95 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
, Tuple.Create(Tuple.Create("", 4883), Tuple.Create<System.Object, System.Int32>(child1.ItemIds.ToFullUrl()
            
            #line default
            #line hidden
, 4883), false)
);

WriteLiteral(">");

            
            #line 95 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                                                 Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visible-xs icon icon-arrow-right\"");

WriteLiteral("></span></a>\r\n");

            
            #line 96 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <label");

WriteLiteral(" class=\"megaNav__header mobileMenuBack visible-xs\"");

WriteLiteral(" href=\"#\"");

WriteLiteral("><span");

WriteLiteral(" class=\"icon icon-arrow-left\"");

WriteLiteral("></span> ");

            
            #line 99 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                                                                                                Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

WriteLiteral("                                        <label");

WriteLiteral(" class=\"megaNav__header visible-xs\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                                      Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visible-xs icon icon-arrow-right\"");

WriteLiteral("></span></label>\r\n");

WriteLiteral("                                        <label");

WriteLiteral(" class=\"megaNav__header\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                           Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visible-xs icon icon-arrow-right\"");

WriteLiteral("></span></label>\r\n");

            
            #line 102 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <ul");

WriteLiteral(" class=\"megaNav__list menuOption__mobContainer__list\"");

WriteLiteral(">\r\n");

            
            #line 105 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                         foreach (var child2 in @child1.NavItems)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                            <li><a");

WriteLiteral(" class=\"megaNav__list__item\"");

WriteAttribute("href", Tuple.Create(" href=\"", 5974), Tuple.Create("\"", 5998)
, Tuple.Create(Tuple.Create("", 5981), Tuple.Create("/", 5981), true)
            
            #line 107 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
      , Tuple.Create(Tuple.Create("", 5982), Tuple.Create<System.Object, System.Int32>(child2.ItemLink
            
            #line default
            #line hidden
, 5982), false)
);

WriteLiteral(">");

            
            #line 107 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                                                                   Write(child2.Caption);

            
            #line default
            #line hidden
WriteLiteral("</a> </li>\r\n");

            
            #line 108 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </ul>\r\n                                    " +
"<span");

WriteLiteral(" class=\"megamenu-img\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                          Write(Html.Raw(child1.ContentBody));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </div>\r\n");

            
            #line 113 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 114 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                 if (items.FooterCotent != "0" && items.FooterCotent != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"col-sm-12 megamenu-Footer\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"megamenu-img\"");

WriteLiteral(">");

            
            #line 117 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                                          Write(Html.Raw(items.FooterCotent));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </div>\r\n");

            
            #line 119 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 123 "..\..\Views\Shared\Layout1\_MainMenu.cshtml"
                }
            }
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!-- END: Mega nav: WOMENS -->\r\n</section>");

        }
    }
}
#pragma warning restore 1591
