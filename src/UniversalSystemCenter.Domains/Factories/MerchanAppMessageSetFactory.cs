using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 商户应用消息设置工厂
    /// </summary>
    public static class MerchanAppMessageSetFactory {
        /// <summary>
        /// 创建商户应用消息设置
        /// </summary>
        /// <param name="setId">消息设置编号</param>
        /// <param name="categoryId">消息分类编号（MessageCategoryId）</param>
        /// <param name="type">消息类型</param>
        /// <param name="state">状态（State）</param>
        /// <param name="merchanId">会员（MemberId）</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static MerchanAppMessageSet Create( 
            Guid setId,
            Guid? categoryId,
            int type,
            int state,
            Guid merchanId,
            bool isDeleted,
            Byte[] version
        ) {
            MerchanAppMessageSet result;
            result = new MerchanAppMessageSet( setId );
            result.CategoryId = categoryId;
            result.Type = type;
            result.State = state;
            result.MerchanId = merchanId;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}