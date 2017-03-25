using Senparc.Weixin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    public class KeyRegService
    {
        public static ResponseMessageText GetResponseMessage(RequestMessageText requestMessage)
        {
            var responseMessage = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageText>(requestMessage);
            var sb = new StringBuilder();
            sb.Append("功能说明。微信预约挂号是指快速挂号，快速就医，减少您的挂号排队时间。\r\n");
            sb.Append("主要功能是：\r\n");
            sb.Append("一 随时随地：您可以通过手机微信随时随地预约或取消预约。同时能查看当前科室的预约人数\r\n");
            sb.Append("二 快速：您可以通过不用排队挂号。\r\n");
            sb.Append("==============================\r\n");
            sb.Append(@"赶快来试试预约功能吧！<a href=""http://www.51wenyisheng.com/Doctor/DoctorList.html"">预约挂号</a>\r\n");
            responseMessage.Content = sb.ToString();
            return responseMessage;
        }
    }
}