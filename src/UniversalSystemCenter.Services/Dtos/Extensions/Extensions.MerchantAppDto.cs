using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 商户应用数据传输对象扩展
    /// </summary>
    public static class MerchantAppDtoExtension {
        /// <summary>
        /// 转换为商户应用实体
        /// </summary>
        /// <param name="dto">商户应用数据传输对象</param>
        public static MerchantApp ToEntity( this MerchantAppDto dto ) {
            if ( dto == null )
                return new MerchantApp();
            return dto.MapTo( new MerchantApp( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为商户应用实体
        /// </summary>
        /// <param name="dto">商户应用数据传输对象</param>
        public static MerchantApp ToEntity2( this MerchantAppDto dto ) {
            if( dto == null )
                return new MerchantApp();
            return new MerchantApp( dto.Id.ToGuid() ) {
                MerchantId = dto.MerchantId,
                AppId = dto.AppId,
                ExpiryTime = dto.ExpiryTime,
                RegisterDate = dto.RegisterDate,
                Code = dto.Code,
                State = dto.State,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为商户应用实体
        /// </summary>
        /// <param name="dto">商户应用数据传输对象</param>
        public static MerchantApp ToEntity3( this MerchantAppDto dto ) {
            if( dto == null )
                return new MerchantApp();
            return MerchantAppFactory.Create(
                merchantAppId : dto.Id.ToGuid(),
                merchantId : dto.MerchantId,
                appId : dto.AppId,
                expiryTime : dto.ExpiryTime,
                registerDate : dto.RegisterDate,
                code : dto.Code,
                state : dto.State,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为商户应用数据传输对象
        /// </summary>
        /// <param name="entity">商户应用实体</param>
        public static MerchantAppDto ToDto(this MerchantApp entity) {
            if( entity == null )
                return new MerchantAppDto();
            return entity.MapTo<MerchantAppDto>();
        }

        /// <summary>
        /// 转换为商户应用数据传输对象
        /// </summary>
        /// <param name="entity">商户应用实体</param>
        public static MerchantAppDto ToDto2( this MerchantApp entity ) {
            if( entity == null )
                return new MerchantAppDto();
            return new MerchantAppDto {
                Id = entity.Id.ToString(),
                MerchantId = entity.MerchantId,
                AppId = entity.AppId,
                ExpiryTime = entity.ExpiryTime,
                RegisterDate = entity.RegisterDate,
                Code = entity.Code,
                State = entity.State,
                Version = entity.Version,
            };
        }
    }
}