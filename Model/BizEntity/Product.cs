// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace WechatPTM.Model.BizEntity
{
	[Alias("Product")]
    public partial class Product 
    {
        [Required]
        public int BrandID { get; set;}
        [Required]
        public string SKU { get; set;}
        public string ProdName { get; set;}
        public string ProdShortName { get; set;}
        public string Desp { get; set;}
        public string ProdDetail { get; set;}
        public string Producer { get; set;}
        public string Spec { get; set;}
        public decimal? Price { get; set;}
        public int? Unit { get; set;}
        public int? ActFlag { get; set;}
        public string CreateUser { get; set;}
        public DateTime? CreateDate { get; set;}
        public string UpdateUser { get; set;}
        public DateTime? UpdateDate { get; set;}
    }
}
#pragma warning restore 1591
