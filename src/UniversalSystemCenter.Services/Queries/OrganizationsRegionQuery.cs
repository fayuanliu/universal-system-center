using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 部门业务区域查询参数
    /// </summary>
    public class OrganizationsRegionQuery : QueryParameter {
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name="编号")]
        public Guid? DeptRegionId { get; set; }
        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [Display(Name="组织机构编号(OrganizationsId)")]
        public Guid? OrganizationsId { get; set; }
        
        private string _addressId = string.Empty;
        /// <summary>
        /// 地区编号
        /// </summary>
        [Display(Name="地区编号")]
        public string AddressId {
            get => _addressId == null ? string.Empty : _addressId.Trim();
            set => _addressId = value;
        }
        
        private string _addressDetail = string.Empty;
        /// <summary>
        /// 详细地址
        /// </summary>
        [Display(Name="详细地址")]
        public string AddressDetail {
            get => _addressDetail == null ? string.Empty : _addressDetail.Trim();
            set => _addressDetail = value;
        }
        
        private string _addressName = string.Empty;
        /// <summary>
        /// 地址 省市区
        /// </summary>
        [Display(Name="地址 省市区")]
        public string AddressName {
            get => _addressName == null ? string.Empty : _addressName.Trim();
            set => _addressName = value;
        }
    }
}