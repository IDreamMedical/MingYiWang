using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.DataAccess.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business
{
    public class PatientOrderBiz
    {
        private readonly PatientOrder _patientOrder;
        public PatientOrderBiz(PatientOrder patientOrder)
        {
            _patientOrder = patientOrder;
        }
        public ResultApi<string> Save()
        {
            var result = new ResultApi<string>();
            try
            {
                var dbContext = new PatientOrderContext();
                dbContext.PatientOrders.Add(_patientOrder);
                dbContext.Save();
                result.Sucess = true;
                result.ReturnMsg = "保存信息成功";
            }
            catch (Exception exp)
            {
                result.ReturnMsg = exp.Message;
                result.Sucess = false;
                result.Data = "保存失败";
            }
            return result;
        }

    }
}
