using iHealthwoo.WeChat.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Http;

namespace MingYiWang.WebAPI.Controllers
{
    public class SignatureController : ApiController
    {

        [HttpGet]
        public string GetSignature(string signature, string timestamp, string nonce, string token, string echoStr)
        {

            
            File.AppendAllText("C:\\CheckSignature.txt", string.Format("请求Ip:{0}\n", GetClientIp(Request)));
            File.AppendAllText("C:\\CheckSignature.txt", string.Format("请求Uri:{0}\n", Request.RequestUri));

            //var formDataDic = Request.Content.ReadAsFormDataAsync().Result;
            //string signature = formDataDic[WeChatSignaturePropKeys.SignatureKey];
            //string timestamp = formDataDic[WeChatSignaturePropKeys.TimestampKey];
            //string nonce = formDataDic[WeChatSignaturePropKeys.NonceKey];
            //string token = formDataDic[WeChatSignaturePropKeys.TokenKey];
            //string echoStr = formDataDic[WeChatSignaturePropKeys.EchoStrKey];
            var result = CheckWeChatSignature.CheckSignature(signature, timestamp, nonce, "51Wen1Sheng");
            if (result)
            {
                return echoStr;
            }
            else
            {
                return "";
            }
        }



        private string GetClientIp(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }

           

            return null;
        }

    }
}
