using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 消息类型查询参数
    /// </summary>
    public class MessageCategoryQuery : QueryParameter {
        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [Display(Name="消息分类编号（MessageCategoryId）")]
        public Guid? CategoryId { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 分类名称
        /// </summary>
        [Display(Name="分类名称")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public byte? IsEnabled { get; set; }
        /// <summary>
        /// 消息类型(通知、代办)
        /// </summary>
        [Display(Name="消息类型(通知、代办)")]
        public int? Type { get; set; }
        /// <summary>
        /// 所属平台
        /// </summary>
        [Display(Name="所属平台")]
        public int? AppId { get; set; }
        
        private string _module = string.Empty;
        /// <summary>
        /// 模块
        /// </summary>
        [Display(Name="模块")]
        public string Module {
            get => _module == null ? string.Empty : _module.Trim();
            set => _module = value;
        }
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
    }
}