using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models
{
    /// <summary>
    /// 应用程序
    /// </summary>
    [DisplayName("应用程序")]
    public partial class Application : AggregateRoot<Application>, IDelete, IAudited
    {
        /// <summary>
        /// 初始化应用程序
        /// </summary>
        public Application() : this(Guid.Empty)
        {
        }

        /// <summary>
        /// 初始化应用程序
        /// </summary>
        /// <param name="id">应用程序标识</param>
        public Application(Guid id) : base(id)
        {
            ApplicationUpdaetLogs = new List<ApplicationUpdaetLog>();
            Menus = new List<Menu>();
            MerchantApps = new List<MerchantApp>();
            Resources = new List<Resource>();
        }

        /// <summary>
        /// 名称（Name）
        /// </summary>
        [DisplayName("名称（Name）")]
        [Required(ErrorMessage = "名称（Name）不能为空")]
        [StringLength(100, ErrorMessage = "名称（Name）输入过长，不能超过100位")]
        public string Name { get; set; }
        /// <summary>
        /// 客户端编号
        /// </summary>
        [DisplayName("客户端编号")]
        [Required(ErrorMessage = "客户端编号不能为空")]
        [StringLength(50, ErrorMessage = "客户端编号输入过长，不能超过50位")]
        public string ClientId { get; set; }
        /// <summary>
        /// 描述（Note）
        /// </summary>
        [DisplayName("描述（Note）")]
        [StringLength(500, ErrorMessage = "描述（Note）输入过长，不能超过500位")]
        public string Note { get; set; }
        /// <summary>
        /// 启用（Enabled）
        /// </summary>
        [DisplayName("启用（Enabled）")]
        [Required(ErrorMessage = "启用（Enabled）不能为空")]
        public byte IsEnabled { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        [DisplayName("版本")]
        [StringLength(50, ErrorMessage = "版本输入过长，不能超过50位")]
        public string VersionNo { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName("创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName("最后修改时间")]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [DisplayName("最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName("是否删除")]
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }

        public virtual ICollection<ApplicationUpdaetLog> ApplicationUpdaetLogs { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<MerchantApp> MerchantApps { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions()
        {
            AddDescription(t => t.Id);
            AddDescription(t => t.Name);
            AddDescription(t => t.ClientId);
            AddDescription(t => t.Note);
            AddDescription(t => t.IsEnabled);
            AddDescription(t => t.VersionNo);
            AddDescription(t => t.CreationTime);
            AddDescription(t => t.CreatorId);
            AddDescription(t => t.LastModificationTime);
            AddDescription(t => t.LastModifierId);
            AddDescription(t => t.IsDeleted);
        }

        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges(Application other)
        {
            AddChange(t => t.Id, other.Id);
            AddChange(t => t.Name, other.Name);
            AddChange(t => t.ClientId, other.ClientId);
            AddChange(t => t.Note, other.Note);
            AddChange(t => t.IsEnabled, other.IsEnabled);
            AddChange(t => t.VersionNo, other.VersionNo);
            AddChange(t => t.CreationTime, other.CreationTime);
            AddChange(t => t.CreatorId, other.CreatorId);
            AddChange(t => t.LastModificationTime, other.LastModificationTime);
            AddChange(t => t.LastModifierId, other.LastModifierId);
            AddChange(t => t.IsDeleted, other.IsDeleted);
        }
    }
}