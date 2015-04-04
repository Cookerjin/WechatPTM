using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ServiceStack.OrmLite;

namespace WechatPTM.BL
{
    public class BaseBL
    {
        public string WcMS_ConnectionStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["WechatMS"].ConnectionString;
            }
        }


        public OrmLiteConnectionFactory dbFactory;

        public BaseBL()
        {
            this.dbFactory= new OrmLiteConnectionFactory(this.WcMS_ConnectionStr, SqlServerDialect.Provider);
        }
    }
}
