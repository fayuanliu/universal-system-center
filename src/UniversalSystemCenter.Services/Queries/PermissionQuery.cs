using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 权限查询参数
    /// </summary>
    public class PermissionQuery : QueryParameter {
        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [Display(Name="权限编号（PermissionId）")]
        public Guid? PermissionId { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 权限名称（Name)
        /// </summary>
        [Display(Name="权限名称（Name)")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _code = string.Empty;
        /// <summary>
        /// 权限点（Code）
        /// </summary>
        [Display(Name="权限点（Code）")]
        public string Code {
            get => _code == null ? string.Empty : _code.Trim();
            set => _code = value;
        }
        /// <summary>
        /// 资源编号（ResourceId）
        /// </summary>
        [Display(Name="资源编号（ResourceId）")]
        public Guid? ResourceId { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public byte? IsEnabled { get; set; }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModificationTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name="最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name="是否删除")]
        public byte? IsDeleted { get; set; }
    }
}