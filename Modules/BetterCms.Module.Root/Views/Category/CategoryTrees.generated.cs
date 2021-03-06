﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Category
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Category\CategoryTrees.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Category\CategoryTrees.cshtml"
    using BetterCms.Module.Root.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Category\CategoryTrees.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Category\CategoryTrees.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Category\CategoryTrees.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Category\CategoryTrees.cshtml"
    using BetterCms.Module.Root.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Category\CategoryTrees.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Category\CategoryTrees.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/CategoryTrees.cshtml")]
    public partial class CategoryTrees : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Category.CategoryTreesGridViewModel<SiteSettingCategoryTreeViewModel>>
    {
        public CategoryTrees()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Views\Category\CategoryTrees.cshtml"
  
    Action<ColumnBuilder<SiteSettingCategoryTreeViewModel>> columns = column =>
    {
        column.EditButtonColumn();
        column.For(m => m.Title)
            .Named(RootGlobalization.SiteSettings_CategoryTrees_TitleColumn)
            .SortColumnName("Title")
            .Attributes(@class => "bcms-grid-item-title");
        column.DeleteButtonColumn();
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Views\Category\CategoryTrees.cshtml"
 using (Html.BeginForm<CategoryController>(f => f.CategoryTrees(null), FormMethod.Post, new { @id = "bcms-categorytrees-form", @class = "bcms-ajax-form" }))
{
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Category\CategoryTrees.cshtml"
Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Category\CategoryTrees.cshtml"
                                              

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-twocols-title-block\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-large-titles\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Category\CategoryTrees.cshtml"
                                  Write(RootGlobalization.SiteSettings_CategoryTrees_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-btn-links-main\"");

WriteLiteral(" id=\"bcms-create-categorytree-button\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Category\CategoryTrees.cshtml"
                                                                         Write(RootGlobalization.SiteSettings_CategoryTrees_AddNewCategoryTree);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Category\CategoryTrees.cshtml"
       Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-editor-field-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-categorytrees-search-btn\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Category\CategoryTrees.cshtml"
                                                                       Write(RootGlobalization.SiteSettings_CategoryTrees_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"bcms-featured-grid bcms-clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Category\CategoryTrees.cshtml"
       Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 35 "..\..\Views\Category\CategoryTrees.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Category\CategoryTrees.cshtml"
Write(Html.SiteSettingsMessagesBox());

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Category\CategoryTrees.cshtml"
                                   
    
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Category\CategoryTrees.cshtml"
Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new EditableHtmlTableGridRenderer<SiteSettingCategoryTreeViewModel>()));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Category\CategoryTrees.cshtml"
                                                                                                                                                                                           
}

            
            #line default
            #line hidden
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-categorytree-list-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 39 "..\..\Views\Category\CategoryTrees.cshtml"
Write(Html.Grid(new List<SiteSettingCategoryTreeViewModel> { new SiteSettingCategoryTreeViewModel() }).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<SiteSettingCategoryTreeViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>");

        }
    }
}
#pragma warning restore 1591
