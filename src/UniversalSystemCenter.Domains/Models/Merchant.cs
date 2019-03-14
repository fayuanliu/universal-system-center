using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 商户
    /// </summary>
    [DisplayName( "商户" )]
    public partial class Merchant : AggregateRoot<Merchant>,IDelete,IAudited {
        /// <summary>
        /// 初始化商户
        /// </summary>
        public Merchant() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化商户
        /// </summary>
        /// <param name="id">商户标识</param>
        public Merchant( Guid id ) : base( id ) {
            MerchantApps = new List<MerchantApp>();
            Organizations = new List<Organizations>();
            Positions = new List<Position>();
            Roles = new List<Role>();
            Users = new List<User>();
        }

        /// <summary>
        /// 商户名称
        /// </summary>
        [DisplayName( "商户名称" )]
        [Required(ErrorMessage = "商户名称不能为空")]
        [StringLength( 200, ErrorMessage = "商户名称输入过长，不能超过200位" )]
        public string Name { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [DisplayName( "启用" )]
        [Required(ErrorMessage = "启用不能为空")]
        public byte IsEnabled { get; set; }
        /// <summary>
        /// 商户类型（个体，公司、业务单位、政府部门）
        /// </summary>
        [DisplayName( "商户类型（个体，公司、业务单位、政府部门）" )]
        [Required(ErrorMessage = "商户类型（个体，公司、业务单位、政府部门）不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 分销级别
        /// </summary>
        [DisplayName( "分销级别" )]
        [Required(ErrorMessage = "分销级别不能为空")]
        public byte IsDistribution { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName( "创建人" )]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName( "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [DisplayName( "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }

        public virtual ICollection<MerchantApp> MerchantApps { get; set; }

        public virtual ICollection<Organizations> Organizations { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Name );
            AddDescription( t => t.IsEnabled );
            AddDescription( t => t.Type );
            AddDescription( t => t.IsDistribution );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Merchant other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.IsEnabled, other.IsEnabled );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.IsDistribution, other.IsDistribution );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }
}