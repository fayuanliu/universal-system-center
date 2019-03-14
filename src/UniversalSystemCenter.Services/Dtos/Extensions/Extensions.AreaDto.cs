using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 地区数据传输对象扩展
    /// </summary>
    public static class AreaDtoExtension {
        /// <summary>
        /// 转换为地区实体
        /// </summary>
        /// <param name="dto">地区数据传输对象</param>
        public static Area ToEntity( this AreaDto dto ) {
            if ( dto == null )
                return new Area();
            return dto.MapTo( new Area( dto.Id.ToGuid(),"",1 ) );
        }
        
        /// <summary>
        /// 转换为地区实体
        /// </summary>
        /// <param name="dto">地区数据传输对象</param>
        public static Area ToEntity2( this AreaDto dto ) {
            if( dto == null )
                return new Area();
            return new Area( dto.Id.ToGuid(),"",1 ) {
                Code = dto.Code,
                Name = dto.Name,
                Longitude = dto.Longitude,
                Latitude = dto.Latitude,
                ParentId = dto.ParentId.ToGuidOrNull(),
                FullPath = dto.FullPath,
                Enabled = dto.Enabled.Value,
                SortId = dto.SortId,
                PinYin = dto.PinYin,
                FullPinYin = dto.FullPinYin,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                IsLeave = dto.IsLeave,
                GPSLongitude = dto.GPSLongitude,
                GPSLatitude = dto.GPSLatitude,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为地区实体
        /// </summary>
        /// <param name="dto">地区数据传输对象</param>
        public static Area ToEntity3( this AreaDto dto ) {
            if( dto == null )
                return new Area();
            return AreaFactory.Create(
                areaId : dto.Id.ToGuid(),
                code : dto.Code,
                name : dto.Name,
                longitude : dto.Longitude,
                latitude : dto.Latitude,
                parentId : dto.ParentId.ToGuidOrNull(),
                path : dto.Path,
                fullPath : dto.FullPath,
                level : dto.Level.Value,
                enabled : dto.Enabled.Value,
                sortId : dto.SortId,
                pinYin : dto.PinYin,
                fullPinYin : dto.FullPinYin,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                isLeave : dto.IsLeave,
                gPSLongitude : dto.GPSLongitude,
                gPSLatitude : dto.GPSLatitude,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为地区数据传输对象
        /// </summary>
        /// <param name="entity">地区实体</param>
        public static AreaDto ToDto(this Area entity) {
            if( entity == null )
                return new AreaDto();
            return entity.MapTo<AreaDto>();
        }

        /// <summary>
        /// 转换为地区数据传输对象
        /// </summary>
        /// <param name="entity">地区实体</param>
        public static AreaDto ToDto2( this Area entity ) {
            if( entity == null )
                return new AreaDto();
            return new AreaDto {
                Id = entity.Id.ToString(),
                Code = entity.Code,
                Name = entity.Name,
                Longitude = entity.Longitude,
                Latitude = entity.Latitude,
                ParentId = entity.ParentId.ToString(),
                Path = entity.Path,
                FullPath = entity.FullPath,
                Level = entity.Level,
                Enabled = entity.Enabled,
                SortId = entity.SortId,
                PinYin = entity.PinYin,
                FullPinYin = entity.FullPinYin,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                IsDeleted = entity.IsDeleted,
                IsLeave = entity.IsLeave,
                GPSLongitude = entity.GPSLongitude,
                GPSLatitude = entity.GPSLatitude,
                Version = entity.Version,
            };
        }
    }
}