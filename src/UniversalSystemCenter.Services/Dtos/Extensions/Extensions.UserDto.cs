using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 用户数据传输对象扩展
    /// </summary>
    public static class UserDtoExtension {
        /// <summary>
        /// 转换为用户实体
        /// </summary>
        /// <param name="dto">用户数据传输对象</param>
        public static User ToEntity( this UserDto dto ) {
            if ( dto == null )
                return new User();
            return dto.MapTo( new User( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为用户实体
        /// </summary>
        /// <param name="dto">用户数据传输对象</param>
        public static User ToEntity2( this UserDto dto ) {
            if( dto == null )
                return new User();
            return new User( dto.Id.ToGuid() ) {
                OrganizationsId = dto.OrganizationsId,
                MerchantId = dto.MerchantId,
                Account = dto.Account,
                Nickname = dto.Nickname,
                Password = dto.Password,
                Head = dto.Head,
                Mobile = dto.Mobile,
                RegisterTime = dto.RegisterTime,
                Type = dto.Type,
                State = dto.State,
                Saltd = dto.Saltd,
                IdCard = dto.IdCard,
                RealName = dto.RealName,
                Sex = dto.Sex,
                Referrer = dto.Referrer,
                IsLocked = dto.IsLocked,
                LockBeginTime = dto.LockBeginTime,
                LockDuration = dto.LockDuration,
                LockMessage = dto.LockMessage,
                LastLoginTime = dto.LastLoginTime,
                LastLoginIp = dto.LastLoginIp,
                CurrentLoginTime = dto.CurrentLoginTime,
                CurrentLoginIp = dto.CurrentLoginIp,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为用户实体
        /// </summary>
        /// <param name="dto">用户数据传输对象</param>
        public static User ToEntity3( this UserDto dto ) {
            if( dto == null )
                return new User();
            return UserFactory.Create(
                userId : dto.Id.ToGuid(),
                organizationsId : dto.OrganizationsId,
                merchantId : dto.MerchantId,
                account : dto.Account,
                nickname : dto.Nickname,
                password : dto.Password,
                head : dto.Head,
                mobile : dto.Mobile,
                registerTime : dto.RegisterTime,
                type : dto.Type,
                state : dto.State,
                saltd : dto.Saltd,
                idCard : dto.IdCard,
                realName : dto.RealName,
                sex : dto.Sex,
                referrer : dto.Referrer,
                isLocked : dto.IsLocked,
                lockBeginTime : dto.LockBeginTime,
                lockDuration : dto.LockDuration,
                lockMessage : dto.LockMessage,
                lastLoginTime : dto.LastLoginTime,
                lastLoginIp : dto.LastLoginIp,
                currentLoginTime : dto.CurrentLoginTime,
                currentLoginIp : dto.CurrentLoginIp,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为用户数据传输对象
        /// </summary>
        /// <param name="entity">用户实体</param>
        public static UserDto ToDto(this User entity) {
            if( entity == null )
                return new UserDto();
            return entity.MapTo<UserDto>();
        }

        /// <summary>
        /// 转换为用户数据传输对象
        /// </summary>
        /// <param name="entity">用户实体</param>
        public static UserDto ToDto2( this User entity ) {
            if( entity == null )
                return new UserDto();
            return new UserDto {
                Id = entity.Id.ToString(),
                OrganizationsId = entity.OrganizationsId,
                MerchantId = entity.MerchantId,
                Account = entity.Account,
                Nickname = entity.Nickname,
                Password = entity.Password,
                Head = entity.Head,
                Mobile = entity.Mobile,
                RegisterTime = entity.RegisterTime,
                Type = entity.Type,
                State = entity.State,
                Saltd = entity.Saltd,
                IdCard = entity.IdCard,
                RealName = entity.RealName,
                Sex = entity.Sex,
                Referrer = entity.Referrer,
                IsLocked = entity.IsLocked,
                LockBeginTime = entity.LockBeginTime,
                LockDuration = entity.LockDuration,
                LockMessage = entity.LockMessage,
                LastLoginTime = entity.LastLoginTime,
                LastLoginIp = entity.LastLoginIp,
                CurrentLoginTime = entity.CurrentLoginTime,
                CurrentLoginIp = entity.CurrentLoginIp,
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