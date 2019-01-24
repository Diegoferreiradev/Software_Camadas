using HouseDJ.Musicas.Web.Filtros;
using System.Web;
using System.Web.Mvc;

namespace HouseDJ.Musicas.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogActionFilter());
            filters.Add(new LogResultFilter());
        }
    }
}
