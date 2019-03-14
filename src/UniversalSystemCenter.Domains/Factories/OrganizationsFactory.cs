using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 组织机构工厂
    /// </summary>
    public static class OrganizationsFactory {
        /// <summary>
        /// 创建组织机构
        /// </summary>
        /// <param name="organizationsId">组织机构编号(OrganizationsId)</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="name">名称（Name）</param>
        /// <param name="type">类型（Type）</param>
        /// <param name="state">状态（State）</param>
        /// <param name="isOpen">是否隐藏（Hide）</param>
        /// <param name="isLeave">是否末级</param>
        /// <param name="parentId">父编号</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        /// <param name="enabled">启用</param>
        /// <param name="sortId">排序号</param>
        /// <param name="pinYin">拼音简码</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="fullPath">部门全路径</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="orgChargeUid">负责人</param>
        /// <param name="addressId">地区编号</param>
        /// <param name="addressDetail">详细地址</param>
        /// <param name="addressName">地址 省市区</param>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <param name="gPSLongitude">GPS经度</param>
        /// <param name="gPSLatitude">GPS纬度</param>
        /// <param name="version">版本号</param>
        public static Organizations Create( 
            Guid organizationsId,
            Guid? merchantId,
            string name,
            int type,
            int state,
            bool isOpen,
            bool isLeave,
            Guid? parentId,
            string path,
            int level,
            bool enabled,
            int sortId,
            string pinYin,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            string fullPath,
            bool isDeleted,
            Guid orgChargeUid,
            string addressId,
            string addressDetail,
            string addressName,
            decimal? longitude,
            decimal? latitude,
            decimal? gPSLongitude,
            decimal? gPSLatitude,
            Byte[] version
        ) {
            Organizations result;
            result = new Organizations( organizationsId,"",1 );
            result.MerchantId = merchantId;
            result.Name = name;
            result.Type = type;
            result.State = state;
            result.IsOpen = isOpen;
            result.IsLeave = isLeave;
            result.ParentId = parentId;
            result.Enabled = enabled;
            result.SortId = sortId;
            result.PinYin = pinYin;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.FullPath = fullPath;
            result.IsDeleted = isDeleted;
            result.OrgChargeUid = orgChargeUid;
            result.AddressId = addressId;
            result.AddressDetail = addressDetail;
            result.AddressName = addressName;
            result.Longitude = longitude;
            result.Latitude = latitude;
            result.GPSLongitude = gPSLongitude;
            result.GPSLatitude = gPSLatitude;
            result.Version = version;
            return result;
        }
    }
}