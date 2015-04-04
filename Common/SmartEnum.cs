using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPTM.Common
{
    public static class SmartEnum
    {
        public static string GetEnumName<T>(int key)
        {
            //如果值越界，返回空字符串
            return Enum.GetName(typeof(T), key);
        }

        public static int GetEnumValue<T>(T t)
        {
            return Convert.ToInt32(t);
        }

        public static int GetEnumValue<T>(string name)
        {
            var o  = (T)Enum.Parse(typeof(T), name, true);
            if (o != null)
            {
                return Convert.ToInt32(o);
            }
            else
            {
                return -99;
            }
            
        }
    }
}
