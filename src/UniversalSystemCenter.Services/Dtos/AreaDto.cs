using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Applications.Trees;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 地区数据传输对象
    /// </summary>
    
    public class AreaDto : TreeDtoBase {
        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "编码不能为空")]
        [StringLength( 100, ErrorMessage = "编码输入过长，不能超过100位" )]
        [Display( Name = "编码" )]
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 200, ErrorMessage = "名称输入过长，不能超过200位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        [Display( Name = "经度" )]
        [DataMember]
        public decimal? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        [Display( Name = "纬度" )]
        [DataMember]
        public decimal? Latitude { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        [Required(ErrorMessage = "路径不能为空")]
        [StringLength( 800, ErrorMessage = "路径输入过长，不能超过800位" )]
        [Display( Name = "路径" )]
        [DataMember]
        public string Path { get; set; }
        /// <summary>
        /// 全路径（FullPath）
        /// </summary>
        [StringLength( 1000, ErrorMessage = "全路径（FullPath）输入过长，不能超过1000位" )]
        [Display( Name = "全路径（FullPath）" )]
        [DataMember]
        public string FullPath { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Required(ErrorMessage = "拼音简码不能为空")]
        [StringLength( 200, ErrorMessage = "拼音简码输入过长，不能超过200位" )]
        [Display( Name = "拼音简码" )]
        [DataMember]
        public string PinYin { get; set; }
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 500, ErrorMessage = "全拼输入过长，不能超过500位" )]
        [Display( Name = "全拼" )]
        [DataMember]
        public string FullPinYin { get; set; }
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
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        [Display( Name = "是否末级" )]
        [DataMember]
        public bool IsLeave { get; set; }
        /// <summary>
        /// GPSLongitude
        /// </summary>
        [Display( Name = "GPSLongitude" )]
        [DataMember]
        public decimal? GPSLongitude { get; set; }
        /// <summary>
        /// GPSLatitude
        /// </summary>
        [Display( Name = "GPSLatitude" )]
        [DataMember]
        public decimal? GPSLatitude { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}