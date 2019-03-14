using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 地区工厂
    /// </summary>
    public static class AreaFactory {
        /// <summary>
        /// 创建地区
        /// </summary>
        /// <param name="areaId">地区编号</param>
        /// <param name="code">编码</param>
        /// <param name="name">名称</param>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <param name="parentId">父编号</param>
        /// <param name="path">路径</param>
        /// <param name="fullPath">全路径（FullPath）</param>
        /// <param name="level">级数</param>
        /// <param name="enabled">启用</param>
        /// <param name="sortId">排序号</param>
        /// <param name="pinYin">拼音简码</param>
        /// <param name="fullPinYin">全拼</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="isLeave">是否末级</param>
        /// <param name="gPSLongitude">GPSLongitude</param>
        /// <param name="gPSLatitude">GPSLatitude</param>
        /// <param name="version">版本号</param>
        public static Area Create( 
            Guid areaId,
            string code,
            string name,
            decimal? longitude,
            decimal? latitude,
            Guid? parentId,
            string path,
            string fullPath,
            int level,
            bool enabled,
            int? sortId,
            string pinYin,
            string fullPinYin,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            bool isLeave,
            decimal? gPSLongitude,
            decimal? gPSLatitude,
            Byte[] version
        ) {
            Area result;
            result = new Area( areaId,"",1 );
            result.Code = code;
            result.Name = name;
            result.Longitude = longitude;
            result.Latitude = latitude;
            result.ParentId = parentId;
            result.FullPath = fullPath;
            result.Enabled = enabled;
            result.SortId = sortId;
            result.PinYin = pinYin;
            result.FullPinYin = fullPinYin;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.IsDeleted = isDeleted;
            result.IsLeave = isLeave;
            result.GPSLongitude = gPSLongitude;
            result.GPSLatitude = gPSLatitude;
            result.Version = version;
            return result;
        }
    }
}