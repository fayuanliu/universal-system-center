using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Trees;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 地区
    /// </summary>
    [Description( "地区" )]
    public partial class Area : TreeEntityBase<Area>,IDelete,IAudited {
        /// <summary>
        /// 初始化地区
        /// </summary>
        public Area()
            : this( Guid.Empty, "", 0 ) {
        }

        /// <summary>
        /// 初始化地区
        /// </summary>
        /// <param name="id">地区标识</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        public Area( Guid id, string path, int level )
            : base( id, path, level ) {
        }

        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "编码不能为空")]
        [StringLength( 100, ErrorMessage = "编码输入过长，不能超过100位" )]
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 200, ErrorMessage = "名称输入过长，不能超过200位" )]
        public string Name { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public decimal? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal? Latitude { get; set; }
        /// <summary>
        /// 全路径（FullPath）
        /// </summary>
        [StringLength( 1000, ErrorMessage = "全路径（FullPath）输入过长，不能超过1000位" )]
        public string FullPath { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Required(ErrorMessage = "拼音简码不能为空")]
        [StringLength( 200, ErrorMessage = "拼音简码输入过长，不能超过200位" )]
        public string PinYin { get; set; }
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 500, ErrorMessage = "全拼输入过长，不能超过500位" )]
        public string FullPinYin { get; set; }
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
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        public bool IsLeave { get; set; }
        /// <summary>
        /// GPSLongitude
        /// </summary>
        public decimal? GPSLongitude { get; set; }
        /// <summary>
        /// GPSLatitude
        /// </summary>
        public decimal? GPSLatitude { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Code );
            AddDescription( t => t.Name );
            AddDescription( t => t.Longitude );
            AddDescription( t => t.Latitude );
            AddDescription( t => t.ParentId );
            AddDescription( t => t.Path );
            AddDescription( t => t.FullPath );
            AddDescription( t => t.Level );
            AddDescription( t => t.Enabled );
            AddDescription( t => t.SortId );
            AddDescription( t => t.PinYin );
            AddDescription( t => t.FullPinYin );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
            AddDescription( t => t.IsLeave );
            AddDescription( t => t.GPSLongitude );
            AddDescription( t => t.GPSLatitude );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Area other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Code, other.Code );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Longitude, other.Longitude );
            AddChange( t => t.Latitude, other.Latitude );
            AddChange( t => t.ParentId, other.ParentId );
            AddChange( t => t.Path, other.Path );
            AddChange( t => t.FullPath, other.FullPath );
            AddChange( t => t.Level, other.Level );
            AddChange( t => t.Enabled, other.Enabled );
            AddChange( t => t.SortId, other.SortId );
            AddChange( t => t.PinYin, other.PinYin );
            AddChange( t => t.FullPinYin, other.FullPinYin );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
            AddChange( t => t.IsLeave, other.IsLeave );
            AddChange( t => t.GPSLongitude, other.GPSLongitude );
            AddChange( t => t.GPSLatitude, other.GPSLatitude );
        }
    }
}