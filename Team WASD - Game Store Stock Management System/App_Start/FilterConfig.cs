using System.Web;
using System.Web.Mvc;

namespace Team_WASD___Game_Store_Stock_Management_System
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
