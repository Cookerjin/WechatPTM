using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Model.WechatEntity
{
    public class WcVideoMessage:WcBaseMessage
    {
        public string MediaId { get; set; }

        /// <summary>
        /// 缩略图MediaId
        /// </summary>
        public string ThumbMediaId { get; set; }

        public double MsgId { get; set; }
    }
}
