using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 权限映射配置
    /// </summary>
    public class PermissionMap : Util.Datas.Ef.PgSql.AggregateRootMap<Permission> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Permission> builder ) {
            builder.ToTable( "Permission", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Permission> builder ) {
            //权限编号（PermissionId）
            builder.Property(t => t.Id)
                .HasColumnName("PermissionId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
