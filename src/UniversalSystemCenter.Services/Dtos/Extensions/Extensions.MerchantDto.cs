using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 商户数据传输对象扩展
    /// </summary>
    public static class MerchantDtoExtension {
        /// <summary>
        /// 转换为商户实体
        /// </summary>
        /// <param name="dto">商户数据传输对象</param>
        public static Merchant ToEntity( this MerchantDto dto ) {
            if ( dto == null )
                return new Merchant();
            return dto.MapTo( new Merchant( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为商户实体
        /// </summary>
        /// <param name="dto">商户数据传输对象</param>
        public static Merchant ToEntity2( this MerchantDto dto ) {
            if( dto == null )
                return new Merchant();
            return new Merchant( dto.Id.ToGuid() ) {
                Name = dto.Name,
                IsEnabled = dto.IsEnabled,
                Type = dto.Type,
                IsDistribution = dto.IsDistribution,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为商户实体
        /// </summary>
        /// <param name="dto">商户数据传输对象</param>
        public static Merchant ToEntity3( this MerchantDto dto ) {
            if( dto == null )
                return new Merchant();
            return MerchantFactory.Create(
                merchantId : dto.Id.ToGuid(),
                name : dto.Name,
                isEnabled : dto.IsEnabled,
                type : dto.Type,
                isDistribution : dto.IsDistribution,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为商户数据传输对象
        /// </summary>
        /// <param name="entity">商户实体</param>
        public static MerchantDto ToDto(this Merchant entity) {
            if( entity == null )
                return new MerchantDto();
            return entity.MapTo<MerchantDto>();
        }

        /// <summary>
        /// 转换为商户数据传输对象
        /// </summary>
        /// <param name="entity">商户实体</param>
        public static MerchantDto ToDto2( this Merchant entity ) {
            if( entity == null )
                return new MerchantDto();
            return new MerchantDto {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                IsEnabled = entity.IsEnabled,
                Type = entity.Type,
                IsDistribution = entity.IsDistribution,
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