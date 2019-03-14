using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 部门业务区域工厂
    /// </summary>
    public static class OrganizationsRegionFactory {
        /// <summary>
        /// 创建部门业务区域
        /// </summary>
        /// <param name="deptRegionId">编号</param>
        /// <param name="organizationsId">组织机构编号(OrganizationsId)</param>
        /// <param name="addressId">地区编号</param>
        /// <param name="addressDetail">详细地址</param>
        /// <param name="addressName">地址 省市区</param>
        /// <param name="version">版本号</param>
        public static OrganizationsRegion Create( 
            Guid deptRegionId,
            Guid? organizationsId,
            string addressId,
            string addressDetail,
            string addressName,
            Byte[] version
        ) {
            OrganizationsRegion result;
            result = new OrganizationsRegion( deptRegionId );
            result.OrganizationsId = organizationsId;
            result.AddressId = addressId;
            result.AddressDetail = addressDetail;
            result.AddressName = addressName;
            result.Version = version;
            return result;
        }
    }
}