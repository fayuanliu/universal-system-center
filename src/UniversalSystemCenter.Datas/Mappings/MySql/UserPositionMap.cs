using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 用户岗位映射配置
    /// </summary>
    public class UserPositionMap : Util.Datas.Ef.MySql.AggregateRootMap<UserPosition> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UserPosition> builder ) {
            builder.ToTable( "UserPosition" );
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
