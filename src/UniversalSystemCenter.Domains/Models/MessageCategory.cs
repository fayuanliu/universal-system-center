using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Trees;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models
{
    /// <summary>
    /// 消息类型
    /// </summary>
    [Description("消息类型")]
    public partial class MessageCategory : TreeEntityBase<MessageCategory>, IDelete, IAudited
    {
        /// <summary>
        /// 初始化消息类型
        /// </summary>
        public MessageCategory()
            : this(Guid.Empty, "", 0)
        {
        }

        /// <summary>
        /// 初始化消息类型
        /// </summary>
        /// <param name="id">消息类型标识</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        public MessageCategory(Guid id, string path, int level)
            : base(id, path, level)
        {
            MerchanAppMessageSets = new List<MerchanAppMessageSet>();
            MessageContents = new List<MessageContent>();
            MessageTemplates = new List<MessageTemplate>();
        }

        /// <summary>
        /// 分类名称
        /// </summary>
        [Required(ErrorMessage = "分类名称不能为空")]
        [StringLength(500, ErrorMessage = "分类名称输入过长，不能超过500位")]
        public string Name { get; set; }
        /// <summary>
        /// 消息类型(通知、代办)
        /// </summary>
        [Required(ErrorMessage = "消息类型(通知、代办)不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 所属平台
        /// </summary>
        [Required(ErrorMessage = "所属平台不能为空")]
        public int AppId { get; set; }
        /// <summary>
        /// 模块
        /// </summary>
        [StringLength(500, ErrorMessage = "模块输入过长，不能超过500位")]
        public string Module { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        [Required(ErrorMessage = "路径不能为空")]
        [StringLength(800, ErrorMessage = "路径输入过长，不能超过800位")]
        public string Path { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        public bool IsLeave { get; set; }
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
        public bool IsDeleted { get; set; }

        public virtual ICollection<MerchanAppMessageSet> MerchanAppMessageSets { get; set; }

        public virtual ICollection<MessageContent> MessageContents { get; set; }

        public virtual ICollection<MessageTemplate> MessageTemplates { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions()
        {
            AddDescription(t => t.Id);
            AddDescription(t => t.Name);
            AddDescription(t => t.Type);
            AddDescription(t => t.AppId);
            AddDescription(t => t.Module);
            AddDescription(t => t.ParentId);
            AddDescription(t => t.Path);
            AddDescription(t => t.Level);
            AddDescription(t => t.IsLeave);
            AddDescription(t => t.Enabled);
            AddDescription(t => t.SortId);
            AddDescription(t => t.CreationTime);
            AddDescription(t => t.CreatorId);
            AddDescription(t => t.LastModificationTime);
            AddDescription(t => t.LastModifierId);
        }

        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges(MessageCategory other)
        {
            AddChange(t => t.Id, other.Id);
            AddChange(t => t.Name, other.Name);
            AddChange(t => t.Type, other.Type);
            AddChange(t => t.AppId, other.AppId);
            AddChange(t => t.Module, other.Module);
            AddChange(t => t.ParentId, other.ParentId);
            AddChange(t => t.Path, other.Path);
            AddChange(t => t.Level, other.Level);
            AddChange(t => t.IsLeave, other.IsLeave);
            AddChange(t => t.Enabled, other.Enabled);
            AddChange(t => t.SortId, other.SortId);
            AddChange(t => t.CreationTime, other.CreationTime);
            AddChange(t => t.CreatorId, other.CreatorId);
            AddChange(t => t.LastModificationTime, other.LastModificationTime);
            AddChange(t => t.LastModifierId, other.LastModifierId);
        }
    }
}