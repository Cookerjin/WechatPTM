using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Model.WechatEntity
{
    public class WcLinkMessage:WcBaseMessage
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public double MsgId { get; set; }
    }
}
