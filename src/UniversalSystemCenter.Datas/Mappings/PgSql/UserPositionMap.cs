using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 用户岗位映射配置
    /// </summary>
    public class UserPositionMap : Util.Datas.Ef.PgSql.AggregateRootMap<UserPosition> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UserPosition> builder ) {
            builder.ToTable( "UserPosition", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<UserPosition> builder ) {
            //用户岗位编号
            builder.Property(t => t.Id)
                .HasColumnName("UserPositionId");
        }
    }
}
