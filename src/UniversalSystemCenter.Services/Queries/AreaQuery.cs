using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries.Trees;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 地区查询参数
    /// </summary>
    public class AreaQuery : TreeQueryParameter {
        /// <summary>
        /// 地区编号
        /// </summary>
        [Display(Name="地区编号")]
        public Guid? AreaId { get; set; }
        
        private string _code = string.Empty;
        /// <summary>
        /// 编码
        /// </summary>
        [Display(Name="编码")]
        public string Code {
            get => _code == null ? string.Empty : _code.Trim();
            set => _code = value;
        }
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name="名称")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        /// <summary>
        /// 经度
        /// </summary>
        [Display(Name="经度")]
        public decimal? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        [Display(Name="纬度")]
        public decimal? Latitude { get; set; }
        
        private string _path = string.Empty;
        /// <summary>
        /// 路径
        /// </summary>
        [Display(Name="路径")]
        public string Path {
            get => _path == null ? string.Empty : _path.Trim();
            set => _path = value;
        }
        
        private string _fullPath = string.Empty;
        /// <summary>
        /// 全路径（FullPath）
        /// </summary>
        [Display(Name="全路径（FullPath）")]
        public string FullPath {
            get => _fullPath == null ? string.Empty : _fullPath.Trim();
            set => _fullPath = value;
        }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public byte? Enabled { get; set; }
        
        private string _pinYin = string.Empty;
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Display(Name="拼音简码")]
        public string PinYin {
            get => _pinYin == null ? string.Empty : _pinYin.Trim();
            set => _pinYin = value;
        }
        
        private string _fullPinYin = string.Empty;
        /// <summary>
        /// 全拼
        /// </summary>
        [Display(Name="全拼")]
        public string FullPinYin {
            get => _fullPinYin == null ? string.Empty : _fullPinYin.Trim();
            set => _fullPinYin = value;
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
        /// <summary>
        /// 是否末级
        /// </summary>
        [Display(Name="是否末级")]
        public byte? IsLeave { get; set; }
        /// <summary>
        /// GPSLongitude
        /// </summary>
        [Display(Name="GPSLongitude")]
        public decimal? GPSLongitude { get; set; }
        /// <summary>
        /// GPSLatitude
        /// </summary>
        [Display(Name="GPSLatitude")]
        public decimal? GPSLatitude { get; set; }
    }
}