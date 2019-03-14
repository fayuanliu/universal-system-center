using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 组织机构数据传输对象扩展
    /// </summary>
    public static class OrganizationsDtoExtension {
        /// <summary>
        /// 转换为组织机构实体
        /// </summary>
        /// <param name="dto">组织机构数据传输对象</param>
        public static Organizations ToEntity( this OrganizationsDto dto ) {
            if ( dto == null )
                return new Organizations();
            return dto.MapTo( new Organizations( dto.Id.ToGuid(),"",1 ) );
        }
        
        /// <summary>
        /// 转换为组织机构实体
        /// </summary>
        /// <param name="dto">组织机构数据传输对象</param>
        public static Organizations ToEntity2( this OrganizationsDto dto ) {
            if( dto == null )
                return new Organizations();
            return new Organizations( dto.Id.ToGuid(),"",1 ) {
                MerchantId = dto.MerchantId,
                Name = dto.Name,
                Type = dto.Type,
                State = dto.State,
                IsOpen = dto.IsOpen,
                IsLeave = dto.IsLeave,
                ParentId = dto.ParentId.ToGuidOrNull(),
                Enabled = dto.Enabled.HasValue,
                SortId = dto.SortId,
                PinYin = dto.PinYin,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                FullPath = dto.FullPath,
                IsDeleted = dto.IsDeleted,
                OrgChargeUid = dto.OrgChargeUid,
                AddressId = dto.AddressId,
                AddressDetail = dto.AddressDetail,
                AddressName = dto.AddressName,
                Longitude = dto.Longitude,
                Latitude = dto.Latitude,
                GPSLongitude = dto.GPSLongitude,
                GPSLatitude = dto.GPSLatitude,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为组织机构实体
        /// </summary>
        /// <param name="dto">组织机构数据传输对象</param>
        public static Organizations ToEntity3( this OrganizationsDto dto ) {
            if( dto == null )
                return new Organizations();
            return OrganizationsFactory.Create(
                organizationsId : dto.Id.ToGuid(),
                merchantId : dto.MerchantId,
                name : dto.Name,
                type : dto.Type,
                state : dto.State,
                isOpen : dto.IsOpen,
                isLeave : dto.IsLeave,
                parentId : dto.ParentId.ToGuidOrNull(),
                path : dto.Path,
                level : dto.Level.Value,
                enabled : dto.Enabled.Value,
                sortId : dto.SortId.Value,
                pinYin : dto.PinYin,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                fullPath : dto.FullPath,
                isDeleted : dto.IsDeleted,
                orgChargeUid : dto.OrgChargeUid,
                addressId : dto.AddressId,
                addressDetail : dto.AddressDetail,
                addressName : dto.AddressName,
                longitude : dto.Longitude,
                latitude : dto.Latitude,
                gPSLongitude : dto.GPSLongitude,
                gPSLatitude : dto.GPSLatitude,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为组织机构数据传输对象
        /// </summary>
        /// <param name="entity">组织机构实体</param>
        public static OrganizationsDto ToDto(this Organizations entity) {
            if( entity == null )
                return new OrganizationsDto();
            return entity.MapTo<OrganizationsDto>();
        }

        /// <summary>
        /// 转换为组织机构数据传输对象
        /// </summary>
        /// <param name="entity">组织机构实体</param>
        public static OrganizationsDto ToDto2( this Organizations entity ) {
            if( entity == null )
                return new OrganizationsDto();
            return new OrganizationsDto {
                Id = entity.Id.ToString(),
                MerchantId = entity.MerchantId,
                Name = entity.Name,
                Type = entity.Type,
                State = entity.State,
                IsOpen = entity.IsOpen,
                IsLeave = entity.IsLeave,
                ParentId = entity.ParentId.ToString(),
                Path = entity.Path,
                Level = entity.Level,
                Enabled = entity.Enabled,
                SortId = entity.SortId,
                PinYin = entity.PinYin,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                FullPath = entity.FullPath,
                IsDeleted = entity.IsDeleted,
                OrgChargeUid = entity.OrgChargeUid,
                AddressId = entity.AddressId,
                AddressDetail = entity.AddressDetail,
                AddressName = entity.AddressName,
                Longitude = entity.Longitude,
                Latitude = entity.Latitude,
                GPSLongitude = entity.GPSLongitude,
                GPSLatitude = entity.GPSLatitude,
                Version = entity.Version,
            };
        }
    }
}