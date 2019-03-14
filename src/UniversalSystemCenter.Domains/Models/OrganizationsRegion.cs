using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 部门业务区域
    /// </summary>
    [DisplayName( "部门业务区域" )]
    public partial class OrganizationsRegion : AggregateRoot<OrganizationsRegion> {
        /// <summary>
        /// 初始化部门业务区域
        /// </summary>
        public OrganizationsRegion() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化部门业务区域
        /// </summary>
        /// <param name="id">部门业务区域标识</param>
        public OrganizationsRegion( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [DisplayName( "组织机构编号(OrganizationsId)" )]
        public Guid? OrganizationsId { get; set; }
        /// <summary>
        /// 地区编号
        /// </summary>
        [DisplayName( "地区编号" )]
        [Required(ErrorMessage = "地区编号不能为空")]
        [StringLength( 200, ErrorMessage = "地区编号输入过长，不能超过200位" )]
        public string AddressId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [DisplayName( "详细地址" )]
        [StringLength( 500, ErrorMessage = "详细地址输入过长，不能超过500位" )]
        public string AddressDetail { get; set; }
        /// <summary>
        /// 地址 省市区
        /// </summary>
        [DisplayName( "地址 省市区" )]
        [Required(ErrorMessage = "地址 省市区不能为空")]
        [StringLength( 200, ErrorMessage = "地址 省市区输入过长，不能超过200位" )]
        public string AddressName { get; set; }
        /// <summary>
        /// 组织机构
        /// </summary>
        [ForeignKey( "OrganizationsId" )]
        public Organizations Organizations { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.OrganizationsId );
            AddDescription( t => t.AddressId );
            AddDescription( t => t.AddressDetail );
            AddDescription( t => t.AddressName );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( OrganizationsRegion other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.OrganizationsId, other.OrganizationsId );
            AddChange( t => t.AddressId, other.AddressId );
            AddChange( t => t.AddressDetail, other.AddressDetail );
            AddChange( t => t.AddressName, other.AddressName );
        }
    }
}