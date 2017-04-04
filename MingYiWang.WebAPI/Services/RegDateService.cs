using MingYiWang.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    public class RegDateService
    {
        public static List<RegDateResponse> GetRegDate(string doctorId)
        {
            var results = new List<RegDateResponse>();
            var curDate = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                var weekStr = CaculateWeekDay(curDate.Year, curDate.Month, curDate.Day);
                if (curDate.Date == DateTime.Now.Date)
                {
                    weekStr = "今日";
                    results.Add(new RegDateResponse { WeekStr = weekStr, CurDate = curDate, RegValue = "1" });

                }
                else
                {
                    results.Add(new RegDateResponse { WeekStr = weekStr, CurDate = curDate, RegValue = "0" });
                }
                curDate = curDate.AddDays(1);
            }
            return results;
        }

        private static string CaculateWeekDay(int y, int m, int d)
        {
            if (m == 1) m = 13;
            if (m == 2) m = 14;
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400) % 7 + 1;
            string weekstr = "";
            switch (week)
            {
                case 1: weekstr = "星期一"; break;
                case 2: weekstr = "星期二"; break;
                case 3: weekstr = "星期三"; break;
                case 4: weekstr = "星期四"; break;
                case 5: weekstr = "星期五"; break;
                case 6: weekstr = "星期六"; break;
                case 7: weekstr = "星期日"; break;
            }
            return weekstr;
        }

    }
}