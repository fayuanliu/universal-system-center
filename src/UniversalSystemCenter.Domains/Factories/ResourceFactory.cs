using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 资源工厂
    /// </summary>
    public static class ResourceFactory {
        /// <summary>
        /// 创建资源
        /// </summary>
        /// <param name="resourceId">资源编号（ResourceId）</param>
        /// <param name="uri">资源标识</param>
        /// <param name="name">资源名称</param>
        /// <param name="type">资源类型</param>
        /// <param name="note">备注</param>
        /// <param name="isLeave">是否末级</param>
        /// <param name="parentId">父编号</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        /// <param name="sortId">排序号</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="pinYin">PinYin</param>
        /// <param name="enabled">IsEnabled</param>
        /// <param name="appId">AppId</param>
        /// <param name="version">版本号</param>
        public static Resource Create( 
            Guid resourceId,
            string uri,
            string name,
            int type,
            string note,
            bool isLeave,
            Guid? parentId,
            string path,
            int level,
            int? sortId,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            string pinYin,
            bool enabled,
            Guid? appId,
            Byte[] version
        ) {
            Resource result;
            result = new Resource( resourceId,"",1 );
            result.Uri = uri;
            result.Name = name;
            result.Type = type;
            result.Note = note;
            result.IsLeave = isLeave;
            result.ParentId = parentId;
            result.SortId = sortId;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.IsDeleted = isDeleted;
            result.PinYin = pinYin;
            result.Enabled = enabled;
            result.AppId = appId;
            result.Version = version;
            return result;
        }
    }
}