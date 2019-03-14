using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries.Trees;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 资源查询参数
    /// </summary>
    public class ResourceQuery : TreeQueryParameter {
        /// <summary>
        /// 资源编号（ResourceId）
        /// </summary>
        [Display(Name="资源编号（ResourceId）")]
        public Guid? ResourceId { get; set; }
        
        private string _uri = string.Empty;
        /// <summary>
        /// 资源标识
        /// </summary>
        [Display(Name="资源标识")]
        public string Uri {
            get => _uri == null ? string.Empty : _uri.Trim();
            set => _uri = value;
        }
        
        private string _name = string.Empty;
        /// <summary>
        /// 资源名称
        /// </summary>
        [Display(Name="资源名称")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        /// <summary>
        /// 资源类型
        /// </summary>
        [Display(Name="资源类型")]
        public int? Type { get; set; }
        
        private string _note = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name="备注")]
        public string Note {
            get => _note == null ? string.Empty : _note.Trim();
            set => _note = value;
        }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Display(Name="是否末级")]
        public byte? IsLeave { get; set; }
        
        private string _path = string.Empty;
        /// <summary>
        /// 路径
        /// </summary>
        [Display(Name="路径")]
        public string Path {
            get => _path == null ? string.Empty : _path.Trim();
            set => _path = value;
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
        
        private string _pinYin = string.Empty;
        /// <summary>
        /// PinYin
        /// </summary>
        [Display(Name="PinYin")]
        public string PinYin {
            get => _pinYin == null ? string.Empty : _pinYin.Trim();
            set => _pinYin = value;
        }
        /// <summary>
        /// IsEnabled
        /// </summary>
        [Display(Name="IsEnabled")]
        public byte? Enabled { get; set; }
        /// <summary>
        /// AppId
        /// </summary>
        [Display(Name="AppId")]
        public Guid? AppId { get; set; }
    }
}