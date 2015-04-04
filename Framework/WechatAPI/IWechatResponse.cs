using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Framework.WechatAPI.Interface
{
    public interface IWechatResponse
    {
        object WechatResponse(object WechatRequsetContext);
    }
}
