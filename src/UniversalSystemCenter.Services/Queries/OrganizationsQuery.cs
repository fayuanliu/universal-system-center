using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries.Trees;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 组织机构查询参数
    /// </summary>
    public class OrganizationsQuery : TreeQueryParameter {
        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [Display(Name="组织机构编号(OrganizationsId)")]
        public Guid? OrganizationsId { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display(Name="商户编号")]
        public Guid? MerchantId { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Display(Name="名称（Name）")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        /// <summary>
        /// 类型（Type）
        /// </summary>
        [Display(Name="类型（Type）")]
        public int? Type { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Display(Name="状态（State）")]
        public int? State { get; set; }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        [Display(Name="是否隐藏（Hide）")]
        public byte? IsOpen { get; set; }
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
        
        private string _fullPath = string.Empty;
        /// <summary>
        /// 部门全路径
        /// </summary>
        [Display(Name="部门全路径")]
        public string FullPath {
            get => _fullPath == null ? string.Empty : _fullPath.Trim();
            set => _fullPath = value;
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name="是否删除")]
        public byte? IsDeleted { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        [Display(Name="负责人")]
        public Guid? OrgChargeUid { get; set; }
        
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
        /// <summary>
        /// GPS经度
        /// </summary>
        [Display(Name="GPS经度")]
        public decimal? GPSLongitude { get; set; }
        /// <summary>
        /// GPS纬度
        /// </summary>
        [Display(Name="GPS纬度")]
        public decimal? GPSLatitude { get; set; }
    }
}