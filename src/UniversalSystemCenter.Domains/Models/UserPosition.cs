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
    /// 用户岗位
    /// </summary>
    [DisplayName( "用户岗位" )]
    public partial class UserPosition : AggregateRoot<UserPosition> {
        /// <summary>
        /// 初始化用户岗位
        /// </summary>
        public UserPosition() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化用户岗位
        /// </summary>
        /// <param name="id">用户岗位标识</param>
        public UserPosition( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        [DisplayName( "用户编号" )]
        [Required(ErrorMessage = "用户编号不能为空")]
        public Guid UserId { get; set; }
        /// <summary>
        /// 岗位编号
        /// </summary>
        [DisplayName( "岗位编号" )]
        [Required(ErrorMessage = "岗位编号不能为空")]
        public Guid PostId { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        [ForeignKey( "PostId" )]
        public Position Position { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        [ForeignKey( "UserId" )]
        public User User { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.UserId );
            AddDescription( t => t.PostId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( UserPosition other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.UserId, other.UserId );
            AddChange( t => t.PostId, other.PostId );
        }
    }
}