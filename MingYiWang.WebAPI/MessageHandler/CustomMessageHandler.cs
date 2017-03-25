using Senparc.Weixin.MP.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.Context;
using System.IO;
using Senparc.Weixin.MP.Entities.Request;
using MingYiWang.WebAPI.Services;
using Antlr.Runtime;

namespace MingYiWang.WebAPI.MessageHandler
{
    public class CustomMessageHandler : MessageHandler<MessageContext<IRequestMessageBase, IResponseMessageBase>>
    {

        public CustomMessageHandler(Stream inputStream, PostModel postModel, int maxRecordCount = 0)
           : base(inputStream, postModel, maxRecordCount)
        {

        }

        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {
            var responseMessage = base.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "您没有发送任何消息内容！";
            return responseMessage;
        }

        public override IResponseMessageBase OnTextRequest(RequestMessageText requestMessage)
        {
            var responseMessage = base.CreateResponseMessage<ResponseMessageText>();
            if (requestMessage.Content == null)
            {
                responseMessage.Content = "您没有发送任何消息内容！";

            }
            else if (requestMessage.Content == CategoryResource.Help)
            {
                responseMessage = HelpService.GetResponseMessage(requestMessage);
            }
            else if (requestMessage.Content == CategoryResource.Dept)
            {
                responseMessage = DeptService.GetResponseMessage(requestMessage);
            }
            else if (requestMessage.Content == CategoryResource.KeyReg)
            {
                responseMessage = KeyRegService.GetResponseMessage(requestMessage);
            }
            return responseMessage;
        }
    }
}