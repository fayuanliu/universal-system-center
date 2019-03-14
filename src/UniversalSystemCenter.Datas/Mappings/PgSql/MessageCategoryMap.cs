using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 消息类型映射配置
    /// </summary>
    public class MessageCategoryMap : Util.Datas.Ef.PgSql.AggregateRootMap<MessageCategory> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<MessageCategory> builder ) {
            builder.ToTable( "MessageCategory", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<MessageCategory> builder ) {
            //消息分类编号（MessageCategoryId）
            builder.Property(t => t.Id)
                .HasColumnName("CategoryId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
