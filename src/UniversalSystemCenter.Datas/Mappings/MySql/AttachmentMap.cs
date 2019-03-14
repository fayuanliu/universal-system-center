using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 附件映射配置
    /// </summary>
    public class AttachmentMap : Util.Datas.Ef.MySql.AggregateRootMap<Attachment> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Attachment> builder ) {
            builder.ToTable( "Attachment" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Attachment> builder ) {
            //附件编号（AttachmentId）
            builder.Property(t => t.Id)
                .HasColumnName("AttachmentId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
