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
    /// 菜单
    /// </summary>
    [Description( "菜单" )]
    public partial class Menu : TreeEntityBase<Menu>,IDelete,IAudited {
        /// <summary>
        /// 初始化菜单
        /// </summary>
        public Menu()
            : this( Guid.Empty, "", 0 ) {
        }

        /// <summary>
        /// 初始化菜单
        /// </summary>
        /// <param name="id">菜单标识</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        public Menu( Guid id, string path, int level )
            : base( id, path, level ) {
            RoleMenus = new List<RoleMenu>();
        }

        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        public Guid? AppId { get; set; }
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Required(ErrorMessage = "名称（Name）不能为空")]
        [StringLength( 200, ErrorMessage = "名称（Name）输入过长，不能超过200位" )]
        public string Name { get; set; }
        /// <summary>
        /// 是否是菜单组（Group）
        /// </summary>
        [Required(ErrorMessage = "是否是菜单组（Group）不能为空")]
        public bool IsGroup { get; set; }
        /// <summary>
        /// 链接、路由（Link）
        /// </summary>
        [StringLength( 500, ErrorMessage = "链接、路由（Link）输入过长，不能超过500位" )]
        public string Link { get; set; }
        /// <summary>
        /// 中文路径
        /// </summary>
        [StringLength( 800, ErrorMessage = "中文路径输入过长，不能超过800位" )]
        public string PathText { get; set; }
        /// <summary>
        /// 图标（Icon）
        /// </summary>
        [StringLength( 100, ErrorMessage = "图标（Icon）输入过长，不能超过100位" )]
        public string Icon { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        public bool IsLeave { get; set; }
        /// <summary>
        /// 徽章（Badge）
        /// </summary>
        [StringLength( 20, ErrorMessage = "徽章（Badge）输入过长，不能超过20位" )]
        public string Badge { get; set; }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        [Required(ErrorMessage = "是否隐藏（Hide）不能为空")]
        public bool IsOpen { get; set; }
        /// <summary>
        /// 分类编码
        /// </summary>
        [Required(ErrorMessage = "分类编码不能为空")]
        [StringLength( 50, ErrorMessage = "分类编码输入过长，不能超过50位" )]
        public string Code { get; set; }
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
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 应用程序
        /// </summary>
        [ForeignKey( "AppId" )]
        public Application Application { get; set; }

        /// <summary>
        /// 角色菜单
        /// </summary>
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.AppId );
            AddDescription( t => t.Name );
            AddDescription( t => t.IsGroup );
            AddDescription( t => t.Link );
            AddDescription( t => t.PathText );
            AddDescription( t => t.Icon );
            AddDescription( t => t.IsLeave );
            AddDescription( t => t.Badge );
            AddDescription( t => t.IsOpen );
            AddDescription( t => t.Code );
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
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Menu other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.AppId, other.AppId );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.IsGroup, other.IsGroup );
            AddChange( t => t.Link, other.Link );
            AddChange( t => t.PathText, other.PathText );
            AddChange( t => t.Icon, other.Icon );
            AddChange( t => t.IsLeave, other.IsLeave );
            AddChange( t => t.Badge, other.Badge );
            AddChange( t => t.IsOpen, other.IsOpen );
            AddChange( t => t.Code, other.Code );
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
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }
}