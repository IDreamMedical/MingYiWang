using MingYiWang.Business.Model;
using MingYiWang.DataAccess.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business
{
    public class MenuBiz
    {

        public static IList<Menu> GetMenus()
        {
            var results = new List<Menu>();
            try
            {
                using (var ctx = new MenuContext())
                {
                    results = ctx.Menus.ToList();
                }
            }
            catch (Exception exp)
            {
            }
            return results;

        }
    }
}
