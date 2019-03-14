using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 用户权限映射配置
    /// </summary>
    public class UserPermissionMap : Util.Datas.Ef.PgSql.AggregateRootMap<UserPermission> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UserPermission> builder ) {
            builder.ToTable( "UserPermission", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<UserPermission> builder ) {
            //用户权限编号
            builder.Property(t => t.Id)
                .HasColumnName("UserPermissionId");
        }
    }
}
