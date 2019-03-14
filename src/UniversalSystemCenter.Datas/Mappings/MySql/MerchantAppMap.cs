using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 商户应用映射配置
    /// </summary>
    public class MerchantAppMap : Util.Datas.Ef.MySql.AggregateRootMap<MerchantApp> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<MerchantApp> builder ) {
            builder.ToTable( "MerchantApp" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<MerchantApp> builder ) {
            //商户应用编号
            builder.Property(t => t.Id)
                .HasColumnName("MerchantAppId");
        }
    }
}
