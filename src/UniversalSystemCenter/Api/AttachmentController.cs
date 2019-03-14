using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 附件控制器
    /// </summary>
    public class AttachmentController : CrudControllerBase<AttachmentDto, AttachmentQuery> {
        /// <summary>
        /// 初始化附件控制器
        /// </summary>
        /// <param name="service">附件服务</param>
        public AttachmentController( IAttachmentService service ) : base( service ) {
            AttachmentService = service;
        }

        /// <summary>
        /// 附件服务
        /// </summary>
        public IAttachmentService AttachmentService { get; }
    }
}