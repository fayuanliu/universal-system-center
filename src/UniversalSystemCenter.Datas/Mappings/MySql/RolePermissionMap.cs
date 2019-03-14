using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 角色权限映射配置
    /// </summary>
    public class RolePermissionMap : Util.Datas.Ef.MySql.AggregateRootMap<RolePermission> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<RolePermission> builder ) {
            builder.ToTable( "RolePermission" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<RolePermission> builder ) {
            //角色权限编号（RolePermissionId）
            builder.Property(t => t.Id)
                .HasColumnName("RolePermissionId");
        }
    }
}
