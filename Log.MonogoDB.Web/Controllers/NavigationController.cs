using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogAnalysis.MongoDB.Web.Interfaces;
using LogAnalysis.MongoDB.Web.ViewModels;

namespace LogAnalysis.MongoDB.Web.Controllers
{
    public class NavigationController : Controller
    {
        // 可以是一个集合进行扩展
        private INavigation _navigationBar;
        public NavigationController(INavigation navigationBar)
        {
            _navigationBar = navigationBar;
        }
        // GET: Navigation
        public ActionResult Navigation()
        {
            NavigationViewModel viewModel = new NavigationViewModel();
            var menus = _navigationBar.LoadNavigationMenus().OrderBy(x => x.Order).ToList();
            viewModel.MenuModels = menus;

            return PartialView(viewModel);
        }
    }
}