using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Model.WechatEntity
{
    public class WcImageMessage:WcBaseMessage
    {
        public string PicUrl { get; set; }
        public string MediaId { get; set; }
        public double MsgId { get; set; }
    }
}
