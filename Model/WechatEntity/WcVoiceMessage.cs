using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Model.WechatEntity
{
    public class WcVoiceMessage:WcBaseMessage
    {       
        public string MediaId { get; set; }
        public string Format { get; set; }
        public double MsgId { get; set; }
    }
}
