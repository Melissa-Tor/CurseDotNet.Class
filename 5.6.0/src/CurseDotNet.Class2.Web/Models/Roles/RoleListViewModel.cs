using System.Collections.Generic;
using CurseDotNet.Class2.Roles.Dto;

namespace CurseDotNet.Class2.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}