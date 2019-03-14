using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 用户工厂
    /// </summary>
    public static class UserFactory {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="userId">用户编号（UserId)</param>
        /// <param name="eId">员工编号</param>
        /// <param name="organizationsId">组织机构编号(OrganizationsId)</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="accountId">账户编号</param>
        /// <param name="registerTime">注册日期（RegisterTime）</param>
        /// <param name="isLocked">锁定</param>
        /// <param name="lockBeginTime">锁定起始时间</param>
        /// <param name="lockDuration">锁定持续时间</param>
        /// <param name="lockMessage">锁定提示消息</param>
        /// <param name="lastLoginTime">上次登陆时间</param>
        /// <param name="lastLoginIp">上次登陆Ip</param>
        /// <param name="currentLoginTime">本次登陆时间</param>
        /// <param name="currentLoginIp">本次登陆Ip</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static User Create( 
            Guid userId,
            string eId,
            Guid? organizationsId,
            Guid? merchantId,
            Guid? accountId,
            DateTime registerTime,
            bool isLocked,
            DateTime? lockBeginTime,
            int? lockDuration,
            string lockMessage,
            DateTime? lastLoginTime,
            string lastLoginIp,
            DateTime? currentLoginTime,
            string currentLoginIp,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            User result;
            result = new User( userId );
            result.EId = eId;
            result.OrganizationsId = organizationsId;
            result.MerchantId = merchantId;
            result.AccountId = accountId;
            result.RegisterTime = registerTime;
            result.IsLocked = isLocked;
            result.LockBeginTime = lockBeginTime;
            result.LockDuration = lockDuration;
            result.LockMessage = lockMessage;
            result.LastLoginTime = lastLoginTime;
            result.LastLoginIp = lastLoginIp;
            result.CurrentLoginTime = currentLoginTime;
            result.CurrentLoginIp = currentLoginIp;
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