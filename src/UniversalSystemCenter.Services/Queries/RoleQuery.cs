using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 角色查询参数
    /// </summary>
    public class RoleQuery : QueryParameter {
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Display(Name="类型编号（TypeId）")]
        public Guid? RoleId { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Display(Name="名称（Name）")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _values = string.Empty;
        /// <summary>
        /// 值（Values)
        /// </summary>
        [Display(Name="值（Values)")]
        public string Values {
            get => _values == null ? string.Empty : _values.Trim();
            set => _values = value;
        }
        
        private string _icon = string.Empty;
        /// <summary>
        /// 图标（Icon）
        /// </summary>
        [Display(Name="图标（Icon）")]
        public string Icon {
            get => _icon == null ? string.Empty : _icon.Trim();
            set => _icon = value;
        }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public byte? IsEnabled { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [Display(Name="排序号")]
        public int? SortId { get; set; }
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
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display(Name="商户编号")]
        public Guid? MerchantId { get; set; }
    }
}