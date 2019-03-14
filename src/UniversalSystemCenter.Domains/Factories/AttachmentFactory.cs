using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 附件工厂
    /// </summary>
    public static class AttachmentFactory {
        /// <summary>
        /// 创建附件
        /// </summary>
        /// <param name="attachmentId">附件编号（AttachmentId）</param>
        /// <param name="fileName">附件名称（FileName)</param>
        /// <param name="fileType">文件类型（FileType）</param>
        /// <param name="size">文件大小（Size）</param>
        /// <param name="remoteUrl">远程路径（RemoteUrl）</param>
        /// <param name="localUrl">本地路径（LocalUrl）</param>
        /// <param name="width">宽（Width）</param>
        /// <param name="height">高（Height）</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="module">所属模块（Module）</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Attachment Create( 
            Guid attachmentId,
            string fileName,
            string fileType,
            long? size,
            string remoteUrl,
            string localUrl,
            int width,
            int height,
            Guid? merchantId,
            string module,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            Attachment result;
            result = new Attachment( attachmentId );
            result.FileName = fileName;
            result.FileType = fileType;
            result.Size = size;
            result.RemoteUrl = remoteUrl;
            result.LocalUrl = localUrl;
            result.Width = width;
            result.Height = height;
            result.MerchantId = merchantId;
            result.Module = module;
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