using System.Web;
using System.Web.Mvc;

namespace NqmLeson11K22cntt1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
