using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WechatPTM.Model.BizEntity;
using System.Data;
using ServiceStack.OrmLite;

namespace WechatPTM.BL.UserMaintainBL
{
    public class BrandBL:BaseBL
    {
        public bool CreateNewBrand(Brand brand)
        {            
            bool b = false;
            using (IDbConnection db = this.dbFactory.OpenDbConnection())
            {
                b=db.Save<Brand>(brand);
            }

            return b;
        }

        public bool DeleteBrand(int brandId)
        {            
            bool b = false;
            using (IDbConnection db = this.dbFactory.OpenDbConnection())
            {
                int i = db.UpdateNonDefaults<Brand>(new Brand{ ActFlag = false }, p => p.BrandID == brandId);
                b = (i > 0);
            }
            return b;
        }

        public Brand GetBrand(int brandId)
        {
            using (IDbConnection db = this.dbFactory.OpenDbConnection())
            {
                return db.Single<Brand>(x => x.BrandID == brandId);
            }
        }

        public List<Brand> SelectBrand(Brand condition)
        {
            List<Brand> lst = new List<Brand>();
            using (IDbConnection db = this.dbFactory.OpenDbConnection())
            {
                lst = db.Select<Brand>("");
            }

            return lst;
        }
    }
}
