using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 岗位工厂
    /// </summary>
    public static class PositionFactory {
        /// <summary>
        /// 创建岗位
        /// </summary>
        /// <param name="postId">类型编号（TypeId）</param>
        /// <param name="name">名称（Name）</param>
        /// <param name="isEnabled">启用</param>
        /// <param name="sortId">排序号</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="version">版本号</param>
        public static Position Create( 
            Guid postId,
            string name,
            byte isEnabled,
            int sortId,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Guid? merchantId,
            Byte[] version
        ) {
            Position result;
            result = new Position( postId );
            result.Name = name;
            result.IsEnabled = isEnabled;
            result.SortId = sortId;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.IsDeleted = isDeleted;
            result.MerchantId = merchantId;
            result.Version = version;
            return result;
        }
    }
}