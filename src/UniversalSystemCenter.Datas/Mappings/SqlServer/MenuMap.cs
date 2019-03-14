using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.SqlServer {
    /// <summary>
    /// 菜单映射配置
    /// </summary>
    public class MenuMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Menu> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Menu> builder ) {
            builder.ToTable( "Menu", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Menu> builder ) {
            //菜单编号（MenuId)
            builder.Property(t => t.Id)
                .HasColumnName("MenuId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
            builder.Property( t => t.Path ).HasColumnName( "Path" );
            builder.Property( t => t.Level ).HasColumnName( "Level" );
        }
    }
}
