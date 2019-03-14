using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 附件服务
    /// </summary>
    public class AttachmentService : CrudServiceBase<Attachment, AttachmentDto, AttachmentQuery>, IAttachmentService {
        /// <summary>
        /// 初始化附件服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="attachmentRepository">附件仓储</param>
        public AttachmentService( IUniversalSysCenterUnitOfWork unitOfWork, IAttachmentRepository attachmentRepository )
            : base( unitOfWork, attachmentRepository ) {
            AttachmentRepository = attachmentRepository;
        }
        
        /// <summary>
        /// 附件仓储
        /// </summary>
        public IAttachmentRepository AttachmentRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Attachment> CreateQuery( AttachmentQuery param ) {
            return new Query<Attachment>( param );
        }
    }
}