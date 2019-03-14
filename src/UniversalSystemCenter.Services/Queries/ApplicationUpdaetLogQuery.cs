using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 应用更新日志查询参数
    /// </summary>
    public class ApplicationUpdaetLogQuery : QueryParameter {
        /// <summary>
        /// 日志编号
        /// </summary>
        [Display(Name="日志编号")]
        public Guid? LogId { get; set; }
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display(Name="应用程序编号（AppId）")]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 起始更新时间
        /// </summary>
        [Display( Name = "起始更新时间" )]
        public DateTime? BeginUpdateTime { get; set; }
        /// <summary>
        /// 结束更新时间
        /// </summary>
        [Display( Name = "结束更新时间" )]
        public DateTime? EndUpdateTime { get; set; }
        
        private string _versionNO = string.Empty;
        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name="版本号")]
        public string VersionNO {
            get => _versionNO == null ? string.Empty : _versionNO.Trim();
            set => _versionNO = value;
        }
        
        private string _content = string.Empty;
        /// <summary>
        /// 更新内容
        /// </summary>
        [Display(Name="更新内容")]
        public string Content {
            get => _content == null ? string.Empty : _content.Trim();
            set => _content = value;
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
    }
}