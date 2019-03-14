using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 应用程序查询参数
    /// </summary>
    public class ApplicationQuery : QueryParameter {
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display(Name="应用程序编号（AppId）")]
        public Guid? AppId { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Display(Name="名称（Name）")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _clientId = string.Empty;
        /// <summary>
        /// 客户端编号
        /// </summary>
        [Display(Name="客户端编号")]
        public string ClientId {
            get => _clientId == null ? string.Empty : _clientId.Trim();
            set => _clientId = value;
        }
        
        private string _note = string.Empty;
        /// <summary>
        /// 描述（Note）
        /// </summary>
        [Display(Name="描述（Note）")]
        public string Note {
            get => _note == null ? string.Empty : _note.Trim();
            set => _note = value;
        }
        /// <summary>
        /// 启用（Enabled）
        /// </summary>
        [Display(Name="启用（Enabled）")]
        public byte? IsEnabled { get; set; }
        
        private string _versionNo = string.Empty;
        /// <summary>
        /// 版本
        /// </summary>
        [Display(Name="版本")]
        public string VersionNo {
            get => _versionNo == null ? string.Empty : _versionNo.Trim();
            set => _versionNo = value;
        }
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