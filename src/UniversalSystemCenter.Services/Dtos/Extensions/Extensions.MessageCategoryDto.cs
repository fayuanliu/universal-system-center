using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 消息类型数据传输对象扩展
    /// </summary>
    public static class MessageCategoryDtoExtension {
        /// <summary>
        /// 转换为消息类型实体
        /// </summary>
        /// <param name="dto">消息类型数据传输对象</param>
        public static MessageCategory ToEntity( this MessageCategoryDto dto ) {
            if ( dto == null )
                return new MessageCategory();
            return dto.MapTo( new MessageCategory( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为消息类型实体
        /// </summary>
        /// <param name="dto">消息类型数据传输对象</param>
        public static MessageCategory ToEntity2( this MessageCategoryDto dto ) {
            if( dto == null )
                return new MessageCategory();
            return new MessageCategory( dto.Id.ToGuid() ) {
                Name = dto.Name,
                IsEnabled = dto.IsEnabled,
                Type = dto.Type,
                AppId = dto.AppId,
                Module = dto.Module,
                SortId = dto.SortId,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为消息类型实体
        /// </summary>
        /// <param name="dto">消息类型数据传输对象</param>
        public static MessageCategory ToEntity3( this MessageCategoryDto dto ) {
            if( dto == null )
                return new MessageCategory();
            return MessageCategoryFactory.Create(
                categoryId : dto.Id.ToGuid(),
                name : dto.Name,
                isEnabled : dto.IsEnabled,
                type : dto.Type,
                appId : dto.AppId,
                module : dto.Module,
                sortId : dto.SortId,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为消息类型数据传输对象
        /// </summary>
        /// <param name="entity">消息类型实体</param>
        public static MessageCategoryDto ToDto(this MessageCategory entity) {
            if( entity == null )
                return new MessageCategoryDto();
            return entity.MapTo<MessageCategoryDto>();
        }

        /// <summary>
        /// 转换为消息类型数据传输对象
        /// </summary>
        /// <param name="entity">消息类型实体</param>
        public static MessageCategoryDto ToDto2( this MessageCategory entity ) {
            if( entity == null )
                return new MessageCategoryDto();
            return new MessageCategoryDto {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                IsEnabled = entity.IsEnabled,
                Type = entity.Type,
                AppId = entity.AppId,
                Module = entity.Module,
                SortId = entity.SortId,
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