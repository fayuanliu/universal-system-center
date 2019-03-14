using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 应用程序工厂
    /// </summary>
    public static class ApplicationFactory {
        /// <summary>
        /// 创建应用程序
        /// </summary>
        /// <param name="appId">应用程序编号（AppId）</param>
        /// <param name="name">名称（Name）</param>
        /// <param name="clientId">客户端编号</param>
        /// <param name="note">描述（Note）</param>
        /// <param name="isEnabled">启用（Enabled）</param>
        /// <param name="versionNo">版本</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Application Create( 
            Guid appId,
            string name,
            string clientId,
            string note,
            byte isEnabled,
            string versionNo,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            Application result;
            result = new Application( appId );
            result.Name = name;
            result.ClientId = clientId;
            result.Note = note;
            result.IsEnabled = isEnabled;
            result.VersionNo = versionNo;
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