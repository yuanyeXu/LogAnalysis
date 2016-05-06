using System.Collections.Generic;
using LogAnalysis.MongoDB.Web.Models.NavigationMenu;
using LogAnalysis.MongoDB.Contract.Common;

namespace LogAnalysis.MongoDB.Web.Interfaces
{
    public interface INavigation: IDependency
    {
        List<NavigationMenuModel> LoadNavigationMenus();
    }
}
