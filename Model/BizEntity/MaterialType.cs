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
	[Alias("MaterialType")]
    public partial class MaterialType 
    {
        [Required]
		[PrimaryKey]
        public int MaterialTypew { get; set;}
        [Required]
        public string Desp { get; set;}
        public bool? ActFlag { get; set;}
        public string Remark { get; set;}
        public string CreateUser { get; set;}
        public DateTime? CreateTime { get; set;}
        public string UpdateUser { get; set;}
        public DateTime? 更新时间 { get; set;}
    }
}
#pragma warning restore 1591