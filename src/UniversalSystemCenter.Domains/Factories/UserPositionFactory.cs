using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 用户岗位工厂
    /// </summary>
    public static class UserPositionFactory {
        /// <summary>
        /// 创建用户岗位
        /// </summary>
        /// <param name="userPositionId">用户岗位编号</param>
        /// <param name="userId">用户编号</param>
        /// <param name="postId">岗位编号</param>
        public static UserPosition Create( 
            Guid userPositionId,
            Guid userId,
            Guid postId
        ) {
            UserPosition result;
            result = new UserPosition( userPositionId );
            result.UserId = userId;
            result.PostId = postId;
            return result;
        }
    }
}