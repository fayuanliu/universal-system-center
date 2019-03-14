using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 应用更新日志工厂
    /// </summary>
    public static class ApplicationUpdaetLogFactory {
        /// <summary>
        /// 创建应用更新日志
        /// </summary>
        /// <param name="logId">日志编号</param>
        /// <param name="appId">应用程序编号（AppId）</param>
        /// <param name="updateTime">更新时间</param>
        /// <param name="versionNO">版本号</param>
        /// <param name="content">更新内容</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="version">版本号</param>
        public static ApplicationUpdaetLog Create( 
            Guid logId,
            Guid? appId,
            DateTime updateTime,
            string versionNO,
            string content,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            Byte[] version
        ) {
            ApplicationUpdaetLog result;
            result = new ApplicationUpdaetLog( logId );
            result.AppId = appId;
            result.UpdateTime = updateTime;
            result.VersionNO = versionNO;
            result.Content = content;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.Version = version;
            return result;
        }
    }
}