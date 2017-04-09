using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    public class Menu
    {

        [Key]
        public string MenuId { get; set; }

        public string MenuName { get; set; }


        public string Description { get; set; }



        public string Url { get; set; }

        /// <summary>
        /// 菜单图片
        /// </summary>
        public string TabBarImg { get; set; }




        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
