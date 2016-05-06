using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogAnalysis.MongoDB.Web.Models.NavigationMenu
{
    public class NavigationMenuModel
    {
        public int Order { get; set; }

        public string Text { get; set; }

        public string LinkUrl { get; set; }

        public Dictionary<string, string> RouteData { get; set; }

        public List<NavigationMenuModel> ChildrenMenuModels { get; set; }

        public NavigationMenuModel()
        {
            Text = string.Empty;
            LinkUrl = string.Empty;

            RouteData = new Dictionary<string, string>();
            ChildrenMenuModels = new List<NavigationMenuModel>();
        }
    }
}