using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 资源数据传输对象扩展
    /// </summary>
    public static class ResourceDtoExtension {
        /// <summary>
        /// 转换为资源实体
        /// </summary>
        /// <param name="dto">资源数据传输对象</param>
        public static Resource ToEntity( this ResourceDto dto ) {
            if ( dto == null )
                return new Resource();
            return dto.MapTo( new Resource( dto.Id.ToGuid(), "", 1) );
        }
        
        /// <summary>
        /// 转换为资源实体
        /// </summary>
        /// <param name="dto">资源数据传输对象</param>
        public static Resource ToEntity2( this ResourceDto dto ) {
            if( dto == null )
                return new Resource();
            return new Resource( dto.Id.ToGuid(),"",1 ) {
                Uri = dto.Uri,
                Name = dto.Name,
                Type = dto.Type,
                Note = dto.Note,
                IsLeave = dto.IsLeave,
                ParentId = dto.ParentId.ToGuidOrNull(),
                SortId = dto.SortId,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                PinYin = dto.PinYin,
                Enabled = dto.Enabled.Value,
                AppId = dto.AppId,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为资源实体
        /// </summary>
        /// <param name="dto">资源数据传输对象</param>
        public static Resource ToEntity3( this ResourceDto dto ) {
            if( dto == null )
                return new Resource();
            return ResourceFactory.Create(
                resourceId : dto.Id.ToGuid(),
                uri : dto.Uri,
                name : dto.Name,
                type : dto.Type,
                note : dto.Note,
                isLeave : dto.IsLeave,
                parentId : dto.ParentId.ToGuidOrNull(),
                path : dto.Path,
                level : dto.Level.Value,
                sortId : dto.SortId,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                pinYin : dto.PinYin,
                enabled : dto.Enabled.Value,
                appId : dto.AppId,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为资源数据传输对象
        /// </summary>
        /// <param name="entity">资源实体</param>
        public static ResourceDto ToDto(this Resource entity) {
            if( entity == null )
                return new ResourceDto();
            return entity.MapTo<ResourceDto>();
        }

        /// <summary>
        /// 转换为资源数据传输对象
        /// </summary>
        /// <param name="entity">资源实体</param>
        public static ResourceDto ToDto2( this Resource entity ) {
            if( entity == null )
                return new ResourceDto();
            return new ResourceDto {
                Id = entity.Id.ToString(),
                Uri = entity.Uri,
                Name = entity.Name,
                Type = entity.Type,
                Note = entity.Note,
                IsLeave = entity.IsLeave,
                ParentId = entity.ParentId.ToString(),
                Path = entity.Path,
                Level = entity.Level,
                SortId = entity.SortId,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                IsDeleted = entity.IsDeleted,
                PinYin = entity.PinYin,
                Enabled = entity.Enabled,
                AppId = entity.AppId,
                Version = entity.Version,
            };
        }
    }
}