﻿using System.Web;
using System.Web.Mvc;

namespace Northwind.Store.UI.Web.Internet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
