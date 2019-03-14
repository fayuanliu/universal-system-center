using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 商户映射配置
    /// </summary>
    public class MerchantMap : Util.Datas.Ef.PgSql.AggregateRootMap<Merchant> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Merchant> builder ) {
            builder.ToTable( "Merchant", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Merchant> builder ) {
            //商户编号
            builder.Property(t => t.Id)
                .HasColumnName("MerchantId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
