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
        /// <param name="organizationsId">组织机构编号(OrganizationsId)</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="account">用户名称（UserName）</param>
        /// <param name="nickname">昵称</param>
        /// <param name="password">密码（Password）</param>
        /// <param name="head">头像（Head）</param>
        /// <param name="mobile">手机号</param>
        /// <param name="registerTime">注册日期（RegisterTime）</param>
        /// <param name="type">类型</param>
        /// <param name="state">状态</param>
        /// <param name="saltd">盐值</param>
        /// <param name="idCard">用户编号</param>
        /// <param name="realName">真实姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="referrer">推荐人</param>
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
            Guid? organizationsId,
            Guid? merchantId,
            string account,
            string nickname,
            string password,
            string head,
            string mobile,
            DateTime registerTime,
            int type,
            int state,
            string saltd,
            string idCard,
            string realName,
            int sex,
            Guid? referrer,
            byte isLocked,
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
            result.OrganizationsId = organizationsId;
            result.MerchantId = merchantId;
            result.Account = account;
            result.Nickname = nickname;
            result.Password = password;
            result.Head = head;
            result.Mobile = mobile;
            result.RegisterTime = registerTime;
            result.Type = type;
            result.State = state;
            result.Saltd = saltd;
            result.IdCard = idCard;
            result.RealName = realName;
            result.Sex = sex;
            result.Referrer = referrer;
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