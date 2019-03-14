using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 部门业务区域数据传输对象
    /// </summary>
    
    public class OrganizationsRegionDto : DtoBase {
        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [Display( Name = "组织机构编号(OrganizationsId)" )]
        [DataMember]
        public Guid? OrganizationsId { get; set; }
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
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}