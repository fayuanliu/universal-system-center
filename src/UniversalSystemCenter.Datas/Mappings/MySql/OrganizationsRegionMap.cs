using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 部门业务区域映射配置
    /// </summary>
    public class OrganizationsRegionMap : Util.Datas.Ef.MySql.AggregateRootMap<OrganizationsRegion> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<OrganizationsRegion> builder ) {
            builder.ToTable( "OrganizationsRegion" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<OrganizationsRegion> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("DeptRegionId");
        }
    }
}
