using System.Web;
using System.Web.Mvc;

namespace S14_L55_MasterDetails
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}