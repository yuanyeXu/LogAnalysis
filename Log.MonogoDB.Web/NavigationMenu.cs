using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogAnalysis.MongoDB.Web.Interfaces;
using LogAnalysis.MongoDB.Web.Models.NavigationMenu;

namespace LogAnalysis.MongoDB.Web
{
    public class NavigationMenu : INavigation
    {
        public List<NavigationMenuModel> LoadNavigationMenus()
        {
            return new List<NavigationMenuModel>
            {
                new NavigationMenuModel{
                      Order = 0,
                      LinkUrl="#",
                      Text="首页",
                },
                new NavigationMenuModel{
                    Order = 1,
                    Text ="系统日志",
                    LinkUrl = "#",
                    ChildrenMenuModels = new List<NavigationMenuModel>
                    {
                         new NavigationMenuModel{
                            LinkUrl="#",
                            Order = 0,
                            Text="接口信息统计",
                         },
                          new NavigationMenuModel{
                            LinkUrl="#",
                            Order = 1,
                            Text="服务响应统计",
                         },
                    }
                },
            };
        }
    }
}