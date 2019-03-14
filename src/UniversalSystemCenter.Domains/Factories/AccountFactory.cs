using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 账户工厂
    /// </summary>
    public static class AccountFactory {
        /// <summary>
        /// 创建账户
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="type">类型</param>
        /// <param name="state">状态</param>
        /// <param name="nickname">昵称</param>
        /// <param name="password">密码（Password）</param>
        /// <param name="head">头像（Head）</param>
        /// <param name="mobile">手机号</param>
        /// <param name="saltd">盐值</param>
        /// <param name="idCard">用户编号</param>
        /// <param name="realName">真实姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Account Create( 
            Guid accountId,
            int type,
            int state,
            string nickname,
            string password,
            string head,
            string mobile,
            string saltd,
            string idCard,
            string realName,
            int sex,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            Account result;
            result = new Account( accountId );
            result.Type = type;
            result.State = state;
            result.Nickname = nickname;
            result.Password = password;
            result.Head = head;
            result.Mobile = mobile;
            result.Saltd = saltd;
            result.IdCard = idCard;
            result.RealName = realName;
            result.Sex = sex;
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