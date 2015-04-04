using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Common.Exceptions
{
    public class BaseWechatException : System.Exception
    {
        
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        
    }


    public static class WCException
    {
        public static object WechatExcption(int ErrorCode)
        {
            object rEx;

            switch (ErrorCode)
            {
                case -1:
                    rEx= new SystemBusyException();
                    break;
                case 40001:
                    rEx = new Access_TokenErrorException();
                    break;
                case 40002:
                    rEx = new InavalidSecretException();
                    break;
                case 40003:
                    rEx = new InavalidOpenIDException();
                    break;
                default:
                    rEx = new SystemBusyException();
                    break;
            }

            return rEx;
        }
    }

    #region Exceptions
    public class SystemBusyException : BaseWechatException
    {
        public SystemBusyException()
        {
            this.ErrorCode = -1;
            this.ErrorMessage = @"系统繁忙，请稍候再试";
        }
    }

    public class Access_TokenErrorException : BaseWechatException
    {
        public Access_TokenErrorException()
        {
            this.ErrorCode = 40001;
            this.ErrorMessage = @"获取access_token时AppSecret错误，或者access_token无效。请开发者认真比对AppSecret的正确性，或查看是否正在为恰当的公众号调用接口";
        }
    }

    public class InavalidSecretException : BaseWechatException
    {
        public InavalidSecretException()
        {
            this.ErrorCode = 40002;
            this.ErrorMessage = @"不合法的凭证类型";
        }
    }

    public class InavalidOpenIDException : BaseWechatException
    {
        public InavalidOpenIDException()
        {
            this.ErrorCode = 40003;
            this.ErrorMessage = @"不合法的OpenID，请开发者确认OpenID（该用户）是否已关注公众号，或是否是其他公众号的OpenID";
        }
    }

    public class InavalidMediaTypeException : BaseWechatException
    {
        public InavalidMediaTypeException()
        {
            this.ErrorCode = 40004;
            this.ErrorMessage = @"不合法的媒体文件类型";
        }
    }
    #endregion
}
