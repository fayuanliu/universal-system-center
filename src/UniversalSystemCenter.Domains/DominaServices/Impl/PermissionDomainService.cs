using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Domains.DominaServices.Interface;

namespace UniversalSystemCenter.Domains.DominaServices.Impl
{
    public class PermissionDomainService : IPermissionDomainService
    {
        private IPermissionRepository _permissionRepository;
        public PermissionDomainService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        public List<string> GetAbilityByRoleIds(List<Guid> roleIds)
        {
            var data = _permissionRepository.FindAsNoTracking().Where(a => a.IsDeleted == false && a.RolePermissions.Any(b => roleIds.Contains(b.RoleId))).Select(a => a.Code).ToList();
            return data;
        }
    }
}
