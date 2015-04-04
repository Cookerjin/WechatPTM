using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WechatPTM.Common;
using WechatPTM.Common.SYSCONSTANT;

namespace WechatPTM.Model.WechatEntity
{
    /// <summary>
    /// wechat Message base class
    /// </summary>
    public class WcBaseMessage
    {
        
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public double CreateTime
        {
            get
            {
                return SmartDateTime.ConvertDateTimeToInt(DateTime.Now);
            }
        }
        public MessageType MsgType {get;set;}
        
        
    }
}
