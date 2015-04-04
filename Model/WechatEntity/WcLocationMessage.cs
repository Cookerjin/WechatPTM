using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Model.WechatEntity
{
    public class WcLocationMessage:WcBaseMessage
    {
        /// <summary>
        /// 地理位置维度
        /// </summary>
        public float Location_X { get; set; }

        /// <summary>
        /// 地理位置经度
        /// </summary>
        public float Location_Y { get; set; }


        /// <summary>
        /// 地图放大缩小
        /// </summary>
        public int Scale { get; set; }


        /// <summary>
        /// 地理位置信息
        /// </summary>
        public string Label { get; set; }

        public double MsgId { get; set; }
    }
}
