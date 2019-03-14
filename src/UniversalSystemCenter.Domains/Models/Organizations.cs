using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Trees;
using Util.Domains.Auditing;
using Util.Domains.Tenants;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 组织机构
    /// </summary>
    [Description( "组织机构" )]
    public partial class Organizations : TreeEntityBase<Organizations>,IDelete,IAudited {
        /// <summary>
        /// 初始化组织机构
        /// </summary>
        public Organizations()
            : this( Guid.Empty, "", 0 ) {
        }

        /// <summary>
        /// 初始化组织机构
        /// </summary>
        /// <param name="id">组织机构标识</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        public Organizations( Guid id, string path, int level )
            : base( id, path, level ) {
            OrganizationsRegions = new List<OrganizationsRegion>();
            Users = new List<User>();
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Required(ErrorMessage = "名称（Name）不能为空")]
        [StringLength( 100, ErrorMessage = "名称（Name）输入过长，不能超过100位" )]
        public string Name { get; set; }
        /// <summary>
        /// 类型（Type）
        /// </summary>
        [Required(ErrorMessage = "类型（Type）不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Required(ErrorMessage = "状态（State）不能为空")]
        public int State { get; set; }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        [Required(ErrorMessage = "是否隐藏（Hide）不能为空")]
        public bool IsOpen { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        public bool IsLeave { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Required(ErrorMessage = "拼音简码不能为空")]
        [StringLength( 30, ErrorMessage = "拼音简码输入过长，不能超过30位" )]
        public string PinYin { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 部门全路径
        /// </summary>
        [StringLength( 1000, ErrorMessage = "部门全路径输入过长，不能超过1000位" )]
        public string FullPath { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        [Required(ErrorMessage = "负责人不能为空")]
        public Guid OrgChargeUid { get; set; }
        /// <summary>
        /// 地区编号
        /// </summary>
        [Required(ErrorMessage = "地区编号不能为空")]
        [StringLength( 200, ErrorMessage = "地区编号输入过长，不能超过200位" )]
        public string AddressId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [StringLength( 500, ErrorMessage = "详细地址输入过长，不能超过500位" )]
        public string AddressDetail { get; set; }
        /// <summary>
        /// 地址 省市区
        /// </summary>
        [Required(ErrorMessage = "地址 省市区不能为空")]
        [StringLength( 200, ErrorMessage = "地址 省市区输入过长，不能超过200位" )]
        public string AddressName { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public decimal? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal? Latitude { get; set; }
        /// <summary>
        /// GPS经度
        /// </summary>
        public decimal? GPSLongitude { get; set; }
        /// <summary>
        /// GPS纬度
        /// </summary>
        public decimal? GPSLatitude { get; set; }
        /// <summary>
        /// 商户
        /// </summary>
        [ForeignKey( "MerchantId" )]
        public Merchant Merchant { get; set; }

        public virtual ICollection<OrganizationsRegion> OrganizationsRegions { get; set; }

        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.MerchantId );
            AddDescription( t => t.Name );
            AddDescription( t => t.Type );
            AddDescription( t => t.State );
            AddDescription( t => t.IsOpen );
            AddDescription( t => t.IsLeave );
            AddDescription( t => t.ParentId );
            AddDescription( t => t.Path );
            AddDescription( t => t.Level );
            AddDescription( t => t.Enabled );
            AddDescription( t => t.SortId );
            AddDescription( t => t.PinYin );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.FullPath );
            AddDescription( t => t.IsDeleted );
            AddDescription( t => t.OrgChargeUid );
            AddDescription( t => t.AddressId );
            AddDescription( t => t.AddressDetail );
            AddDescription( t => t.AddressName );
            AddDescription( t => t.Longitude );
            AddDescription( t => t.Latitude );
            AddDescription( t => t.GPSLongitude );
            AddDescription( t => t.GPSLatitude );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Organizations other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.MerchantId, other.MerchantId );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.State, other.State );
            AddChange( t => t.IsOpen, other.IsOpen );
            AddChange( t => t.IsLeave, other.IsLeave );
            AddChange( t => t.ParentId, other.ParentId );
            AddChange( t => t.Path, other.Path );
            AddChange( t => t.Level, other.Level );
            AddChange( t => t.Enabled, other.Enabled );
            AddChange( t => t.SortId, other.SortId );
            AddChange( t => t.PinYin, other.PinYin );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.FullPath, other.FullPath );
            AddChange( t => t.IsDeleted, other.IsDeleted );
            AddChange( t => t.OrgChargeUid, other.OrgChargeUid );
            AddChange( t => t.AddressId, other.AddressId );
            AddChange( t => t.AddressDetail, other.AddressDetail );
            AddChange( t => t.AddressName, other.AddressName );
            AddChange( t => t.Longitude, other.Longitude );
            AddChange( t => t.Latitude, other.Latitude );
            AddChange( t => t.GPSLongitude, other.GPSLongitude );
            AddChange( t => t.GPSLatitude, other.GPSLatitude );
        }
    }
}