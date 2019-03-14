using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 岗位数据传输对象扩展
    /// </summary>
    public static class PositionDtoExtension {
        /// <summary>
        /// 转换为岗位实体
        /// </summary>
        /// <param name="dto">岗位数据传输对象</param>
        public static Position ToEntity( this PositionDto dto ) {
            if ( dto == null )
                return new Position();
            return dto.MapTo( new Position( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为岗位实体
        /// </summary>
        /// <param name="dto">岗位数据传输对象</param>
        public static Position ToEntity2( this PositionDto dto ) {
            if( dto == null )
                return new Position();
            return new Position( dto.Id.ToGuid() ) {
                Name = dto.Name,
                IsEnabled = dto.IsEnabled,
                SortId = dto.SortId,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                MerchantId = dto.MerchantId,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为岗位实体
        /// </summary>
        /// <param name="dto">岗位数据传输对象</param>
        public static Position ToEntity3( this PositionDto dto ) {
            if( dto == null )
                return new Position();
            return PositionFactory.Create(
                postId : dto.Id.ToGuid(),
                name : dto.Name,
                isEnabled : dto.IsEnabled,
                sortId : dto.SortId,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                merchantId : dto.MerchantId,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为岗位数据传输对象
        /// </summary>
        /// <param name="entity">岗位实体</param>
        public static PositionDto ToDto(this Position entity) {
            if( entity == null )
                return new PositionDto();
            return entity.MapTo<PositionDto>();
        }

        /// <summary>
        /// 转换为岗位数据传输对象
        /// </summary>
        /// <param name="entity">岗位实体</param>
        public static PositionDto ToDto2( this Position entity ) {
            if( entity == null )
                return new PositionDto();
            return new PositionDto {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                IsEnabled = entity.IsEnabled,
                SortId = entity.SortId,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                IsDeleted = entity.IsDeleted,
                MerchantId = entity.MerchantId,
                Version = entity.Version,
            };
        }
    }
}