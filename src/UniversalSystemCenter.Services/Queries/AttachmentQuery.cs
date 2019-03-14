using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 附件查询参数
    /// </summary>
    public class AttachmentQuery : QueryParameter {
        /// <summary>
        /// 附件编号（AttachmentId）
        /// </summary>
        [Display(Name="附件编号（AttachmentId）")]
        public Guid? AttachmentId { get; set; }
        
        private string _fileName = string.Empty;
        /// <summary>
        /// 附件名称（FileName)
        /// </summary>
        [Display(Name="附件名称（FileName)")]
        public string FileName {
            get => _fileName == null ? string.Empty : _fileName.Trim();
            set => _fileName = value;
        }
        
        private string _fileType = string.Empty;
        /// <summary>
        /// 文件类型（FileType）
        /// </summary>
        [Display(Name="文件类型（FileType）")]
        public string FileType {
            get => _fileType == null ? string.Empty : _fileType.Trim();
            set => _fileType = value;
        }
        /// <summary>
        /// 文件大小（Size）
        /// </summary>
        [Display(Name="文件大小（Size）")]
        public long? Size { get; set; }
        
        private string _remoteUrl = string.Empty;
        /// <summary>
        /// 远程路径（RemoteUrl）
        /// </summary>
        [Display(Name="远程路径（RemoteUrl）")]
        public string RemoteUrl {
            get => _remoteUrl == null ? string.Empty : _remoteUrl.Trim();
            set => _remoteUrl = value;
        }
        
        private string _localUrl = string.Empty;
        /// <summary>
        /// 本地路径（LocalUrl）
        /// </summary>
        [Display(Name="本地路径（LocalUrl）")]
        public string LocalUrl {
            get => _localUrl == null ? string.Empty : _localUrl.Trim();
            set => _localUrl = value;
        }
        /// <summary>
        /// 宽（Width）
        /// </summary>
        [Display(Name="宽（Width）")]
        public int? Width { get; set; }
        /// <summary>
        /// 高（Height）
        /// </summary>
        [Display(Name="高（Height）")]
        public int? Height { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display(Name="商户编号")]
        public Guid? MerchantId { get; set; }
        
        private string _module = string.Empty;
        /// <summary>
        /// 所属模块（Module）
        /// </summary>
        [Display(Name="所属模块（Module）")]
        public string Module {
            get => _module == null ? string.Empty : _module.Trim();
            set => _module = value;
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