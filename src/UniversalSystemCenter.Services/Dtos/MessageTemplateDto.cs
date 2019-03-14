using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 消息模板数据传输对象
    /// </summary>
    [Model("model")]
    public class MessageTemplateDto : DtoBase {
        /// <summary>
        /// 所属消息分类
        /// </summary>
        [Required(ErrorMessage = "所属消息分类不能为空")]
        [Display( Name = "所属消息分类" )]
        [DataMember]
        public Guid CategoryId { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        [Required(ErrorMessage = "模板类型不能为空")]
        [Display( Name = "模板类型" )]
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// 模板编码
        /// </summary>
        [Display( Name = "模板编码" )]
        [DataMember]
        public Guid? SendObject { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        [Required(ErrorMessage = "模板名称不能为空")]
        [StringLength( 50, ErrorMessage = "模板名称输入过长，不能超过50位" )]
        [Display( Name = "模板名称" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 资源编号
        /// </summary>
        [StringLength( 200, ErrorMessage = "资源编号输入过长，不能超过200位" )]
        [Display( Name = "资源编号" )]
        [DataMember]
        public string SourceId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [StringLength( 50, ErrorMessage = "标题输入过长，不能超过50位" )]
        [Display( Name = "标题" )]
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        [StringLength( 16, ErrorMessage = "模板内容输入过长，不能超过16位" )]
        [Display( Name = "模板内容" )]
        [DataMember]
        public string Content { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Display( Name = "启用" )]
        [DataMember]
        public bool IsEnabled { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [Required(ErrorMessage = "排序号不能为空")]
        [Display( Name = "排序号" )]
        [DataMember]
        public int SortId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}