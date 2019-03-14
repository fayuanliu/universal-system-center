using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 应用程序数据传输对象扩展
    /// </summary>
    public static class ApplicationDtoExtension {
        /// <summary>
        /// 转换为应用程序实体
        /// </summary>
        /// <param name="dto">应用程序数据传输对象</param>
        public static Application ToEntity( this ApplicationDto dto ) {
            if ( dto == null )
                return new Application();
            return dto.MapTo( new Application( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为应用程序实体
        /// </summary>
        /// <param name="dto">应用程序数据传输对象</param>
        public static Application ToEntity2( this ApplicationDto dto ) {
            if( dto == null )
                return new Application();
            return new Application( dto.Id.ToGuid() ) {
                Name = dto.Name,
                ClientId = dto.ClientId,
                Note = dto.Note,
                IsEnabled = dto.IsEnabled,
                VersionNo = dto.VersionNo,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为应用程序实体
        /// </summary>
        /// <param name="dto">应用程序数据传输对象</param>
        public static Application ToEntity3( this ApplicationDto dto ) {
            if( dto == null )
                return new Application();
            return ApplicationFactory.Create(
                appId : dto.Id.ToGuid(),
                name : dto.Name,
                clientId : dto.ClientId,
                note : dto.Note,
                isEnabled : dto.IsEnabled,
                versionNo : dto.VersionNo,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为应用程序数据传输对象
        /// </summary>
        /// <param name="entity">应用程序实体</param>
        public static ApplicationDto ToDto(this Application entity) {
            if( entity == null )
                return new ApplicationDto();
            return entity.MapTo<ApplicationDto>();
        }

        /// <summary>
        /// 转换为应用程序数据传输对象
        /// </summary>
        /// <param name="entity">应用程序实体</param>
        public static ApplicationDto ToDto2( this Application entity ) {
            if( entity == null )
                return new ApplicationDto();
            return new ApplicationDto {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                ClientId = entity.ClientId,
                Note = entity.Note,
                IsEnabled = entity.IsEnabled,
                VersionNo = entity.VersionNo,
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