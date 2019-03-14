using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 组织机构映射配置
    /// </summary>
    public class OrganizationsMap : Util.Datas.Ef.PgSql.AggregateRootMap<Organizations> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Organizations> builder ) {
            builder.ToTable( "Organizations", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Organizations> builder ) {
            //组织机构编号(OrganizationsId)
            builder.Property(t => t.Id)
                .HasColumnName("OrganizationsId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
            builder.Property( t => t.Path ).HasColumnName( "Path" );
            builder.Property( t => t.Level ).HasColumnName( "Level" );
        }
    }
}
