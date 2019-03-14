using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 应用更新日志数据传输对象扩展
    /// </summary>
    public static class ApplicationUpdaetLogDtoExtension {
        /// <summary>
        /// 转换为应用更新日志实体
        /// </summary>
        /// <param name="dto">应用更新日志数据传输对象</param>
        public static ApplicationUpdaetLog ToEntity( this ApplicationUpdaetLogDto dto ) {
            if ( dto == null )
                return new ApplicationUpdaetLog();
            return dto.MapTo( new ApplicationUpdaetLog( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为应用更新日志实体
        /// </summary>
        /// <param name="dto">应用更新日志数据传输对象</param>
        public static ApplicationUpdaetLog ToEntity2( this ApplicationUpdaetLogDto dto ) {
            if( dto == null )
                return new ApplicationUpdaetLog();
            return new ApplicationUpdaetLog( dto.Id.ToGuid() ) {
                AppId = dto.AppId,
                UpdateTime = dto.UpdateTime,
                VersionNO = dto.VersionNO,
                Content = dto.Content,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为应用更新日志实体
        /// </summary>
        /// <param name="dto">应用更新日志数据传输对象</param>
        public static ApplicationUpdaetLog ToEntity3( this ApplicationUpdaetLogDto dto ) {
            if( dto == null )
                return new ApplicationUpdaetLog();
            return ApplicationUpdaetLogFactory.Create(
                logId : dto.Id.ToGuid(),
                appId : dto.AppId,
                updateTime : dto.UpdateTime,
                versionNO : dto.VersionNO,
                content : dto.Content,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为应用更新日志数据传输对象
        /// </summary>
        /// <param name="entity">应用更新日志实体</param>
        public static ApplicationUpdaetLogDto ToDto(this ApplicationUpdaetLog entity) {
            if( entity == null )
                return new ApplicationUpdaetLogDto();
            return entity.MapTo<ApplicationUpdaetLogDto>();
        }

        /// <summary>
        /// 转换为应用更新日志数据传输对象
        /// </summary>
        /// <param name="entity">应用更新日志实体</param>
        public static ApplicationUpdaetLogDto ToDto2( this ApplicationUpdaetLog entity ) {
            if( entity == null )
                return new ApplicationUpdaetLogDto();
            return new ApplicationUpdaetLogDto {
                Id = entity.Id.ToString(),
                AppId = entity.AppId,
                UpdateTime = entity.UpdateTime,
                VersionNO = entity.VersionNO,
                Content = entity.Content,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                Version = entity.Version,
            };
        }
    }
}