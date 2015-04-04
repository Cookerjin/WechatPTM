using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Model.WechatEntity
{
    public class WcTextMessage:WcBaseMessage
    {
        public string Content { get; set; }

        public double MsgId { get;set; }
        
    }
}
