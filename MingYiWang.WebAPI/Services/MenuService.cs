using MingYiWang.Business;
using MingYiWang.Business.Model;
using MingYiWang.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    /// <summary>
    /// 九宫格菜单
    /// </summary>
    public class MenuService
    {
        public static List<MenuResponse> GetMenus()
        {
            var results = new List<MenuResponse>();
            var menus = MenuBiz.GetMenus();
            foreach (var item in menus)
            {
                results.Add(new MenuResponse
                {
                    MenuName = item.MenuName,
                    IsEnable = item.IsEnable,
                    TabBarImg = item.TabBarImg,
                    Url = item.Url
                });
            }
            return results;
        }
    }
}