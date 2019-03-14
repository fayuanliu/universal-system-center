using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 部门业务区域数据传输对象扩展
    /// </summary>
    public static class OrganizationsRegionDtoExtension {
        /// <summary>
        /// 转换为部门业务区域实体
        /// </summary>
        /// <param name="dto">部门业务区域数据传输对象</param>
        public static OrganizationsRegion ToEntity( this OrganizationsRegionDto dto ) {
            if ( dto == null )
                return new OrganizationsRegion();
            return dto.MapTo( new OrganizationsRegion( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为部门业务区域实体
        /// </summary>
        /// <param name="dto">部门业务区域数据传输对象</param>
        public static OrganizationsRegion ToEntity2( this OrganizationsRegionDto dto ) {
            if( dto == null )
                return new OrganizationsRegion();
            return new OrganizationsRegion( dto.Id.ToGuid() ) {
                OrganizationsId = dto.OrganizationsId,
                AddressId = dto.AddressId,
                AddressDetail = dto.AddressDetail,
                AddressName = dto.AddressName,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为部门业务区域实体
        /// </summary>
        /// <param name="dto">部门业务区域数据传输对象</param>
        public static OrganizationsRegion ToEntity3( this OrganizationsRegionDto dto ) {
            if( dto == null )
                return new OrganizationsRegion();
            return OrganizationsRegionFactory.Create(
                deptRegionId : dto.Id.ToGuid(),
                organizationsId : dto.OrganizationsId,
                addressId : dto.AddressId,
                addressDetail : dto.AddressDetail,
                addressName : dto.AddressName,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为部门业务区域数据传输对象
        /// </summary>
        /// <param name="entity">部门业务区域实体</param>
        public static OrganizationsRegionDto ToDto(this OrganizationsRegion entity) {
            if( entity == null )
                return new OrganizationsRegionDto();
            return entity.MapTo<OrganizationsRegionDto>();
        }

        /// <summary>
        /// 转换为部门业务区域数据传输对象
        /// </summary>
        /// <param name="entity">部门业务区域实体</param>
        public static OrganizationsRegionDto ToDto2( this OrganizationsRegion entity ) {
            if( entity == null )
                return new OrganizationsRegionDto();
            return new OrganizationsRegionDto {
                Id = entity.Id.ToString(),
                OrganizationsId = entity.OrganizationsId,
                AddressId = entity.AddressId,
                AddressDetail = entity.AddressDetail,
                AddressName = entity.AddressName,
                Version = entity.Version,
            };
        }
    }
}