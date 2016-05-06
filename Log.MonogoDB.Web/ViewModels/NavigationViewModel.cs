using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogAnalysis.MongoDB.Web.Models.NavigationMenu;

namespace LogAnalysis.MongoDB.Web.ViewModels
{
    public class NavigationViewModel
    {
        public List<NavigationMenuModel> MenuModels { get; set; }

        public NavigationViewModel()
        {
            MenuModels = new List<NavigationMenuModel>();
        }
    }
}