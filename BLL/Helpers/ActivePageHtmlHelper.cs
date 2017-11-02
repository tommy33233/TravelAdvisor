using System;
using System.Web.Mvc;

namespace BLL.Helpers
{
    public static  class ActivePageHtmlHelper
    {
        public static String NavActive(this HtmlHelper htmlHelper,
                         string actionName,
                         string controllerName)
        {
            var a = htmlHelper.ViewContext.RouteData;
            var controller = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");
            var action = htmlHelper.ViewContext.RouteData.GetRequiredString("action");

            if (controllerName == controller && action == actionName)
                return "current_page_item";
            else
                return String.Empty;
        }
    }
}
