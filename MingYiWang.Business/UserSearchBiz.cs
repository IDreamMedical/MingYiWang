using MingYiWang.Business.Model;
using MingYiWang.DataAccess.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business
{
    public class UserSearchBiz
    {

        public User GetUser(string eMail, string pwd)
        {
            var result = new User();
            try
            {
                using (var ctx = new UserContext())
                {
                    result = ctx.Users.FirstOrDefault(o => o.eMail==eMail&&o.Password==pwd);
                }
            }
            catch (Exception exp)
            {
            }
            return result;
        }
    }
}
