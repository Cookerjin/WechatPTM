using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using ServiceStack.Configuration;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;

namespace WechatPTM.DAL
{
    public abstract class BaseDAL: IDal
    {
        private IDbConnection _db;
        private IDbTransaction _trans;
        private void OpenConnection()
        {
            var conncetionStr = System.Configuration.ConfigurationManager.ConnectionStrings["WechatMS"].ConnectionString;
            var dbFactory = new OrmLiteConnectionFactory(conncetionStr,SqlServerDialect.Provider);
            _db = dbFactory.OpenDbConnection();
     
        }
        public void OpenTransaction()
        {
            OpenConnection();
        }
        public void OpenTransaction(IsolationLevel level)
        {
            OpenConnection();
            _trans = _db.OpenTransaction(level);
        }

        public void TransCommit()
        {
            _trans.Commit();
            _db.Close();
        }
    }
}
