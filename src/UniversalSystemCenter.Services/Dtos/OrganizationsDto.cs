using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Applications.Trees;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 组织机构数据传输对象
    /// </summary>
    
    public class OrganizationsDto : TreeDtoBase {
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display( Name = "商户编号" )]
        [DataMember]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Required(ErrorMessage = "名称（Name）不能为空")]
        [StringLength( 100, ErrorMessage = "名称（Name）输入过长，不能超过100位" )]
        [Display( Name = "名称（Name）" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 类型（Type）
        /// </summary>
        [Required(ErrorMessage = "类型（Type）不能为空")]
        [Display( Name = "类型（Type）" )]
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Required(ErrorMessage = "状态（State）不能为空")]
        [Display( Name = "状态（State）" )]
        [DataMember]
        public int State { get; set; }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        [Required(ErrorMessage = "是否隐藏（Hide）不能为空")]
        [Display( Name = "是否隐藏（Hide）" )]
        [DataMember]
        public bool IsOpen { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        [Display( Name = "是否末级" )]
        [DataMember]
        public bool IsLeave { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Required(ErrorMessage = "拼音简码不能为空")]
        [StringLength( 30, ErrorMessage = "拼音简码输入过长，不能超过30位" )]
        [Display( Name = "拼音简码" )]
        [DataMember]
        public string PinYin { get; set; }
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
        /// 部门全路径
        /// </summary>
        [StringLength( 1000, ErrorMessage = "部门全路径输入过长，不能超过1000位" )]
        [Display( Name = "部门全路径" )]
        [DataMember]
        public string FullPath { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        [Required(ErrorMessage = "负责人不能为空")]
        [Display( Name = "负责人" )]
        [DataMember]
        public Guid OrgChargeUid { get; set; }
        /// <summary>
        /// 地区编号
        /// </summary>
        [Required(ErrorMessage = "地区编号不能为空")]
        [StringLength( 200, ErrorMessage = "地区编号输入过长，不能超过200位" )]
        [Display( Name = "地区编号" )]
        [DataMember]
        public string AddressId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [StringLength( 500, ErrorMessage = "详细地址输入过长，不能超过500位" )]
        [Display( Name = "详细地址" )]
        [DataMember]
        public string AddressDetail { get; set; }
        /// <summary>
        /// 地址 省市区
        /// </summary>
        [Required(ErrorMessage = "地址 省市区不能为空")]
        [StringLength( 200, ErrorMessage = "地址 省市区输入过长，不能超过200位" )]
        [Display( Name = "地址 省市区" )]
        [DataMember]
        public string AddressName { get; set; }
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
        /// GPS经度
        /// </summary>
        [Display( Name = "GPS经度" )]
        [DataMember]
        public decimal? GPSLongitude { get; set; }
        /// <summary>
        /// GPS纬度
        /// </summary>
        [Display( Name = "GPS纬度" )]
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