using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI
{
    //public class CategoryResource
    //{
    //    private static Lazy<Dictionary<string, string>> _defaultCateogrys = new Lazy<Dictionary<string, string>>(Create);

    //    public static Dictionary<string, string> DefaultCateogrys
    //    {
    //        get { return _defaultCateogrys.Value; }
    //    }


    //    private static Dictionary<string, string> Create()
    //    {
    //        var dic = new Dictionary<string, string>();
    //        dic.Add("Help", "帮助");
    //        dic.Add("Dept", "科室");
    //        dic.Add("KeyReg", "预约");
    //        return dic;
    //    }
    //}


    public class CategoryResource
    {
        /// <summary>
        /// 帮助
        /// </summary>
        public const string Help = "帮助";
        /// <summary>
        /// 科室
        /// </summary>
        public const string Dept = "科室";
        /// <summary>
        /// 预约
        /// </summary>
        public const string KeyReg = "预约";
    }
}