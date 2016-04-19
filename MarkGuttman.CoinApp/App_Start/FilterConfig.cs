using System.Web;
using System.Web.Mvc;

namespace MarkGuttman.CoinApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
