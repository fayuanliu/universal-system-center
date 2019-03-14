using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 用户岗位数据传输对象扩展
    /// </summary>
    public static class UserPositionDtoExtension {
        /// <summary>
        /// 转换为用户岗位实体
        /// </summary>
        /// <param name="dto">用户岗位数据传输对象</param>
        public static UserPosition ToEntity( this UserPositionDto dto ) {
            if ( dto == null )
                return new UserPosition();
            return dto.MapTo( new UserPosition( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为用户岗位实体
        /// </summary>
        /// <param name="dto">用户岗位数据传输对象</param>
        public static UserPosition ToEntity2( this UserPositionDto dto ) {
            if( dto == null )
                return new UserPosition();
            return new UserPosition( dto.Id.ToGuid() ) {
                UserId = dto.UserId,
                PostId = dto.PostId,
            };
        }
        
        /// <summary>
        /// 转换为用户岗位实体
        /// </summary>
        /// <param name="dto">用户岗位数据传输对象</param>
        public static UserPosition ToEntity3( this UserPositionDto dto ) {
            if( dto == null )
                return new UserPosition();
            return UserPositionFactory.Create(
                userPositionId : dto.Id.ToGuid(),
                userId : dto.UserId,
                postId : dto.PostId
            );
        }
        
        /// <summary>
        /// 转换为用户岗位数据传输对象
        /// </summary>
        /// <param name="entity">用户岗位实体</param>
        public static UserPositionDto ToDto(this UserPosition entity) {
            if( entity == null )
                return new UserPositionDto();
            return entity.MapTo<UserPositionDto>();
        }

        /// <summary>
        /// 转换为用户岗位数据传输对象
        /// </summary>
        /// <param name="entity">用户岗位实体</param>
        public static UserPositionDto ToDto2( this UserPosition entity ) {
            if( entity == null )
                return new UserPositionDto();
            return new UserPositionDto {
                Id = entity.Id.ToString(),
                UserId = entity.UserId,
                PostId = entity.PostId,
            };
        }
    }
}