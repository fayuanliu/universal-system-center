using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 消息模板查询参数
    /// </summary>
    public class MessageTemplateQuery : QueryParameter {
        /// <summary>
        /// 模板编号
        /// </summary>
        [Display(Name="模板编号")]
        public Guid? TemplateId { get; set; }
        /// <summary>
        /// 所属消息分类
        /// </summary>
        [Display(Name="所属消息分类")]
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        [Display(Name="模板类型")]
        public int? Type { get; set; }
        /// <summary>
        /// 模板编码
        /// </summary>
        [Display(Name="模板编码")]
        public Guid? SendObject { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 模板名称
        /// </summary>
        [Display(Name="模板名称")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _sourceId = string.Empty;
        /// <summary>
        /// 资源编号
        /// </summary>
        [Display(Name="资源编号")]
        public string SourceId {
            get => _sourceId == null ? string.Empty : _sourceId.Trim();
            set => _sourceId = value;
        }
        
        private string _title = string.Empty;
        /// <summary>
        /// 标题
        /// </summary>
        [Display(Name="标题")]
        public string Title {
            get => _title == null ? string.Empty : _title.Trim();
            set => _title = value;
        }
        
        private string _content = string.Empty;
        /// <summary>
        /// 模板内容
        /// </summary>
        [Display(Name="模板内容")]
        public string Content {
            get => _content == null ? string.Empty : _content.Trim();
            set => _content = value;
        }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public bool? IsEnabled { get; set; }
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
        /// 最后修改人
        /// </summary>
        [Display(Name="最后修改人")]
        public Guid? LastModifierId { get; set; }
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
    }
}