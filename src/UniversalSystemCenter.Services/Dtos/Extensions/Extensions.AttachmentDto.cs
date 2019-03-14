using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 附件数据传输对象扩展
    /// </summary>
    public static class AttachmentDtoExtension {
        /// <summary>
        /// 转换为附件实体
        /// </summary>
        /// <param name="dto">附件数据传输对象</param>
        public static Attachment ToEntity( this AttachmentDto dto ) {
            if ( dto == null )
                return new Attachment();
            return dto.MapTo( new Attachment( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为附件实体
        /// </summary>
        /// <param name="dto">附件数据传输对象</param>
        public static Attachment ToEntity2( this AttachmentDto dto ) {
            if( dto == null )
                return new Attachment();
            return new Attachment( dto.Id.ToGuid() ) {
                FileName = dto.FileName,
                FileType = dto.FileType,
                Size = dto.Size,
                RemoteUrl = dto.RemoteUrl,
                LocalUrl = dto.LocalUrl,
                Width = dto.Width,
                Height = dto.Height,
                MerchantId = dto.MerchantId,
                Module = dto.Module,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为附件实体
        /// </summary>
        /// <param name="dto">附件数据传输对象</param>
        public static Attachment ToEntity3( this AttachmentDto dto ) {
            if( dto == null )
                return new Attachment();
            return AttachmentFactory.Create(
                attachmentId : dto.Id.ToGuid(),
                fileName : dto.FileName,
                fileType : dto.FileType,
                size : dto.Size,
                remoteUrl : dto.RemoteUrl,
                localUrl : dto.LocalUrl,
                width : dto.Width,
                height : dto.Height,
                merchantId : dto.MerchantId,
                module : dto.Module,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为附件数据传输对象
        /// </summary>
        /// <param name="entity">附件实体</param>
        public static AttachmentDto ToDto(this Attachment entity) {
            if( entity == null )
                return new AttachmentDto();
            return entity.MapTo<AttachmentDto>();
        }

        /// <summary>
        /// 转换为附件数据传输对象
        /// </summary>
        /// <param name="entity">附件实体</param>
        public static AttachmentDto ToDto2( this Attachment entity ) {
            if( entity == null )
                return new AttachmentDto();
            return new AttachmentDto {
                Id = entity.Id.ToString(),
                FileName = entity.FileName,
                FileType = entity.FileType,
                Size = entity.Size,
                RemoteUrl = entity.RemoteUrl,
                LocalUrl = entity.LocalUrl,
                Width = entity.Width,
                Height = entity.Height,
                MerchantId = entity.MerchantId,
                Module = entity.Module,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}