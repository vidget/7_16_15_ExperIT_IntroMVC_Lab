using System.Web;
using System.Web.Mvc;

namespace _7_16_15_ExperIT_IntroMVC_Lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
