using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 用户角色映射配置
    /// </summary>
    public class UserRoleMap : Util.Datas.Ef.PgSql.AggregateRootMap<UserRole> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UserRole> builder ) {
            builder.ToTable( "UserRole", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<UserRole> builder ) {
            //用户角色编号（UserRoleId）
            builder.Property(t => t.Id)
                .HasColumnName("UserRoleId");
        }
    }
}
