using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 消息模板数据传输对象扩展
    /// </summary>
    public static class MessageTemplateDtoExtension {
        /// <summary>
        /// 转换为消息模板实体
        /// </summary>
        /// <param name="dto">消息模板数据传输对象</param>
        public static MessageTemplate ToEntity( this MessageTemplateDto dto ) {
            if ( dto == null )
                return new MessageTemplate();
            return dto.MapTo( new MessageTemplate( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为消息模板实体
        /// </summary>
        /// <param name="dto">消息模板数据传输对象</param>
        public static MessageTemplate ToEntity2( this MessageTemplateDto dto ) {
            if( dto == null )
                return new MessageTemplate();
            return new MessageTemplate( dto.Id.ToGuid() ) {
                CategoryId = dto.CategoryId,
                Type = dto.Type,
                SendObject = dto.SendObject,
                Name = dto.Name,
                SourceId = dto.SourceId,
                Title = dto.Title,
                Content = dto.Content,
                    IsEnabled = dto.IsEnabled,
                SortId = dto.SortId,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModifierId = dto.LastModifierId,
                LastModificationTime = dto.LastModificationTime,
                    IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为消息模板实体
        /// </summary>
        /// <param name="dto">消息模板数据传输对象</param>
        public static MessageTemplate ToEntity3( this MessageTemplateDto dto ) {
            if( dto == null )
                return new MessageTemplate();
            return MessageTemplateFactory.Create(
                templateId : dto.Id.ToGuid(),
                categoryId : dto.CategoryId,
                type : dto.Type,
                sendObject : dto.SendObject,
                name : dto.Name,
                sourceId : dto.SourceId,
                title : dto.Title,
                content : dto.Content,
                isEnabled : dto.IsEnabled,
                sortId : dto.SortId,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModifierId : dto.LastModifierId,
                lastModificationTime : dto.LastModificationTime,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为消息模板数据传输对象
        /// </summary>
        /// <param name="entity">消息模板实体</param>
        public static MessageTemplateDto ToDto(this MessageTemplate entity) {
            if( entity == null )
                return new MessageTemplateDto();
            return entity.MapTo<MessageTemplateDto>();
        }

        /// <summary>
        /// 转换为消息模板数据传输对象
        /// </summary>
        /// <param name="entity">消息模板实体</param>
        public static MessageTemplateDto ToDto2( this MessageTemplate entity ) {
            if( entity == null )
                return new MessageTemplateDto();
            return new MessageTemplateDto {
                Id = entity.Id.ToString(),
                CategoryId = entity.CategoryId,
                Type = entity.Type,
                SendObject = entity.SendObject,
                Name = entity.Name,
                SourceId = entity.SourceId,
                Title = entity.Title,
                Content = entity.Content,
                IsEnabled = entity.IsEnabled,
                SortId = entity.SortId,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModifierId = entity.LastModifierId,
                LastModificationTime = entity.LastModificationTime,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}