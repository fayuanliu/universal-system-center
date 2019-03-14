using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 商户应用消息设置映射配置
    /// </summary>
    public class MerchanAppMessageSetMap : Util.Datas.Ef.MySql.AggregateRootMap<MerchanAppMessageSet> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<MerchanAppMessageSet> builder ) {
            builder.ToTable( "MerchanAppMessageSet" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<MerchanAppMessageSet> builder ) {
            //消息设置编号
            builder.Property(t => t.Id)
                .HasColumnName("SetId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
