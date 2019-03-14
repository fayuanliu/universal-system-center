using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 账户数据传输对象扩展
    /// </summary>
    public static class AccountDtoExtension {
        /// <summary>
        /// 转换为账户实体
        /// </summary>
        /// <param name="dto">账户数据传输对象</param>
        public static Account ToEntity( this AccountDto dto ) {
            if ( dto == null )
                return new Account();
            return dto.MapTo( new Account( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为账户实体
        /// </summary>
        /// <param name="dto">账户数据传输对象</param>
        public static Account ToEntity2( this AccountDto dto ) {
            if( dto == null )
                return new Account();
            return new Account( dto.Id.ToGuid() ) {
                Type = dto.Type,
                State = dto.State,
                Nickname = dto.Nickname,
                Password = dto.Password,
                Head = dto.Head,
                Mobile = dto.Mobile,
                Saltd = dto.Saltd,
                IdCard = dto.IdCard,
                RealName = dto.RealName,
                Sex = dto.Sex,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                    IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为账户实体
        /// </summary>
        /// <param name="dto">账户数据传输对象</param>
        public static Account ToEntity3( this AccountDto dto ) {
            if( dto == null )
                return new Account();
            return AccountFactory.Create(
                accountId : dto.Id.ToGuid(),
                type : dto.Type,
                state : dto.State,
                nickname : dto.Nickname,
                password : dto.Password,
                head : dto.Head,
                mobile : dto.Mobile,
                saltd : dto.Saltd,
                idCard : dto.IdCard,
                realName : dto.RealName,
                sex : dto.Sex,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为账户数据传输对象
        /// </summary>
        /// <param name="entity">账户实体</param>
        public static AccountDto ToDto(this Account entity) {
            if( entity == null )
                return new AccountDto();
            return entity.MapTo<AccountDto>();
        }

        /// <summary>
        /// 转换为账户数据传输对象
        /// </summary>
        /// <param name="entity">账户实体</param>
        public static AccountDto ToDto2( this Account entity ) {
            if( entity == null )
                return new AccountDto();
            return new AccountDto {
                Id = entity.Id.ToString(),
                Type = entity.Type,
                State = entity.State,
                Nickname = entity.Nickname,
                Password = entity.Password,
                Head = entity.Head,
                Mobile = entity.Mobile,
                Saltd = entity.Saltd,
                IdCard = entity.IdCard,
                RealName = entity.RealName,
                Sex = entity.Sex,
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