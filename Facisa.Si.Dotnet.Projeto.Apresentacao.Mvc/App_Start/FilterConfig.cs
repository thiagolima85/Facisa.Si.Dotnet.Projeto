﻿using System.Web;
using System.Web.Mvc;

namespace Facisa.Si.Dotnet.Projeto.Apresentacao.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
