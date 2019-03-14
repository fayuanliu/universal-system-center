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
    /// 附件
    /// </summary>
    [DisplayName( "附件" )]
    public partial class Attachment : AggregateRoot<Attachment>,IDelete,IAudited {
        /// <summary>
        /// 初始化附件
        /// </summary>
        public Attachment() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化附件
        /// </summary>
        /// <param name="id">附件标识</param>
        public Attachment( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 附件名称（FileName)
        /// </summary>
        [DisplayName( "附件名称（FileName)" )]
        [StringLength( 256, ErrorMessage = "附件名称（FileName)输入过长，不能超过256位" )]
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型（FileType）
        /// </summary>
        [DisplayName( "文件类型（FileType）" )]
        [StringLength( 20, ErrorMessage = "文件类型（FileType）输入过长，不能超过20位" )]
        public string FileType { get; set; }
        /// <summary>
        /// 文件大小（Size）
        /// </summary>
        [DisplayName( "文件大小（Size）" )]
        public long? Size { get; set; }
        /// <summary>
        /// 远程路径（RemoteUrl）
        /// </summary>
        [DisplayName( "远程路径（RemoteUrl）" )]
        [StringLength( 500, ErrorMessage = "远程路径（RemoteUrl）输入过长，不能超过500位" )]
        public string RemoteUrl { get; set; }
        /// <summary>
        /// 本地路径（LocalUrl）
        /// </summary>
        [DisplayName( "本地路径（LocalUrl）" )]
        [StringLength( 500, ErrorMessage = "本地路径（LocalUrl）输入过长，不能超过500位" )]
        public string LocalUrl { get; set; }
        /// <summary>
        /// 宽（Width）
        /// </summary>
        [DisplayName( "宽（Width）" )]
        [Required(ErrorMessage = "宽（Width）不能为空")]
        public int Width { get; set; }
        /// <summary>
        /// 高（Height）
        /// </summary>
        [DisplayName( "高（Height）" )]
        [Required(ErrorMessage = "高（Height）不能为空")]
        public int Height { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [DisplayName( "商户编号" )]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 所属模块（Module）
        /// </summary>
        [DisplayName( "所属模块（Module）" )]
        [StringLength( 200, ErrorMessage = "所属模块（Module）输入过长，不能超过200位" )]
        public string Module { get; set; }
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
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.FileName );
            AddDescription( t => t.FileType );
            AddDescription( t => t.Size );
            AddDescription( t => t.RemoteUrl );
            AddDescription( t => t.LocalUrl );
            AddDescription( t => t.Width );
            AddDescription( t => t.Height );
            AddDescription( t => t.MerchantId );
            AddDescription( t => t.Module );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Attachment other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.FileName, other.FileName );
            AddChange( t => t.FileType, other.FileType );
            AddChange( t => t.Size, other.Size );
            AddChange( t => t.RemoteUrl, other.RemoteUrl );
            AddChange( t => t.LocalUrl, other.LocalUrl );
            AddChange( t => t.Width, other.Width );
            AddChange( t => t.Height, other.Height );
            AddChange( t => t.MerchantId, other.MerchantId );
            AddChange( t => t.Module, other.Module );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }
}