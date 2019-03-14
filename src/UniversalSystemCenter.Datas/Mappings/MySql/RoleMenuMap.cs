using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 角色菜单映射配置
    /// </summary>
    public class RoleMenuMap : Util.Datas.Ef.MySql.AggregateRootMap<RoleMenu> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<RoleMenu> builder ) {
            builder.ToTable( "RoleMenu" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<RoleMenu> builder ) {
            //角色菜单编号（RoleMenuId）
            builder.Property(t => t.Id)
                .HasColumnName("RoleMenuId");
        }
    }
}
