using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
namespace JIM
{
    class mailClass
    {
        static SmtpClient  Client = new SmtpClient();
       static MailMessage message;
        public static string[] send(string mail)
        {
            try
            {
                Client.Host = "smtp.163.com";//SmtpClient的服务器为163网易邮箱
                Client.UseDefaultCredentials = false;// '验证身份声明使用默认凭据
                Client.Credentials = new System.Net.NetworkCredential("你的邮箱", "密码");// 发件人进行身份验证的凭据,邮箱和密码
                Client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;//通过网络发送邮件到 163 Smtp 服务器
                message = new MailMessage("你的邮箱", mail);//声明一个Mailmessage,初始化发件人邮箱和收件人邮箱
                message.Subject = "登录验证";
                var code=getCode();
                message.Body = "您好,此次验证码为" + code;
                Client.Send(message);

                return new string[] { "发送成功,请注意查收", code };

            }
            catch (Exception e)
            {
                return new string[] {e.Message,""};
            }
        }


       static  string getCode()
        {
            var digit = 6;//声明验证码的位数
            string codeList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";//字母与数字待挑选 
            var code = ""; //初始化

            Random ra = new Random();
            for (int i = 0; i < digit; i++)
            {
                code += codeList[ra.Next(36)];
            }
            return code;
        }



    }
}
