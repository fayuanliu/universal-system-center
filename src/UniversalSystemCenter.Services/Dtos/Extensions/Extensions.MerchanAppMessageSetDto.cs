using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 商户应用消息设置数据传输对象扩展
    /// </summary>
    public static class MerchanAppMessageSetDtoExtension {
        /// <summary>
        /// 转换为商户应用消息设置实体
        /// </summary>
        /// <param name="dto">商户应用消息设置数据传输对象</param>
        public static MerchanAppMessageSet ToEntity( this MerchanAppMessageSetDto dto ) {
            if ( dto == null )
                return new MerchanAppMessageSet();
            return dto.MapTo( new MerchanAppMessageSet( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为商户应用消息设置实体
        /// </summary>
        /// <param name="dto">商户应用消息设置数据传输对象</param>
        public static MerchanAppMessageSet ToEntity2( this MerchanAppMessageSetDto dto ) {
            if( dto == null )
                return new MerchanAppMessageSet();
            return new MerchanAppMessageSet( dto.Id.ToGuid() ) {
                CategoryId = dto.CategoryId,
                Type = dto.Type,
                State = dto.State,
                MerchanId = dto.MerchanId,
                    IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为商户应用消息设置实体
        /// </summary>
        /// <param name="dto">商户应用消息设置数据传输对象</param>
        public static MerchanAppMessageSet ToEntity3( this MerchanAppMessageSetDto dto ) {
            if( dto == null )
                return new MerchanAppMessageSet();
            return MerchanAppMessageSetFactory.Create(
                setId : dto.Id.ToGuid(),
                categoryId : dto.CategoryId,
                type : dto.Type,
                state : dto.State,
                merchanId : dto.MerchanId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为商户应用消息设置数据传输对象
        /// </summary>
        /// <param name="entity">商户应用消息设置实体</param>
        public static MerchanAppMessageSetDto ToDto(this MerchanAppMessageSet entity) {
            if( entity == null )
                return new MerchanAppMessageSetDto();
            return entity.MapTo<MerchanAppMessageSetDto>();
        }

        /// <summary>
        /// 转换为商户应用消息设置数据传输对象
        /// </summary>
        /// <param name="entity">商户应用消息设置实体</param>
        public static MerchanAppMessageSetDto ToDto2( this MerchanAppMessageSet entity ) {
            if( entity == null )
                return new MerchanAppMessageSetDto();
            return new MerchanAppMessageSetDto {
                Id = entity.Id.ToString(),
                CategoryId = entity.CategoryId,
                Type = entity.Type,
                State = entity.State,
                MerchanId = entity.MerchanId,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}