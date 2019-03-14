using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 岗位映射配置
    /// </summary>
    public class PositionMap : Util.Datas.Ef.PgSql.AggregateRootMap<Position> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Position> builder ) {
            builder.ToTable( "Position", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Position> builder ) {
            //类型编号（TypeId）
            builder.Property(t => t.Id)
                .HasColumnName("PostId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
