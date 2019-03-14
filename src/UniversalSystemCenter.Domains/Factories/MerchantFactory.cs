using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 商户工厂
    /// </summary>
    public static class MerchantFactory {
        /// <summary>
        /// 创建商户
        /// </summary>
        /// <param name="merchantId">商户编号</param>
        /// <param name="name">商户名称</param>
        /// <param name="isEnabled">启用</param>
        /// <param name="type">商户类型（个体，公司、业务单位、政府部门）</param>
        /// <param name="isDistribution">分销级别</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Merchant Create( 
            Guid merchantId,
            string name,
            byte isEnabled,
            int type,
            byte isDistribution,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            Merchant result;
            result = new Merchant( merchantId );
            result.Name = name;
            result.IsEnabled = isEnabled;
            result.Type = type;
            result.IsDistribution = isDistribution;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}