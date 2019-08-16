using System.Web;
using System.Web.Mvc;

namespace DellaViaAutomation.WebApiAndUi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
