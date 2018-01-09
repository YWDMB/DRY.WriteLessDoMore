using DRY.Infrastructure.Utils.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DRY.Infrastructure.ThirdParty.SMS
{
    public class SMSService
    {

        public static string SendSMS(string mobile)
        {
            string verifyCode = new Random().Next(10000, 100000).ToString();
            SendInfo sendInfo = new SendInfo
            {
                account = "5166",
                mobile = mobile,
                text = "您的验证码为"+ verifyCode + "，请勿向他人泄露。",
                sign = "ZDIxZjg5Y2U3NGY3OGNmNjZjNjI4ZWE0MjlhOGIyNGI=",
                extend = "",
            };

            string sendJsonString = StringHelper.BuildJsonString(sendInfo);
            byte[] paramByteArray = Encoding.UTF8.GetBytes(sendJsonString);

            

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://202.91.244.252:30001/yqx/v1/sms/single_send");
            request.ContentType = "application/json;charset=utf-8";
            request.ContentLength = paramByteArray.Length;
            request.Method = "POST";

            using (Stream requestStream = request.GetRequestStream()) { requestStream.Write(paramByteArray, 0, paramByteArray.Length); }
            StreamReader resultStream = new StreamReader(request.GetResponse().GetResponseStream(), Encoding.UTF8);
            string receiveJsonString = resultStream.ReadToEnd();
            ReceiveInfo receiveInfo = StringHelper.BuildJsonObject<ReceiveInfo>(receiveJsonString);
            if (receiveInfo.code == "0")
            {
                string msgid = receiveInfo.msgid;
                return verifyCode;
            }
            return "";
        }
    }

    class ReceiveInfo
    {
        public string code { set; get; }//结果代码
        public string msg { set; get; }//结果说明
        public string msgid { set; get; }//短信 id
    }

    class SendInfo
    {
        public string account { set; get; }//客户唯一 ID
        public string mobile { set; get; }//接收的手机号
        public string text { set; get; }//短信内容
        public string sign { set; get; }//签名摘要
        public string extend { set; get; }//扩展号默认不开放，如有需要请联系客服申请

    }
}
